namespace Ehwaneuro01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNames = new System.Windows.Forms.ComboBox();
            this.BaudRates = new System.Windows.Forms.ComboBox();
            this.Conn_But = new System.Windows.Forms.Button();
            this.Discon_But = new System.Windows.Forms.Button();
            this.Sendtxt = new System.Windows.Forms.TextBox();
            this.Recievtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortNames
            // 
            this.PortNames.FormattingEnabled = true;
            this.PortNames.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11"});
            this.PortNames.Location = new System.Drawing.Point(8, 10);
            this.PortNames.Name = "PortNames";
            this.PortNames.Size = new System.Drawing.Size(85, 20);
            this.PortNames.TabIndex = 0;
            // 
            // BaudRates
            // 
            this.BaudRates.FormattingEnabled = true;
            this.BaudRates.Items.AddRange(new object[] {
            "9600",
            "28800",
            "57600",
            "76800",
            "115200"});
            this.BaudRates.Location = new System.Drawing.Point(8, 36);
            this.BaudRates.Name = "BaudRates";
            this.BaudRates.Size = new System.Drawing.Size(85, 20);
            this.BaudRates.TabIndex = 1;
            // 
            // Conn_But
            // 
            this.Conn_But.Location = new System.Drawing.Point(8, 62);
            this.Conn_But.Name = "Conn_But";
            this.Conn_But.Size = new System.Drawing.Size(85, 20);
            this.Conn_But.TabIndex = 2;
            this.Conn_But.Text = "Connect";
            this.Conn_But.UseVisualStyleBackColor = true;
            this.Conn_But.Click += new System.EventHandler(this.Conn_But_Click);
            // 
            // Discon_But
            // 
            this.Discon_But.Location = new System.Drawing.Point(8, 88);
            this.Discon_But.Name = "Discon_But";
            this.Discon_But.Size = new System.Drawing.Size(85, 20);
            this.Discon_But.TabIndex = 3;
            this.Discon_But.Text = "Disconnect";
            this.Discon_But.UseVisualStyleBackColor = true;
            this.Discon_But.Click += new System.EventHandler(this.Discon_But_Click);
            // 
            // Sendtxt
            // 
            this.Sendtxt.Location = new System.Drawing.Point(99, 10);
            this.Sendtxt.Multiline = true;
            this.Sendtxt.Name = "Sendtxt";
            this.Sendtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sendtxt.Size = new System.Drawing.Size(175, 98);
            this.Sendtxt.TabIndex = 4;
            this.Sendtxt.TextChanged += new System.EventHandler(this.Sendtxt_TextChanged);
            // 
            // Recievtxt
            // 
            this.Recievtxt.Location = new System.Drawing.Point(8, 114);
            this.Recievtxt.Multiline = true;
            this.Recievtxt.Name = "Recievtxt";
            this.Recievtxt.ReadOnly = true;
            this.Recievtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Recievtxt.Size = new System.Drawing.Size(264, 136);
            this.Recievtxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Recievtxt);
            this.Controls.Add(this.Sendtxt);
            this.Controls.Add(this.Discon_But);
            this.Controls.Add(this.Conn_But);
            this.Controls.Add(this.BaudRates);
            this.Controls.Add(this.PortNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNames;
        private System.Windows.Forms.ComboBox BaudRates;
        private System.Windows.Forms.Button Conn_But;
        private System.Windows.Forms.Button Discon_But;
        private System.Windows.Forms.TextBox Sendtxt;
        private System.Windows.Forms.TextBox Recievtxt;
    }
}

