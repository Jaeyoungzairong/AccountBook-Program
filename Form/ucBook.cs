using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountBookProgram
{
    public partial class ucBook : UserControl
    {
        private DataTable m_DataTable = new DataTable();

        private Timer m_TImer = new Timer();

        private List<long> m_Y = new List<long>();
        private List<long> m_GraphSum = new List<long>();
        private List<long> m_GraphCnt = new List<long>();
        private List<bool> m_GraphComplete = new List<bool>();

        public ucBook()
        {
            InitializeComponent();

            datetimeStart.Format = DateTimePickerFormat.Custom;
            datetimeEnd.Format = DateTimePickerFormat.Custom;
            datetimeStart.CustomFormat = "yyyy-MM";
            datetimeEnd.CustomFormat = "yyyy-MM";

            DataTable dt = new DataTable();
            dt = SqlManager.Instance.Seclect("tblBook", "MIN(날짜)");
            if (dt.Rows.Count > 0)
            {
                datetimeStart.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[0]);
                dt = SqlManager.Instance.Seclect("tblBook", "MAX(날짜)");
                datetimeEnd.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[0]);
            }
            else
            {
                datetimeStart.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day);
                datetimeEnd.Value = DateTime.Now;
            }

            GridViewInit();
            ComboBoxInit();

            m_TImer.Interval = 50;
            m_TImer.Tick += new EventHandler(Timer_Tick);
        }
        
        public void GridViewInit()
        {
            m_DataTable.Clear();
            DataTable dt = SqlManager.Instance.Seclect("tblBook", "*", "ORDER BY 날짜");
            dt.Columns.Add("생활비");
            m_DataTable = dt.Copy();

            foreach (DataRow item in dt.Rows)
            {
                long temp1 = Convert.ToInt64(item[1]);
                long temp2 = Convert.ToInt64(item[2]);
                long temp3 = temp1 - temp2;

                item[1] = temp1.ToString("C0");
                item[2] = temp2.ToString("C0");
                item[3] = temp3.ToString("C0");
            }
            dgBookList.DataSource = dt;
        }

        public void ComboBoxInit()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("ALL");
            cbCategory.Items.Add("지출금");
            cbCategory.Items.Add("월세");
            cbCategory.Items.Add("생활비");
            cbCategory.SelectedIndex = 0;
        }

        public void ButtonEnable(bool Check)
        {
            lbAdd.Enabled = Check;
            lbDelete.Enabled = Check;
            lbModify.Enabled = Check;
            lbAccountBook.Enabled = Check;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < m_Y.Count; i++)
            {
                m_GraphCnt[i] = m_Y[i] / 10;
                if (m_GraphSum[i] < m_Y[i])
                {
                    MainChart.Series[0].Points[i].YValues[0] = m_GraphSum[i];
                    MainChart.Invalidate();
                }
                else
                {
                    MainChart.Series[0].Points[i].YValues[0] = m_Y[i];
                    MainChart.Invalidate();
                    m_GraphComplete[i] = true;
                }
                m_GraphSum[i] += m_GraphCnt[i];
            }

            bool End = true;
            for (int i = 0; i < m_GraphComplete.Count; i++) End &= m_GraphComplete[i];
            if (m_Y.Count < 1) End = true;
            if (End) m_TImer.Stop();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (datetimeStart.Value > datetimeEnd.Value)
            {
                MessageBox.Show("날짜 설정 오류");
            }
            else
            {
                string StartDate = datetimeStart.Value.ToShortDateString();
                string EndDate = datetimeEnd.Value.ToShortDateString();

                m_DataTable.Clear();
                DataTable dt = SqlManager.Instance.Seclect("tblBook", "*", "WHERE 날짜 >= '" + StartDate + "' AND 날짜 <= '" + EndDate + "' ORDER BY 날짜");
                dt.Columns.Add("생활비");
                m_DataTable = dt.Copy();
                foreach (DataRow item in dt.Rows)
                {
                    long temp1 = Convert.ToInt64(item[1]);
                    long temp2 = Convert.ToInt64(item[2]);
                    long temp3 = temp1 - temp2;

                    item[1] = temp1.ToString("C0");
                    item[2] = temp2.ToString("C0");
                    item[3] = temp3.ToString("C0");
                }

                dgBookList.DataSource = dt;

                ComboBoxInit();
            }
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Y.Clear();
            MainChart.Series.Clear();
            MainChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";

            if (cbCategory.SelectedItem.Equals("ALL"))
            {
                MainChart.Series.Add("지출금");
                MainChart.Series.Add("월세");
                MainChart.Series.Add("생활비");

                if (m_DataTable.Rows.Count > 3)
                {
                    for (int i = 0; i < MainChart.Series.Count; i++)
                    {
                        MainChart.Series[i].ChartType = SeriesChartType.Line;
                        MainChart.Series[i].BorderWidth = 3;
                    }
                }
                foreach (DataRow item in m_DataTable.Rows)
                {
                    long temp1 = Convert.ToInt64(item[1]);
                    long temp2 = Convert.ToInt64(item[2]);
                    long temp3 = temp1 - temp2;
                    string X = item[0].ToString().Substring(2, 2) + "/" + item[0].ToString().Substring(5, 2);
                    MainChart.Series[0].Points.AddXY(X, temp1);
                    MainChart.Series[1].Points.AddXY(X, temp2);
                    MainChart.Series[2].Points.AddXY(X, temp3);
                }
            }
            else if (cbCategory.SelectedItem.Equals("지출금"))
            {
                MainChart.Series.Add("지출금");
                MainChart.Series[0].ChartType = SeriesChartType.Column;
                MainChart.Series[0].Color = Color.Blue;
                foreach (DataRow item in m_DataTable.Rows)
                {
                    long temp = Convert.ToInt64(item[1]);
                    string X = item[0].ToString().Substring(2, 2) + "/" + item[0].ToString().Substring(5, 2);
                    MainChart.Series[0].Points.AddXY(X, temp);

                    m_Y.Add(temp);
                }
            }
            else if (cbCategory.SelectedItem.Equals("월세"))
            {
                MainChart.Series.Add("월세");
                MainChart.Series[0].ChartType = SeriesChartType.Column;
                MainChart.Series[0].Color = Color.Orange;
                foreach (DataRow item in m_DataTable.Rows)
                {
                    long temp = Convert.ToInt64(item[2]);
                    string X = item[0].ToString().Substring(2, 2) + "/" + item[0].ToString().Substring(5, 2);
                    MainChart.Series[0].Points.AddXY(X, temp);

                    m_Y.Add(temp);
                }
            }
            else if (cbCategory.SelectedItem.Equals("생활비"))
            {
                MainChart.Series.Add("생활비");
                MainChart.Series[0].ChartType = SeriesChartType.Column;
                MainChart.Series[0].Color = Color.Red;
                foreach (DataRow item in m_DataTable.Rows)
                {
                    long temp = Convert.ToInt64(item[1]) - Convert.ToInt64(item[2]);
                    string X = item[0].ToString().Substring(2, 2) + "/" + item[0].ToString().Substring(5, 2);
                    MainChart.Series[0].Points.AddXY(X, temp);

                    m_Y.Add(temp);
                }
            }
            MainChart.ChartAreas[0].RecalculateAxesScale();
            MainChart.Invalidate();

            m_GraphSum.Clear();
            m_GraphCnt.Clear();
            m_GraphComplete.Clear();
            for (int i = 0; i < m_Y.Count; i++)
            {
                m_GraphSum.Add(0);
                m_GraphCnt.Add(0);
                m_GraphComplete.Add(false);
            }
            m_TImer.Start();
        }

        private void LbAdd_Click(object sender, EventArgs e)
        {
            GV.SaveMode = SaveStatus.Add;
            GV.UpdateDisplayStatus = DispayStatus.BookSetting;
        }

        private void LbDelete_Click(object sender, EventArgs e)
        {
            if (dgBookList.SelectedRows.Count > 0)
            {
                string Date = dgBookList.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show(Date.Substring(0, 7) + "월의 데이터를 삭제하시겠습니까?", "가계부 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string cmd = "WHERE 날짜 = '" + Date.Substring(0, 10) + "'";
                    if (SqlManager.Instance.Delete("tblBook", cmd))
                    {
                        GridViewInit();
                        ComboBoxInit();
                    }
                    else
                    {
                        MessageBox.Show("데이터 삭제 실패");
                    }
                }
            }
            else
            {
                MessageBox.Show("데이터를 선택해 주세요");
            }
        }

        private void LbModify_Click(object sender, EventArgs e)
        {
            if (dgBookList.SelectedRows.Count > 0)
            {
                GV.SaveMode = SaveStatus.Modify;
                GV.UpdateDisplayStatus = DispayStatus.BookSetting;

                DataTable dt = new DataTable();
                string Date = dgBookList.SelectedRows[0].Cells[0].Value.ToString();
                string cmd = "WHERE 날짜 = '" + Date.Substring(0, 10) + "'";
                dt = SqlManager.Instance.Seclect("tblBook", "*", cmd);

                AccountData.Instance.Date = dt.Rows[0].ItemArray[0].ToString();
                AccountData.Instance.Expense = dt.Rows[0].ItemArray[1].ToString();
                AccountData.Instance.HouseRent = dt.Rows[0].ItemArray[2].ToString();

            }
            else
            {
                MessageBox.Show("계좌를 선택해 주세요");
            }
        }

        private void LbAccountBook_Click(object sender, EventArgs e)
        {
            GV.UpdateDisplayStatus = DispayStatus.Account;
        }

        private void DatetimeStart_ValueChanged(object sender, EventArgs e)
        {
            if (datetimeStart.Value.Day != 1)
            {
                DateTime dateTime = datetimeStart.Value.AddDays(1 - datetimeStart.Value.Day);
                datetimeStart.Value = dateTime;
            }
        }
    }
}
