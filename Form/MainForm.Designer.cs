namespace AccountBookProgram
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucBook1 = new AccountBookProgram.ucBook();
            this.ucAccount1 = new AccountBookProgram.ucAccount();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.MainLayoutPanel.Controls.Add(this.ucBook1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ucAccount1, 0, 0);
            this.MainLayoutPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, -1);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 1;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(606, 606);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ucBook1
            // 
            this.ucBook1.BackColor = System.Drawing.SystemColors.WindowText;
            this.ucBook1.Location = new System.Drawing.Point(3, 3);
            this.ucBook1.Name = "ucBook1";
            this.ucBook1.Size = new System.Drawing.Size(600, 600);
            this.ucBook1.TabIndex = 1;
            // 
            // ucAccount1
            // 
            this.ucAccount1.BackColor = System.Drawing.SystemColors.WindowText;
            this.ucAccount1.ForeColor = System.Drawing.SystemColors.Window;
            this.ucAccount1.Location = new System.Drawing.Point(3, 3);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(600, 600);
            this.ucAccount1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(606, 606);
            this.Controls.Add(this.MainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Account Book Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucAccount ucAccount1;
        private ucBook ucBook1;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
    }
}

