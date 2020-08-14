using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBookProgram
{
    public partial class ucAccountSetting : UserControl
    {
        public ucAccountSetting()
        {
            InitializeComponent();

            ComboBoxesInit();
        }

        private void ComboBoxesInit()
        {
            ConfigData.Instance.ReadXml();

            cbCountryName.Items.Clear();

            foreach (CountryData item in ConfigData.Instance.CountryDataList) cbCountryName.Items.Add(item.Name);
        }

        private bool AccountExistCheck()
        {
            string cmd = "WHERE 은행이름 = '" + cbBankName.SelectedItem.ToString() + "' AND 계좌번호 = '" + tbAccountNo.Text + "'";
            DataTable dt = new DataTable();
            dt = SqlManager.Instance.Seclect("tblAccount", "*", cmd);

            if (dt.Rows.Count > 0)
                return false;
            else
                return true;
        }

        private void LbSave_Click(object sender, EventArgs e)
        {
            bool NoError = true;
            NoError &= cbBankName.SelectedIndex >= 0 ? true : false;
            NoError &= cbCountryName.SelectedIndex >= 0 ? true : false;
            NoError &= tbAccountName.Text.Length > 0 ? true : false;
            NoError &= tbAccountNo.Text.Length > 0 ? true : false;
            NoError &= tbCapital.Text.Length > 0 ? true : false;

            if (!NoError)
            {
                lbTitle.Text = "입력정보오류";
                lbTitle.BackColor = Color.DarkRed;
            }
            else if (GV.SaveMode == SaveStatus.Add)
            {
                if (AccountExistCheck())
                {
                    string cmd = "'" + cbBankName.SelectedItem.ToString() + "', '" + tbAccountName.Text + "', '" 
                        + tbAccountNo.Text + "', '" + tbCapital.Text + "', '" + cbCountryName.SelectedItem.ToString() + "'";

                    if (SqlManager.Instance.Insert("tblAccount", cmd))
                    {
                        GV.UpdateDisplayStatus = DispayStatus.Account;
                        GV.SaveMode = SaveStatus.None;
                    }
                    else
                    {
                        lbTitle.Text = "계좌 추가 실패";
                        lbTitle.BackColor = Color.DarkRed;
                    }
                }
                else
                {
                    lbTitle.Text = "같은 계좌 존재";
                    lbTitle.BackColor = Color.DarkRed;
                }
            }
            else if (GV.SaveMode == SaveStatus.Modify)
            {
                string cmd1 = "계좌이름 = '" + tbAccountName.Text + "', 자본금 = '" + tbCapital.Text + "'";
                string cmd2 = "WHERE 은행이름 = '" + cbBankName.SelectedItem.ToString() + "' AND 계좌번호 = '" + tbAccountNo.Text + "'";
                if (SqlManager.Instance.Update("tblAccount", cmd1, cmd2))
                {
                    GV.UpdateDisplayStatus = DispayStatus.Account;
                    GV.SaveMode = SaveStatus.None;
                }
                else
                {
                    lbTitle.Text = "계좌 수정 실패";
                    lbTitle.BackColor = Color.DarkRed;
                }
            }
        }

        private void LbCancel_Click(object sender, EventArgs e)
        {
            GV.UpdateDisplayStatus = DispayStatus.Account;
            GV.SaveMode = SaveStatus.None;
        }

        private void TbCapital_TextChanged(object sender, EventArgs e)
        {       
            if (tbCapital.Text.Length < 1 || tbCapital.Text.StartsWith("0"))
            {
                tbCapital.Text = "0";
            }
            else if (tbCapital.Text.Length < 5)
            {
                if (cbCountryName.SelectedItem.Equals("한국"))
                {
                    lbCapital.Text = tbCapital.Text + "원";
                }
                else
                {
                    lbCapital.Text = tbCapital.Text + "달러";
                }
            }
            else if (tbCapital.Text.Length < 9)
            {
                string ThousandUnit = tbCapital.Text.Substring(tbCapital.Text.Length - 4, 4);
                char[] array = ThousandUnit.ToCharArray();
                bool AllZero = true;
                int StartNum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != '0')
                    {
                        AllZero = false;
                        StartNum = i;
                        break;
                    }
                }

                if (cbCountryName.SelectedItem.Equals("한국"))
                {
                    if (AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 4) + "만원";
                    else lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 4) + "만" + ThousandUnit.Substring(StartNum, ThousandUnit.Length - StartNum) + "원";

                }
                else
                {
                    if (AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 4) + "만달러";
                    else lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 4) + "만" + ThousandUnit.Substring(StartNum, ThousandUnit.Length - StartNum) + "달러";
                }
            }
            else if (tbCapital.Text.Length < 11)
            {
                string ThousandUnit = tbCapital.Text.Substring(tbCapital.Text.Length - 4, 4);
                string MillionUnit = tbCapital.Text.Substring(tbCapital.Text.Length - 8, 4);
                char[] T_array = ThousandUnit.ToCharArray();
                char[] M_array = MillionUnit.ToCharArray();
                bool T_AllZero = true;
                bool M_AllZero = true;
                int T_StartNum = 0;
                int M_StartNum = 0;
                for (int i = 0; i < T_array.Length; i++)
                {
                    if (T_array[i] != '0')
                    {
                        T_AllZero = false;
                        T_StartNum = i;
                        break;
                    }
                }
                for (int i = 0; i < M_array.Length; i++)
                {
                    if (M_array[i] != '0')
                    {
                        M_AllZero = false;
                        M_StartNum = i;
                        break;
                    }
                }

                if (cbCountryName.SelectedItem.Equals("한국"))
                {
                    if (T_AllZero && M_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억원";
                    else if (M_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만원";
                    else if (T_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "원";
                    else lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "원";

                }
                else
                {
                    if (T_AllZero && M_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억달러";
                    else if (M_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만달러";
                    else if (T_AllZero) lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "달러";
                    else lbCapital.Text = tbCapital.Text.Substring(0, tbCapital.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "달러";

                }
            }
            else
            {
                lbTitle.Text = "자본금이 범위를 초과하였습니다.";
                lbTitle.BackColor = Color.DarkRed;
                tbCapital.Text = tbCapital.Text.Substring(0, 10);
            }
        }

        private void UcAccountSetting_VisibleChanged(object sender, EventArgs e)
        {
            if (GV.SaveMode == SaveStatus.Add)
            {
                lbTitle.Text = "계좌 추가";
                lbTitle.BackColor = Color.DarkBlue;

                cbCountryName.SelectedIndex = 0;
                cbBankName.SelectedIndex = 0;
                tbAccountName.Text = "";
                tbAccountNo.Text = "";
                tbCapital.Text = "0";
                lbCapital.Text = "0원";

                cbCountryName.Enabled = true;
                cbBankName.Enabled = true;
                tbAccountNo.Enabled = true;
                tableLayoutAccount.BackColor = Color.Black;
                tableLayoutAccount.Enabled = true;
            }
            else if (GV.SaveMode == SaveStatus.Modify)
            {
                lbTitle.Text = "계좌 수정";
                lbTitle.BackColor = Color.DarkOrange;

                cbCountryName.SelectedItem = AccountData.Instance.Country;
                cbBankName.SelectedItem = AccountData.Instance.BackName;
                tbAccountName.Text = AccountData.Instance.AccountName;
                tbAccountNo.Text = AccountData.Instance.AccountNo;
                tbCapital.Text = AccountData.Instance.Capital;

                cbCountryName.Enabled = false;
                cbBankName.Enabled = false;
                tbAccountNo.Enabled = false;
                tableLayoutAccount.BackColor = Color.Black;
                tableLayoutAccount.Enabled = true;
            }
        }

        private void TbAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void TbCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void LbConfig_Click(object sender, EventArgs e)
        {
            GV.UpdateDisplayStatus = DispayStatus.Config;
        }

        private void CbCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCountryName.SelectedIndex;
            if (index >= 0)
            {
                cbBankName.Items.Clear();
                foreach (BankData item in ConfigData.Instance.CountryDataList[index].BankDataList)
                {
                    cbBankName.Items.Add(item.Name);
                }
                cbBankName.SelectedIndex = 0;
            }
        }
    }
}
