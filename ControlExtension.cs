using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rally
{
    public static class ControlExtension
    {
        public static void MakeDoubleBuffered(this Control control)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                   BindingFlags.SetProperty | 
                   BindingFlags.Instance | 
                   BindingFlags.NonPublic, null,
                   control, new object[] { true });
        }
    }
}
