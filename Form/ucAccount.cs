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
    public partial class ucAccount : UserControl
    {
        private List<AccountData> m_AccountData = new List<AccountData>();
        private List<string> m_X = new List<string>();
        private List<long> m_Y = new List<long>();

        private Timer m_TImer = new Timer();
        private List<long> m_GraphSum = new List<long>();
        private List<long> m_GraphCnt = new List<long>();
        private List<bool> m_GraphComplete = new List<bool>();
        private long m_Sum = 0;
        private long m_Cnt = 0;
        private bool m_SumComplete = false;

        public ucAccount()
        {
            InitializeComponent();

            ComboBoxesInit();
            //GridViewInit();

            m_TImer.Interval = 50;
            m_TImer.Tick += new EventHandler(Timer_Tick);
        }

        private void ComboBoxesInit()
        {
            cbCountryName.Items.Clear();
            cbBankName.Items.Clear();
            DataTable ds = SqlManager.Instance.DistinctSeclect("tblAccount", "국가");
            foreach (DataRow item in ds.Rows) cbCountryName.Items.Add(item[0]);

            cbCountryName.SelectedItem = "한국";
        }

        public void GridViewInit(string Condition)
        {
            DataTable dt = new DataTable();
            if (Condition == "ALL")
            {
                string cmd = "'" + cbCountryName.SelectedItem.ToString() + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "*", "WHERE 국가 = " + cmd);
            }
            else
            {
                string cmd = "'" + Condition + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "*", "WHERE 은행이름 = " + cmd);
            }

            foreach (DataRow item in dt.Rows)
            {
                long temp = Convert.ToInt64(item[3]);
                if (item[4].ToString() == "한국")
                {
                    item[3] = temp.ToString("C0");
                }
                else
                {
                    item[3] = temp.ToString("C0", new System.Globalization.CultureInfo("en-US"));
                }
            }

            dgAccountList.DataSource = dt;
        }

        private void GraphInit(string Condition)
        {
            DataTable dt = new DataTable();
            m_X.Clear();
            m_Y.Clear();

            if (Condition == "ALL")
            {
                string cmd = "'" + cbCountryName.SelectedItem.ToString() + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "은행이름, 자본금", "WHERE 국가 = " + cmd);

                for (int i = 1; i < cbBankName.Items.Count; i++)
                {
                    long capital = 0;
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item[0].ToString() == cbBankName.Items[i].ToString()) capital += Convert.ToInt64(item[1]);
                    }
                    m_X.Add(cbBankName.Items[i].ToString());
                    m_Y.Add(capital);
                }
            }
            else
            {
                string cmd = "'" + Condition + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "계좌이름, 자본금", "WHERE 은행이름 = " + cmd);

                foreach (DataRow item in dt.Rows)
                {
                    m_X.Add(item[0].ToString());
                    m_Y.Add(Convert.ToInt64(item[1]));
                }
            }

            MainChart.Series.Clear();
            MainChart.Series.Add("자본금");
            MainChart.Series[0].ChartType = SeriesChartType.Column;

            if (cbCountryName.SelectedItem.Equals("한국"))
            {
                MainChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
            }
            else
            {
                MainChart.ChartAreas[0].AxisY.LabelStyle.Format = "${0}";
            }

            int cnt = m_X.Count;
            for (int i = 0; i < m_X.Count; i++)
            {
                MainChart.Series[0].Points.AddXY(m_X[i], m_Y[i]);
                if (m_Y[i] == 0) cnt--;
            }
            if (cnt == 0) MainChart.ChartAreas[0].AxisY.Maximum = 1000;
            else MainChart.ChartAreas[0].AxisY.Maximum = Double.NaN;

            MainChart.ChartAreas[0].RecalculateAxesScale();

            for (int i = 0; i < m_X.Count; i++) MainChart.Series[0].Points[i].YValues[0] = 0;
            MainChart.Invalidate();
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
            long cnt = m_Sum / 10;

            if (m_Cnt < m_Sum)
            {
                if (cbCountryName.SelectedItem.Equals("한국"))
                {
                    lbSum.Text = m_Cnt.ToString("C0");

                }
                else
                {
                    lbSum.Text = m_Cnt.ToString("C0", new System.Globalization.CultureInfo("en-US"));
                }
                m_Cnt += cnt;
            }
            else
            {
                if (cbCountryName.SelectedItem.Equals("한국"))
                {
                    lbSum.Text = m_Sum.ToString("C0");

                }
                else
                {
                    lbSum.Text = m_Sum.ToString("C0", new System.Globalization.CultureInfo("en-US"));
                }
                m_SumComplete = true;
            }

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

            bool End = m_SumComplete;
            for (int i = 0; i < m_GraphComplete.Count; i++) End &= m_GraphComplete[i];
            if (End) m_TImer.Stop();
        }


        private void CbCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBankName.Items.Clear();
            DataTable dt = new DataTable();
            string cmd = "'" + cbCountryName.SelectedItem.ToString() + "'";

            dt = SqlManager.Instance.DistinctSeclect("tblAccount", "은행이름", "WHERE 국가 = " + cmd);
            cbBankName.Items.Add("ALL");
            foreach (DataRow item in dt.Rows) cbBankName.Items.Add(item[0]);

            cbBankName.SelectedIndex = 0;
            //MainChart.DataBindCrossTable(dt.AsEnumerable(), "국가", "국가", "자본금", "Label=국가");
        }

        private void CbBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (cbBankName.SelectedItem.ToString() == "ALL")
            {
                string cmd = "'" + cbCountryName.SelectedItem.ToString() + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "은행이름, 계좌이름, 자본금", "WHERE 국가 = " + cmd);
            }
            else
            {
                string cmd = "'" + cbBankName.SelectedItem.ToString() + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "은행이름, 계좌이름, 자본금", "WHERE 은행이름 = " + cmd);
            }

            GridViewInit(cbBankName.SelectedItem.ToString());
            GraphInit(cbBankName.SelectedItem.ToString());


            m_GraphSum.Clear();
            m_GraphCnt.Clear();
            m_GraphComplete.Clear();
            for (int i = 0; i < m_Y.Count; i++)
            {
                m_GraphSum.Add(0);
                m_GraphCnt.Add(0);
                m_GraphComplete.Add(false);
            }

            m_Sum = 0;
            m_Cnt = 0;
            foreach (DataRow item in dt.Rows) m_Sum += Convert.ToInt64(item[2]);
            m_TImer.Start();
        }

        private void LbAdd_Click(object sender, EventArgs e)
        {
            GV.SaveMode = SaveStatus.Add;
            GV.UpdateDisplayStatus = DispayStatus.AccountSetting;
        }

        private void LbDelete_Click(object sender, EventArgs e)
        {
            if (dgAccountList.SelectedRows.Count > 0)
            {
                string BankName = dgAccountList.SelectedRows[0].Cells[0].Value.ToString();
                string AccountName = dgAccountList.SelectedRows[0].Cells[1].Value.ToString();
                string AccountNo = dgAccountList.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show(BankName + "의 " + AccountName + " 계좌를 삭제하시겠습니까?", "계좌 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string cmd = "WHERE 은행이름 = '" + BankName + "' AND 계좌번호 = '" + AccountNo + "'";
                    if (SqlManager.Instance.Delete("tblAccount", cmd))
                    {
                        GridViewInit("ALL");
                    }
                    else
                    {
                        MessageBox.Show("계좌 삭제 실패");
                    }
                }
            }
            else
            {
                MessageBox.Show("계좌를 선택해 주세요");
            }
        }

        private void LbModify_Click(object sender, EventArgs e)
        {
            if (dgAccountList.SelectedRows.Count > 0)
            {
                GV.SaveMode = SaveStatus.Modify;
                GV.UpdateDisplayStatus = DispayStatus.AccountSetting;

                DataTable dt = new DataTable();
                string BankName = dgAccountList.SelectedRows[0].Cells[0].Value.ToString();
                string AccountNo = dgAccountList.SelectedRows[0].Cells[2].Value.ToString();
                string cmd = "WHERE 은행이름 = '" + BankName + "' AND 계좌번호 = '" + AccountNo + "'";
                dt = SqlManager.Instance.Seclect("tblAccount", "*", cmd);

                AccountData.Instance.BackName = dt.Rows[0].ItemArray[0].ToString();
                AccountData.Instance.AccountName = dt.Rows[0].ItemArray[1].ToString();
                AccountData.Instance.AccountNo = dt.Rows[0].ItemArray[2].ToString();
                AccountData.Instance.Capital = dt.Rows[0].ItemArray[3].ToString();
                AccountData.Instance.Country = dt.Rows[0].ItemArray[4].ToString();

            }
            else
            {
                MessageBox.Show("계좌를 선택해 주세요");
            }
        }

        private void LbAccountBook_Click(object sender, EventArgs e)
        {
            GV.UpdateDisplayStatus = DispayStatus.Book;
        }
    }
}
