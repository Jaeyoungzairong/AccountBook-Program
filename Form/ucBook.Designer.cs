namespace AccountBookProgram
{
    partial class ucBook
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeStart = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbModify = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbAccountBook = new System.Windows.Forms.Label();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgBookList = new System.Windows.Forms.DataGridView();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutMain.Controls.Add(this.MainChart, 0, 1);
            this.tableLayoutMain.Controls.Add(this.dgBookList, 0, 2);
            this.tableLayoutMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMain.Size = new System.Drawing.Size(594, 594);
            this.tableLayoutMain.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.datetimeEnd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.datetimeStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 40);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // datetimeEnd
            // 
            this.datetimeEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetimeEnd.CalendarFont = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeEnd.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeEnd.Location = new System.Drawing.Point(236, 6);
            this.datetimeEnd.MaxDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.datetimeEnd.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datetimeEnd.Name = "datetimeEnd";
            this.datetimeEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datetimeEnd.Size = new System.Drawing.Size(109, 27);
            this.datetimeEnd.TabIndex = 9;
            this.datetimeEnd.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "시작";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(178, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "끝";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datetimeStart
            // 
            this.datetimeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetimeStart.CalendarFont = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeStart.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeStart.Location = new System.Drawing.Point(62, 6);
            this.datetimeStart.MaxDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.datetimeStart.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datetimeStart.Name = "datetimeStart";
            this.datetimeStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datetimeStart.Size = new System.Drawing.Size(109, 27);
            this.datetimeStart.TabIndex = 8;
            this.datetimeStart.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datetimeStart.ValueChanged += new System.EventHandler(this.DatetimeStart_ValueChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(497, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(85, 28);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(439, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "종류";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(352, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.lbAccountBook, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 536);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 54);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lbModify
            // 
            this.lbModify.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbModify.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModify.ForeColor = System.Drawing.SystemColors.Window;
            this.lbModify.Image = global::AccountBookProgram.Properties.Resources.icon_22;
            this.lbModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbModify.Location = new System.Drawing.Point(296, 1);
            this.lbModify.Name = "lbModify";
            this.lbModify.Size = new System.Drawing.Size(139, 52);
            this.lbModify.TabIndex = 22;
            this.lbModify.Text = "수정";
            this.lbModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbModify.Click += new System.EventHandler(this.LbModify_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbDelete.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDelete.Image = global::AccountBookProgram.Properties.Resources.icon_5;
            this.lbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDelete.Location = new System.Drawing.Point(150, 1);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(139, 52);
            this.lbDelete.TabIndex = 21;
            this.lbDelete.Text = "삭제";
            this.lbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDelete.Click += new System.EventHandler(this.LbDelete_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbAdd.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.lbAdd.Image = global::AccountBookProgram.Properties.Resources.icon_21;
            this.lbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAdd.Location = new System.Drawing.Point(4, 1);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(139, 52);
            this.lbAdd.TabIndex = 19;
            this.lbAdd.Text = "추가";
            this.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAdd.Click += new System.EventHandler(this.LbAdd_Click);
            // 
            // lbAccountBook
            // 
            this.lbAccountBook.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbAccountBook.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAccountBook.ForeColor = System.Drawing.SystemColors.Window;
            this.lbAccountBook.Image = global::AccountBookProgram.Properties.Resources.icon_6;
            this.lbAccountBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAccountBook.Location = new System.Drawing.Point(442, 1);
            this.lbAccountBook.Name = "lbAccountBook";
            this.lbAccountBook.Size = new System.Drawing.Size(140, 52);
            this.lbAccountBook.TabIndex = 20;
            this.lbAccountBook.Text = "계좌정보";
            this.lbAccountBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAccountBook.Click += new System.EventHandler(this.LbAccountBook_Click);
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 100F;
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(4, 52);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(586, 241);
            this.MainChart.TabIndex = 3;
            // 
            // dgBookList
            // 
            this.dgBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookList.BackgroundColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBookList.Location = new System.Drawing.Point(4, 300);
            this.dgBookList.MultiSelect = false;
            this.dgBookList.Name = "dgBookList";
            this.dgBookList.ReadOnly = true;
            this.dgBookList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgBookList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgBookList.RowTemplate.Height = 23;
            this.dgBookList.Size = new System.Drawing.Size(586, 227);
            this.dgBookList.TabIndex = 0;
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(600, 600);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeStart;
        private System.Windows.Forms.DataGridView dgBookList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbModify;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbAccountBook;
        private System.Windows.Forms.DateTimePicker datetimeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
    }
}
