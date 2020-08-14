using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;

namespace AccountBookProgram
{
    public class ConfigData
    {
        public readonly static ConfigData Instance = new ConfigData();

        private string m_FilePath = Application.StartupPath;
        private string m_FileName = "Config.xml";

        private List<Login> m_LoginList;
        private List<CountryData> m_CountryDataList;

        [Category("국가")]
        [DisplayName("국가 정보")]
        public List<CountryData> CountryDataList
        {
            get { return m_CountryDataList; }
            set { m_CountryDataList = value; }
        }

        [Category("로그인")]
        [DisplayName("로그인 정보")]
        public List<Login> LoginList
        {
            get { return m_LoginList; }
            set { m_LoginList = value; }
        }

        public ConfigData()
        {
            m_CountryDataList = new List<CountryData>();
            m_LoginList = new List<Login>();
        }

        public bool ReadXml()
        {
            try
            {
                if (CheckPath() == true)
                {
                    string fileName = m_FilePath + "\\" + m_FileName;
                    if (File.Exists(fileName) == true)
                    {
                        XmlManager<ConfigData> list = new XmlManager<ConfigData>();
                        ConfigData data = list.Read(fileName);
                        if (data != null)
                        {
                            this.CountryDataList = data.CountryDataList;
                            this.LoginList = data.LoginList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + this.ToString());
            }
            return true;
        }

        public void WriteXml()
        {
            try
            {
                if (CheckPath() == true)
                {
                    //string fileName = string.Format("{0}\\EqpCurData.xml", this.m_FilePath);
                    string fileName = m_FilePath + "\\" + m_FileName;
                    XmlManager<ConfigData> list = new XmlManager<ConfigData>();
                    list.Save(fileName, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckPath()
        {
            string filePath;
            if (string.IsNullOrEmpty(m_FilePath)) return false;

            if (Directory.Exists(m_FilePath))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Cur Data folder was not found");
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.Description = "Cur Data folder select";
                dlg.SelectedPath = Application.StartupPath;
                dlg.ShowNewFolderButton = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.SelectedPath;
                    m_FilePath = filePath;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public class CountryData
    {
        private string m_Name;
        private List<BankData> m_BankDataList = new List<BankData>();

        [Category("국가이름")]
        [DisplayName("이름")]
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        [Category("은행")]
        [DisplayName("은행 정보")]
        public List<BankData> BankDataList
        {
            get { return m_BankDataList; }
            set { m_BankDataList = value; }
        }

    }

    public class BankData
    {
        private string m_Name;

        [Category("은행이름")]
        [DisplayName("이름")]
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
    }

    public class Login
    {
        private string m_Id;
        private string m_Pw;

        [Category("1. 아이디")]
        [DisplayName("ID")]
        public string Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        [Category("2. 비밀번호")]
        [DisplayName("PASSWORD")]
        public string Pw
        {
            get { return m_Pw; }
            set { m_Pw = value; }
        }
    }
}
