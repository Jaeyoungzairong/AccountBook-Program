using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBookProgram
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ConfigData.Instance.WriteXml();
            GV.UpdateDisplayStatus = DispayStatus.AccountSetting;
            ConfigData.Instance.ReadXml();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            GV.UpdateDisplayStatus = DispayStatus.AccountSetting;
            this.Hide();
        }

        private void ConfigForm_VisibleChanged(object sender, EventArgs e)
        {
            tbId.Clear();
            tbPw.Clear();
            pgSettingValue.Enabled = false;
            btnSave.Enabled = false;
            tableLayoutLogin.Enabled = true;

            ConfigData.Instance.ReadXml();
            pgSettingValue.SelectedObject = ConfigData.Instance;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            bool Login = false;
            foreach (Login item in ConfigData.Instance.LoginList)
            {
                bool check = true;
                check &= tbId.Text == item.Id ? true : false;
                check &= tbPw.Text == item.Pw ? true : false;

                if (check) Login = true;
            }

            if (Login)
            {
                tableLayoutLogin.Enabled = false;
                pgSettingValue.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
    }
}
