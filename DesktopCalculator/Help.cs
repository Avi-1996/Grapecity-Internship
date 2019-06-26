using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    public partial class Help : Form
    {
        public Help()
        {
            DrawLayout();
        }

        private void OnHelpMenuClosed(object sender, FormClosedEventArgs e)
        {
            WinCalc.IsHelpMenuOpen = false;
        }
    }
}
