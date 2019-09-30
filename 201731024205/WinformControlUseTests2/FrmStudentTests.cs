using NUnit.Framework;
using WinformControlUse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformControlUse.Tests
{
    [TestFixture()]
    public class FrmStudentTests
    {
        [Test()]
        public void btnshow_ClickTest()
        {
            FrmStudent frm = new FrmStudent();
            frm.btnshow_Click(null, null);
        }       
    }
}