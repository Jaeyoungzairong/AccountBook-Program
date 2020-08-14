namespace AccountBookProgram
{
    partial class ucAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgAccountList = new System.Windows.Forms.DataGridView();
            this.lbSum = new System.Windows.Forms.Label();
            this.cbBankName = new System.Windows.Forms.ComboBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbCountryName = new System.Windows.Forms.ComboBox();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbModify = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbAccountBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAccountList
            // 
            this.dgAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccountList.BackgroundColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccountList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccountList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgAccountList.Location = new System.Drawing.Point(4, 299);
            this.dgAccountList.MultiSelect = false;
            this.dgAccountList.Name = "dgAccountList";
            this.dgAccountList.ReadOnly = true;
            this.dgAccountList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgAccountList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgAccountList.RowTemplate.Height = 23;
            this.dgAccountList.Size = new System.Drawing.Size(586, 227);
            this.dgAccountList.TabIndex = 0;
            // 
            // lbSum
            // 
            this.lbSum.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSum.Location = new System.Drawing.Point(62, 1);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(165, 48);
            this.lbSum.TabIndex = 1;
            this.lbSum.Text = "\\0";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBankName
            // 
            this.cbBankName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBankName.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbBankName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBankName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBankName.ForeColor = System.Drawing.SystemColors.Window;
            this.cbBankName.FormattingEnabled = true;
            this.cbBankName.Location = new System.Drawing.Point(469, 11);
            this.cbBankName.Name = "cbBankName";
            this.cbBankName.Size = new System.Drawing.Size(111, 28);
            this.cbBankName.TabIndex = 2;
            this.cbBankName.SelectedIndexChanged += new System.EventHandler(this.CbBankName_SelectedIndexChanged);
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Black;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend2);
            this.MainChart.Location = new System.Drawing.Point(4, 63);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(586, 229);
            this.MainChart.TabIndex = 3;
            // 
            // cbCountryName
            // 
            this.cbCountryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountryName.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbCountryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCountryName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCountryName.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCountryName.FormattingEnabled = true;
            this.cbCountryName.Location = new System.Drawing.Point(294, 11);
            this.cbCountryName.Name = "cbCountryName";
            this.cbCountryName.Size = new System.Drawing.Size(108, 28);
            this.cbCountryName.TabIndex = 4;
            this.cbCountryName.SelectedIndexChanged += new System.EventHandler(this.CbCountryName_SelectedIndexChanged);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.MainChart, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutMain.Controls.Add(this.dgAccountList, 0, 2);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.73289F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.35058F));
            this.tableLayoutMain.Size = new System.Drawing.Size(594, 594);
            this.tableLayoutMain.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbCountryName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBankName, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(410, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "은행";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(236, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "국가";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "합계";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lbModify, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbAccountBook, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 533);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 57);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lbModify
            // 
            this.lbModify.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbModify.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModify.Image = global::AccountBookProgram.Properties.Resources.icon_22;
            this.lbModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbModify.Location = new System.Drawing.Point(296, 1);
            this.lbModify.Name = "lbModify";
            this.lbModify.Size = new System.Drawing.Size(139, 55);
            this.lbModify.TabIndex = 22;
            this.lbModify.Text = "계좌수정";
            this.lbModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbModify.Click += new System.EventHandler(this.LbModify_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbDelete.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDelete.Image = global::AccountBookProgram.Properties.Resources.icon_5;
            this.lbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDelete.Location = new System.Drawing.Point(150, 1);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(139, 55);
            this.lbDelete.TabIndex = 21;
            this.lbDelete.Text = "계좌삭제";
            this.lbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDelete.Click += new System.EventHandler(this.LbDelete_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbAdd.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAdd.Image = global::AccountBookProgram.Properties.Resources.icon_21;
            this.lbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAdd.Location = new System.Drawing.Point(4, 1);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(139, 55);
            this.lbAdd.TabIndex = 19;
            this.lbAdd.Text = "계좌추가";
            this.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAdd.Click += new System.EventHandler(this.LbAdd_Click);
            // 
            // lbAccountBook
            // 
            this.lbAccountBook.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbAccountBook.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAccountBook.Image = global::AccountBookProgram.Properties.Resources.icon_6;
            this.lbAccountBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAccountBook.Location = new System.Drawing.Point(442, 1);
            this.lbAccountBook.Name = "lbAccountBook";
            this.lbAccountBook.Size = new System.Drawing.Size(140, 55);
            this.lbAccountBook.TabIndex = 20;
            this.lbAccountBook.Text = "가계부";
            this.lbAccountBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAccountBook.Click += new System.EventHandler(this.LbAccountBook_Click);
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.tableLayoutMain);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccountList;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.ComboBox cbBankName;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.ComboBox cbCountryName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbModify;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Label lbAccountBook;
    }
}
