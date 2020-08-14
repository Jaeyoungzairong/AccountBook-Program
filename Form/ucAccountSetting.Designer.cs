namespace AccountBookProgram
{
    partial class ucAccountSetting
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutAccount = new System.Windows.Forms.TableLayoutPanel();
            this.cbBankName = new System.Windows.Forms.ComboBox();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCapital = new System.Windows.Forms.Label();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCountryName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbConfig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutAccount.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutAccount
            // 
            this.tableLayoutAccount.BackColor = System.Drawing.Color.Black;
            this.tableLayoutAccount.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutAccount.ColumnCount = 2;
            this.tableLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutAccount.Controls.Add(this.cbBankName, 1, 1);
            this.tableLayoutAccount.Controls.Add(this.tbAccountNo, 1, 3);
            this.tableLayoutAccount.Controls.Add(this.tbAccountName, 1, 2);
            this.tableLayoutAccount.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutAccount.Controls.Add(this.label2, 0, 1);
            this.tableLayoutAccount.Controls.Add(this.label3, 0, 2);
            this.tableLayoutAccount.Controls.Add(this.label4, 0, 3);
            this.tableLayoutAccount.Controls.Add(this.cbCountryName, 1, 0);
            this.tableLayoutAccount.Controls.Add(this.label5, 0, 4);
            this.tableLayoutAccount.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutAccount.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutAccount.Name = "tableLayoutAccount";
            this.tableLayoutAccount.RowCount = 5;
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutAccount.Size = new System.Drawing.Size(494, 237);
            this.tableLayoutAccount.TabIndex = 0;
            // 
            // cbBankName
            // 
            this.cbBankName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBankName.BackColor = System.Drawing.SystemColors.Window;
            this.cbBankName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBankName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBankName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbBankName.FormattingEnabled = true;
            this.cbBankName.Location = new System.Drawing.Point(127, 46);
            this.cbBankName.Name = "cbBankName";
            this.cbBankName.Size = new System.Drawing.Size(363, 28);
            this.cbBankName.TabIndex = 19;
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountNo.BackColor = System.Drawing.SystemColors.Window;
            this.tbAccountNo.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAccountNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAccountNo.Location = new System.Drawing.Point(127, 125);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(363, 30);
            this.tbAccountNo.TabIndex = 17;
            this.tbAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAccountNo_KeyPress);
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAccountName.BackColor = System.Drawing.SystemColors.Window;
            this.tbAccountName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAccountName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAccountName.Location = new System.Drawing.Point(127, 85);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(363, 30);
            this.tbAccountName.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbCapital, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbCapital, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(127, 164);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 69);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lbCapital
            // 
            this.lbCapital.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCapital.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCapital.Location = new System.Drawing.Point(4, 1);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(355, 33);
            this.lbCapital.TabIndex = 13;
            this.lbCapital.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCapital
            // 
            this.tbCapital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCapital.BackColor = System.Drawing.SystemColors.Window;
            this.tbCapital.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCapital.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCapital.Location = new System.Drawing.Point(4, 38);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(355, 30);
            this.tbCapital.TabIndex = 12;
            this.tbCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCapital.TextChanged += new System.EventHandler(this.TbCapital_TextChanged);
            this.tbCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCapital_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "은행이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "계좌이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "계좌번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCountryName
            // 
            this.cbCountryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountryName.BackColor = System.Drawing.SystemColors.Window;
            this.cbCountryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountryName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCountryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCountryName.FormattingEnabled = true;
            this.cbCountryName.Location = new System.Drawing.Point(127, 6);
            this.cbCountryName.Name = "cbCountryName";
            this.cbCountryName.Size = new System.Drawing.Size(363, 28);
            this.cbCountryName.TabIndex = 18;
            this.cbCountryName.SelectedIndexChanged += new System.EventHandler(this.CbCountryName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 75);
            this.label5.TabIndex = 11;
            this.label5.Text = "자본금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lbConfig, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(116, 33);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // lbConfig
            // 
            this.lbConfig.BackColor = System.Drawing.Color.Black;
            this.lbConfig.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbConfig.ForeColor = System.Drawing.Color.White;
            this.lbConfig.Image = global::AccountBookProgram.Properties.Resources.Account;
            this.lbConfig.Location = new System.Drawing.Point(84, 0);
            this.lbConfig.Name = "lbConfig";
            this.lbConfig.Size = new System.Drawing.Size(29, 33);
            this.lbConfig.TabIndex = 9;
            this.lbConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbConfig.Click += new System.EventHandler(this.LbConfig_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "국가";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lbCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.Image = global::AccountBookProgram.Properties.Resources.icon_24;
            this.lbCancel.Location = new System.Drawing.Point(4, 1);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(67, 48);
            this.lbCancel.TabIndex = 17;
            this.lbCancel.Click += new System.EventHandler(this.LbCancel_Click);
            // 
            // lbSave
            // 
            this.lbSave.BackColor = System.Drawing.Color.Black;
            this.lbSave.Image = global::AccountBookProgram.Properties.Resources.icon_2;
            this.lbSave.Location = new System.Drawing.Point(422, 1);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(68, 48);
            this.lbSave.TabIndex = 15;
            this.lbSave.Click += new System.EventHandler(this.LbSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(75, 1);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(343, 48);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "계좌 설정";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucAccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutAccount);
            this.Name = "ucAccountSetting";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.UcAccountSetting_VisibleChanged);
            this.tableLayoutAccount.ResumeLayout(false);
            this.tableLayoutAccount.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbCapital;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.ComboBox cbCountryName;
        private System.Windows.Forms.ComboBox cbBankName;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbConfig;
        private System.Windows.Forms.Label label1;
    }
}
