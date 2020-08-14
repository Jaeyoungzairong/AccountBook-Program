using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBookProgram
{
    public enum DispayStatus
    {
        None,
        Account,
        AccountSetting,
        Book,
        BookSetting,
        Config
    }
    public enum SaveStatus
    {
        None,
        Add,
        Modify,
        Delete
    }
}
