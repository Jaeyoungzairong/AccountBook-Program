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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_VisibleChanged(object sender, EventArgs e)
        {
            if (GV.UpdateDisplayStatus == DispayStatus.AccountSetting)
            {
                ucAccountSetting1.Show();
                ucBookSetting1.Hide();
            }
            else if (GV.UpdateDisplayStatus == DispayStatus.BookSetting)
            {
                ucAccountSetting1.Hide();
                ucBookSetting1.Show();
            }
        }
    }
}
