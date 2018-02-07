using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollax
{
    public class servertell
    {
        public static void do_(string text)
        {
            Form1 frm1 = new Form1();
            frm1.toolStripStatusLabel1.Text = text;
            Log.log(text);

        }
    }
}
