namespace AccountBookProgram
{
    partial class ucBookSetting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutAccount = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbExpense = new System.Windows.Forms.TextBox();
            this.lbExpense = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbHouseRent = new System.Windows.Forms.Label();
            this.tbHouseRent = new System.Windows.Forms.TextBox();
            this.datetimeSetting = new System.Windows.Forms.DateTimePicker();
            this.lblivingExpense = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutAccount.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 3;
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
            // tableLayoutAccount
            // 
            this.tableLayoutAccount.BackColor = System.Drawing.Color.Black;
            this.tableLayoutAccount.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutAccount.ColumnCount = 2;
            this.tableLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutAccount.Controls.Add(this.label1, 0, 3);
            this.tableLayoutAccount.Controls.Add(this.label3, 0, 0);
            this.tableLayoutAccount.Controls.Add(this.label4, 0, 1);
            this.tableLayoutAccount.Controls.Add(this.label5, 0, 2);
            this.tableLayoutAccount.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutAccount.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutAccount.Controls.Add(this.datetimeSetting, 1, 0);
            this.tableLayoutAccount.Controls.Add(this.lblivingExpense, 1, 3);
            this.tableLayoutAccount.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutAccount.Name = "tableLayoutAccount";
            this.tableLayoutAccount.RowCount = 4;
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutAccount.Size = new System.Drawing.Size(494, 237);
            this.tableLayoutAccount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 43);
            this.label1.TabIndex = 23;
            this.label1.Text = "생활비\r\n(지출-월세)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "날짜";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 74);
            this.label4.TabIndex = 10;
            this.label4.Text = "지출금액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 74);
            this.label5.TabIndex = 11;
            this.label5.Text = "월세비용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbExpense, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbExpense, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(152, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 68);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tbExpense
            // 
            this.tbExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExpense.BackColor = System.Drawing.SystemColors.Window;
            this.tbExpense.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbExpense.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbExpense.Location = new System.Drawing.Point(4, 37);
            this.tbExpense.Name = "tbExpense";
            this.tbExpense.Size = new System.Drawing.Size(329, 30);
            this.tbExpense.TabIndex = 17;
            this.tbExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbExpense.TextChanged += new System.EventHandler(this.TbExpense_TextChanged);
            this.tbExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbExpense_KeyPress);
            // 
            // lbExpense
            // 
            this.lbExpense.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbExpense.ForeColor = System.Drawing.SystemColors.Window;
            this.lbExpense.Location = new System.Drawing.Point(4, 1);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(329, 32);
            this.lbExpense.TabIndex = 21;
            this.lbExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbHouseRent, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbHouseRent, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(152, 121);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(337, 68);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lbHouseRent
            // 
            this.lbHouseRent.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbHouseRent.ForeColor = System.Drawing.SystemColors.Window;
            this.lbHouseRent.Location = new System.Drawing.Point(4, 1);
            this.lbHouseRent.Name = "lbHouseRent";
            this.lbHouseRent.Size = new System.Drawing.Size(329, 32);
            this.lbHouseRent.TabIndex = 13;
            this.lbHouseRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHouseRent
            // 
            this.tbHouseRent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHouseRent.BackColor = System.Drawing.SystemColors.Window;
            this.tbHouseRent.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbHouseRent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbHouseRent.Location = new System.Drawing.Point(4, 37);
            this.tbHouseRent.Name = "tbHouseRent";
            this.tbHouseRent.Size = new System.Drawing.Size(329, 30);
            this.tbHouseRent.TabIndex = 12;
            this.tbHouseRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHouseRent.TextChanged += new System.EventHandler(this.TbHouseRent_TextChanged);
            this.tbHouseRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHouseRent_KeyPress);
            // 
            // datetimeSetting
            // 
            this.datetimeSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetimeSetting.CalendarFont = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeSetting.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeSetting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeSetting.Location = new System.Drawing.Point(152, 5);
            this.datetimeSetting.MaxDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.datetimeSetting.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datetimeSetting.Name = "datetimeSetting";
            this.datetimeSetting.Size = new System.Drawing.Size(337, 32);
            this.datetimeSetting.TabIndex = 24;
            this.datetimeSetting.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datetimeSetting.ValueChanged += new System.EventHandler(this.DatetimeSetting_ValueChanged);
            // 
            // lblivingExpense
            // 
            this.lblivingExpense.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblivingExpense.ForeColor = System.Drawing.SystemColors.Window;
            this.lblivingExpense.Location = new System.Drawing.Point(152, 193);
            this.lblivingExpense.Name = "lblivingExpense";
            this.lblivingExpense.Size = new System.Drawing.Size(338, 43);
            this.lblivingExpense.TabIndex = 25;
            this.lblivingExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucBookSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutAccount);
            this.Name = "ucBookSetting";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.UcBookSetting_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutAccount.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAccount;
        private System.Windows.Forms.Label lbExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbHouseRent;
        private System.Windows.Forms.Label lbHouseRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetimeSetting;
        private System.Windows.Forms.Label lblivingExpense;
    }
}
