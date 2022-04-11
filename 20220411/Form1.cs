using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net; //匯入網路通訊協定相關函數
using System.Net.Sockets; //匯入網路插座功能函數
using System.Threading; //匯入多執行緒功能函數
using Microsoft.VisualBasic.PowerPacks; //匯入 VB 向量繪圖功能

namespace _20220411
{
    public partial class Form1 : Form
    {
        UdpClient U; //宣告UDP通訊物件
        Thread Th;   //宣告監聽用執行續

        //繪圖相關變數宣告
        ShapeContainer C; //畫布物件(本機繪圖用)
        ShapeContainer D; //畫布物件(遠端繪圖用)
        Point stP; //繪圖起點
        string p; //筆畫動作字串

        public Form1()
        {
            InitializeComponent();
        }

        //表單載入
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " " + MyIP(); //顯示本機IP於標題列
            C = new ShapeContainer(); //建立畫布(本機繪圖用)
            this.Controls.Add(C); //加入畫布C 到 form1
            D = new ShapeContainer(); //建立畫布(遠端繪圖用)
            this.Controls.Add(D); //加入畫布D 到 form1
        }

        //找出本機IP
        private string MyIP()
        {
            string hn = Dns.GetHostName(); //取得本機電腦名稱
            IPAddress[] ip = Dns.GetHostEntry(hn).AddressList; //取得本機IP陣列(可能有多個)
            foreach (IPAddress it in ip) //列舉各個IP
            {
                if (it.AddressFamily == AddressFamily.InterNetwork) //如果是IPv4格式
                {
                    return it.ToString(); //傳回此IP字串
                }
            }
            return ""; //找不到合格IP，回傳空字串
        }

        //監聽副程序
        private void Listen()
        {
            int Port = int.Parse(tb_Target_Port.Text); //設定監聽用的通訊埠
            U = new UdpClient(Port); //建立UDP監聽物件

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port); //建立監聽端點資訊
            while (true) //持續監聽的無限迴圈→有訊息(True)就處理，無訊息就等待!
            {
                byte[] B = U.Receive(ref EP); //讀取網路訊息(Byte陣列)
                string A = Encoding.Default.GetString(B); //翻譯B陣列為字串A
                string[] z = A.Split('_'); //切割顏色與座標資訊
                string[] Q = z[1].Split('/'); //切割座標點資訊
                Point[] R = new Point[Q.Length]; //宣告座標點陣列

                // 定義繪圖座標點陣列
                for (int i = 0; i < Q.Length; i++)
                {
                    string[] K = Q[i].Split(','); //切割X與Y座標
                    R[i].X = int.Parse(K[0]); //定義第i點X座標
                    R[i].Y = int.Parse(K[1]); //定義第i點Y座標
                }

                //繪製連續線段
                for (int i = 0; i < Q.Length - 1; i++)
                {
                    LineShape L = new LineShape(); //建立線段物件
                    L.StartPoint = R[i]; //線段起點
                    L.EndPoint = R[i + 1]; //線段終點
                    switch (z[0]) //筆色
                    {
                        case "1": //紅筆
                            L.BorderColor = Color.Red;
                            break;
                        case "2": //亮綠筆
                            L.BorderColor = Color.Lime;
                            break;
                        case "3": //藍筆
                            L.BorderColor = Color.Blue;
                            break;
                        case "4": //黑筆
                            L.BorderColor = Color.Black;
                            break;
                    }
                    L.Parent = D; //線段L加入畫布D (遠端使用者繪圖)
                }
            }
        }

        //啟動監聽按鈕程序
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒操作的錯誤
            Th = new Thread(Listen); //建立監聽執行緒，目標副程式→Listen
            Th.Start(); //啟動監聽執行緒
            btn_Connect.Enabled = false; //按鍵失效，不能(也不需要)重複開啟監聽
        }

        //本機端開始繪圖
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            stP = e.Location; //紀錄起點
            p = stP.X.ToString() + "," + stP.Y.ToString(); //紀錄座標
        }

        //本機端繪圖中
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) //左鍵按下時
            {
                LineShape L = new LineShape(); //建立線段物件
                L.StartPoint = stP; //線段起點
                L.EndPoint = e.Location; //線段終點
                if(rdb_Red.Checked) { L.BorderColor = Color.Red; } //紅筆
                if (rdb_Green.Checked) { L.BorderColor = Color.Lime; } //亮綠筆
                if (rdb_Blue.Checked) { L.BorderColor = Color.Blue; } //藍筆
                if (rdb_Black.Checked) { L.BorderColor = Color.Black; } //黑筆
                L.Parent = C; //線段加入線段C
                stP = e.Location; //終點變起點
                p += "/" + stP.X.ToString() + "," + stP.Y.ToString(); //持續記錄座標
            }
        }

        //送出繪圖動作
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int Port = int.Parse(tb_Target_Port.Text); //設定發送的目標Port
            UdpClient S = new UdpClient(tb_Target_IP.Text, Port); //建立UDP物件
            if (rdb_Red.Checked) { p = "1_" + p; } //紅筆
            if (rdb_Green.Checked) { p = "2_" + p; } //亮綠筆
            if (rdb_Blue.Checked) { p = "3_" + p; } //藍筆
            if (rdb_Black.Checked) { p = "4_" + p; } //黑筆
            byte[] B = Encoding.Default.GetBytes(p); //翻譯p字串為B陣列
            S.Send(B, B.Length); //發送資料
            S.Close(); //關閉UDP物件
        }

        //關閉監聽執行續(如果有的話)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort(); //關閉監聽執行續
                U.Close();  //關閉監聽器
            }
            catch
            {
                //忽略錯誤，程式繼續執行
            }
        }

    }
}
