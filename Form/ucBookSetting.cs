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
    public partial class ucBookSetting : UserControl
    {
        public ucBookSetting()
        {
            InitializeComponent();
            datetimeSetting.Format = DateTimePickerFormat.Custom;
            datetimeSetting.CustomFormat = "yyyy-MM";
            datetimeSetting.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day);
        }

        private bool DataExistCheck()
        {
            string cmd = "WHERE 날짜 = '" + datetimeSetting.Value.ToShortDateString() + "'";
            DataTable dt = new DataTable();
            dt = SqlManager.Instance.Seclect("tblBook", "*", cmd);

            if (dt.Rows.Count > 0)
                return false;
            else
                return true;
        }

        private void LbSave_Click(object sender, EventArgs e)
        {
            bool NoError = true;
            NoError &= tbExpense.Text.Length > 0 ? true : false;
            NoError &= tbHouseRent.Text.Length > 0 ? true : false;

            if (!NoError)
            {
                lbTitle.Text = "입력정보오류";
                lbTitle.BackColor = Color.DarkRed;
            }
            else if (GV.SaveMode == SaveStatus.Add)
            {
                if (DataExistCheck())
                {
                    string cmd = "'" + datetimeSetting.Value.ToShortDateString() + "', '" + tbExpense.Text + "', '" + tbHouseRent.Text + "'";


                    if (SqlManager.Instance.Insert("tblBook", cmd))
                    {
                        GV.UpdateDisplayStatus = DispayStatus.Book;
                        GV.SaveMode = SaveStatus.None;
                    }
                    else
                    {
                        lbTitle.Text = "가계부 추가 실패";
                        lbTitle.BackColor = Color.DarkRed;
                    }
                }
                else
                {
                    lbTitle.Text = "같은 정보 존재";
                    lbTitle.BackColor = Color.DarkRed;
                }
            }
            else if (GV.SaveMode == SaveStatus.Modify)
            {
                string cmd1 = "지출금 = '" + tbExpense.Text + "', 월세 = '" + tbHouseRent.Text + "'";
                string cmd2 = "WHERE 날짜 = '" + datetimeSetting.Value.ToShortDateString() + "'";
                if (SqlManager.Instance.Update("tblBook", cmd1, cmd2))
                {
                    GV.UpdateDisplayStatus = DispayStatus.Book;
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
            GV.UpdateDisplayStatus = DispayStatus.Book;
            GV.SaveMode = SaveStatus.None;
        }

        private void DatetimeSetting_ValueChanged(object sender, EventArgs e)
        {
            if (datetimeSetting.Value.Day != 1)
            {
                DateTime dateTime = datetimeSetting.Value.AddDays(1 - datetimeSetting.Value.Day);
                datetimeSetting.Value = dateTime;
            }
        }

        private void TbExpense_TextChanged(object sender, EventArgs e)
        {
            ConvertToCurrency(tbExpense, lbExpense);
            long expense = CalculateLivingExpense();
            lblivingExpense.Text = expense.ToString("C0");
        }


        private void ConvertToCurrency(TextBox textBox, Label label)
        {
            if (textBox.Text.Length < 1 || textBox.Text.StartsWith("0"))
            {
                textBox.Text = "0";
            }
            else if (textBox.Text.Length < 5)
            {
                label.Text = textBox.Text + "원";
            }
            else if (textBox.Text.Length < 9)
            {
                string ThousandUnit = textBox.Text.Substring(textBox.Text.Length - 4, 4);
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

                if (AllZero) label.Text = textBox.Text.Substring(0, textBox.Text.Length - 4) + "만원";
                else label.Text = textBox.Text.Substring(0, textBox.Text.Length - 4) + "만" + ThousandUnit.Substring(StartNum, ThousandUnit.Length - StartNum) + "원";
            }
            else if (textBox.Text.Length < 11)
            {
                string ThousandUnit = textBox.Text.Substring(textBox.Text.Length - 4, 4);
                string MillionUnit = textBox.Text.Substring(textBox.Text.Length - 8, 4);
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

                if (T_AllZero && M_AllZero) label.Text = textBox.Text.Substring(0, textBox.Text.Length - 8) + "억원";
                else if (M_AllZero) label.Text = textBox.Text.Substring(0, textBox.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만원";
                else if (T_AllZero) label.Text = textBox.Text.Substring(0, textBox.Text.Length - 8) + "억" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "원";
                else label.Text = textBox.Text.Substring(0, textBox.Text.Length - 8) + "억" + MillionUnit.Substring(M_StartNum, MillionUnit.Length - M_StartNum) + "만" + ThousandUnit.Substring(T_StartNum, ThousandUnit.Length - T_StartNum) + "원";
            }
            else
            {
                lbTitle.Text = "금액이 범위를 초과하였습니다.";
                lbTitle.BackColor = Color.DarkRed;
                textBox.Text = textBox.Text.Substring(0, 10);
            }
        }

        private long CalculateLivingExpense()
        {
            bool check = true;
            char[] array = tbExpense.Text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
                check &= char.IsDigit(array[i]);

            array = tbHouseRent.Text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
                check &= char.IsDigit(array[i]);

            check &= tbExpense.Text.Length > 0;
            check &= tbHouseRent.Text.Length > 0;

            if (check)
            {
                long expense = Convert.ToInt64(tbExpense.Text);
                long rent = Convert.ToInt64(tbHouseRent.Text);
                return expense - rent;
            }
            else
            {
                return 0;
            }
        }

        private void TbExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void UcBookSetting_VisibleChanged(object sender, EventArgs e)
        {
            if (GV.SaveMode == SaveStatus.Add)
            {
                lbTitle.Text = "가계부 추가";
                lbTitle.BackColor = Color.DarkBlue;
                datetimeSetting.Value = DateTime.Now;
                tbExpense.Text = "0";
                tbHouseRent.Text = "0";
                lbExpense.Text = "0원";
                lbHouseRent.Text = "0원";

                datetimeSetting.Enabled = true;
            }
            else if (GV.SaveMode == SaveStatus.Modify)
            {
                lbTitle.Text = "가계부 수정";
                lbTitle.BackColor = Color.DarkOrange;

                DateTime date = Convert.ToDateTime(AccountData.Instance.Date);
                datetimeSetting.Value = date;
                tbExpense.Text = AccountData.Instance.Expense;
                tbHouseRent.Text = AccountData.Instance.HouseRent;

                datetimeSetting.Enabled = false;
            }
        }

        private void TbHouseRent_TextChanged(object sender, EventArgs e)
        {
            ConvertToCurrency(tbHouseRent, lbHouseRent);
            long expense = CalculateLivingExpense();
            lblivingExpense.Text = expense.ToString("C0");
        }

        private void TbHouseRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
