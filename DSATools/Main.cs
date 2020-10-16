using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSATools
{
    public partial class Main : Form
    {
        Form1 fSteigerung = new Form1();
        ZauberWerkstatt fZauberWerkstatt = new ZauberWerkstatt();


        public Main()
        {
            InitializeComponent();
        }

        private void bSteigern_Click(object sender, EventArgs e)
        {
            if (fSteigerung.Visible == false)
            {
                fSteigerung.Show();
            } else
            {
                fSteigerung.Hide();
            }
        }

        private void bZauberwerkstatt_Click(object sender, EventArgs e)
        {
            if (fZauberWerkstatt.Visible == false)
            {
                fZauberWerkstatt.Show();
            }
            else
            {
                fZauberWerkstatt.Hide();
            }
        }
    }
}
