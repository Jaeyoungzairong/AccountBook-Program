using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AccountBookProgram
{
    public partial class MainForm : Form
    {
        private Thread m_Thread;
        private SettingForm m_SettingForm;
        private ConfigForm m_ConfigForm;

        public MainForm()
        {
            InitializeComponent();
            m_SettingForm = new SettingForm();
            m_ConfigForm = new ConfigForm();

            m_Thread = new Thread(new ThreadStart(ThreadProc));
            m_Thread.Start();
        }

        private void ThreadProc()
        {
            while (true)
            {
                UpdateDisplayStatus(); //화면상태를 표시
                UpdateDBStatus(); //알람상태를 검사
            }
        }

        private void UpdateDisplayStatus()
        {
            if (GV.UpdateDisplayStatus != DispayStatus.None)
            {
                if (this.InvokeRequired)
                {
                    DelVoid_Void del = new DelVoid_Void(UpdateDisplayStatus);
                    this.Invoke(del);
                }
                else
                {
                    if (GV.UpdateDisplayStatus == DispayStatus.Account)
                    {
                        m_SettingForm.Hide();
                        ucAccount1.Show();
                        ucBook1.Hide();

                        ucAccount1.GridViewInit("ALL");
                        ucAccount1.ButtonEnable(true);
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.AccountSetting)
                    {
                        m_SettingForm.Show();
                        ucAccount1.Show();
                        ucBook1.Hide();

                        ucAccount1.ButtonEnable(false);
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.Book)
                    {
                        m_SettingForm.Hide();
                        ucAccount1.Hide();
                        ucBook1.Show();

                        ucBook1.ButtonEnable(true);
                        ucBook1.GridViewInit();
                        ucBook1.ComboBoxInit();
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.BookSetting)
                    {
                        m_SettingForm.Show();
                        ucAccount1.Hide();
                        ucBook1.Show();

                        ucBook1.ButtonEnable(false);
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.Config)
                    {
                        m_SettingForm.Hide();
                        m_ConfigForm.Show();
                    }
                }
                GV.UpdateDisplayStatus = DispayStatus.None;
            }
        }

        private void UpdateDBStatus()
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlManager.Instance.Disconnect();
            m_Thread.Abort();
        }
    }
}
