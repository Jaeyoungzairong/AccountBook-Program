namespace AccountBookProgram
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucAccountSetting1 = new AccountBookProgram.ucAccountSetting();
            this.ucBookSetting1 = new AccountBookProgram.ucBookSetting();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.ucAccountSetting1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ucBookSetting1, 0, 0);
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 1;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(506, 306);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ucAccountSetting1
            // 
            this.ucAccountSetting1.BackColor = System.Drawing.Color.Black;
            this.ucAccountSetting1.Location = new System.Drawing.Point(3, 3);
            this.ucAccountSetting1.Name = "ucAccountSetting1";
            this.ucAccountSetting1.Size = new System.Drawing.Size(500, 300);
            this.ucAccountSetting1.TabIndex = 0;
            // 
            // ucBookSetting1
            // 
            this.ucBookSetting1.BackColor = System.Drawing.Color.Black;
            this.ucBookSetting1.Location = new System.Drawing.Point(3, 3);
            this.ucBookSetting1.Name = "ucBookSetting1";
            this.ucBookSetting1.Size = new System.Drawing.Size(500, 300);
            this.ucBookSetting1.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(506, 306);
            this.ControlBox = false;
            this.Controls.Add(this.MainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.VisibleChanged += new System.EventHandler(this.SettingForm_VisibleChanged);
            this.MainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ucAccountSetting ucAccountSetting1;
        private ucBookSetting ucBookSetting1;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
    }
}