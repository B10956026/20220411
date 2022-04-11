
namespace _20220411
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Target_IP = new System.Windows.Forms.Label();
            this.lbl_Target_Port = new System.Windows.Forms.Label();
            this.lbl_Answer_Port = new System.Windows.Forms.Label();
            this.tb_Target_IP = new System.Windows.Forms.TextBox();
            this.tb_Target_Port = new System.Windows.Forms.TextBox();
            this.tb_Answer_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.rdb_Red = new System.Windows.Forms.RadioButton();
            this.rdb_Blue = new System.Windows.Forms.RadioButton();
            this.rdb_Green = new System.Windows.Forms.RadioButton();
            this.rdb_Black = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_Target_IP
            // 
            this.lbl_Target_IP.AutoSize = true;
            this.lbl_Target_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Target_IP.Location = new System.Drawing.Point(12, 12);
            this.lbl_Target_IP.Name = "lbl_Target_IP";
            this.lbl_Target_IP.Size = new System.Drawing.Size(57, 21);
            this.lbl_Target_IP.TabIndex = 0;
            this.lbl_Target_IP.Text = "目標IP";
            // 
            // lbl_Target_Port
            // 
            this.lbl_Target_Port.AutoSize = true;
            this.lbl_Target_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Target_Port.Location = new System.Drawing.Point(193, 12);
            this.lbl_Target_Port.Name = "lbl_Target_Port";
            this.lbl_Target_Port.Size = new System.Drawing.Size(74, 21);
            this.lbl_Target_Port.TabIndex = 1;
            this.lbl_Target_Port.Text = "目標Port";
            // 
            // lbl_Answer_Port
            // 
            this.lbl_Answer_Port.AutoSize = true;
            this.lbl_Answer_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Answer_Port.Location = new System.Drawing.Point(391, 12);
            this.lbl_Answer_Port.Name = "lbl_Answer_Port";
            this.lbl_Answer_Port.Size = new System.Drawing.Size(74, 21);
            this.lbl_Answer_Port.TabIndex = 2;
            this.lbl_Answer_Port.Text = "接聽Port";
            // 
            // tb_Target_IP
            // 
            this.tb_Target_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Target_IP.Location = new System.Drawing.Point(75, 9);
            this.tb_Target_IP.Name = "tb_Target_IP";
            this.tb_Target_IP.Size = new System.Drawing.Size(100, 29);
            this.tb_Target_IP.TabIndex = 3;
            // 
            // tb_Target_Port
            // 
            this.tb_Target_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Target_Port.Location = new System.Drawing.Point(273, 9);
            this.tb_Target_Port.Name = "tb_Target_Port";
            this.tb_Target_Port.Size = new System.Drawing.Size(100, 29);
            this.tb_Target_Port.TabIndex = 4;
            // 
            // tb_Answer_Port
            // 
            this.tb_Answer_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Answer_Port.Location = new System.Drawing.Point(471, 9);
            this.tb_Answer_Port.Name = "tb_Answer_Port";
            this.tb_Answer_Port.Size = new System.Drawing.Size(100, 29);
            this.tb_Answer_Port.TabIndex = 5;
            // 
            // btn_Connect
            // 
            this.btn_Connect.AutoSize = true;
            this.btn_Connect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Connect.Location = new System.Drawing.Point(595, 7);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 31);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "連線";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // rdb_Red
            // 
            this.rdb_Red.AutoSize = true;
            this.rdb_Red.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_Red.Location = new System.Drawing.Point(16, 67);
            this.rdb_Red.Name = "rdb_Red";
            this.rdb_Red.Size = new System.Drawing.Size(58, 25);
            this.rdb_Red.TabIndex = 7;
            this.rdb_Red.TabStop = true;
            this.rdb_Red.Text = "Red";
            this.rdb_Red.UseVisualStyleBackColor = true;
            // 
            // rdb_Blue
            // 
            this.rdb_Blue.AutoSize = true;
            this.rdb_Blue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_Blue.Location = new System.Drawing.Point(160, 67);
            this.rdb_Blue.Name = "rdb_Blue";
            this.rdb_Blue.Size = new System.Drawing.Size(61, 25);
            this.rdb_Blue.TabIndex = 8;
            this.rdb_Blue.TabStop = true;
            this.rdb_Blue.Text = "Blue";
            this.rdb_Blue.UseVisualStyleBackColor = true;
            // 
            // rdb_Green
            // 
            this.rdb_Green.AutoSize = true;
            this.rdb_Green.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_Green.Location = new System.Drawing.Point(80, 67);
            this.rdb_Green.Name = "rdb_Green";
            this.rdb_Green.Size = new System.Drawing.Size(74, 25);
            this.rdb_Green.TabIndex = 9;
            this.rdb_Green.TabStop = true;
            this.rdb_Green.Text = "Green";
            this.rdb_Green.UseVisualStyleBackColor = true;
            // 
            // rdb_Black
            // 
            this.rdb_Black.AutoSize = true;
            this.rdb_Black.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_Black.Location = new System.Drawing.Point(227, 67);
            this.rdb_Black.Name = "rdb_Black";
            this.rdb_Black.Size = new System.Drawing.Size(68, 25);
            this.rdb_Black.TabIndex = 10;
            this.rdb_Black.TabStop = true;
            this.rdb_Black.Text = "Black";
            this.rdb_Black.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.rdb_Black);
            this.Controls.Add(this.rdb_Green);
            this.Controls.Add(this.rdb_Blue);
            this.Controls.Add(this.rdb_Red);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.tb_Answer_Port);
            this.Controls.Add(this.tb_Target_Port);
            this.Controls.Add(this.tb_Target_IP);
            this.Controls.Add(this.lbl_Answer_Port);
            this.Controls.Add(this.lbl_Target_Port);
            this.Controls.Add(this.lbl_Target_IP);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UDP塗鴉牆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Target_IP;
        private System.Windows.Forms.Label lbl_Target_Port;
        private System.Windows.Forms.Label lbl_Answer_Port;
        private System.Windows.Forms.TextBox tb_Target_IP;
        private System.Windows.Forms.TextBox tb_Target_Port;
        private System.Windows.Forms.TextBox tb_Answer_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.RadioButton rdb_Red;
        private System.Windows.Forms.RadioButton rdb_Blue;
        private System.Windows.Forms.RadioButton rdb_Green;
        private System.Windows.Forms.RadioButton rdb_Black;
    }
}

