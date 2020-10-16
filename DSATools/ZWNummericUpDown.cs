using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSATools
{
    public partial class ZWNummericUpDown : NumericUpDown
    {

        public ZWNummericUpDown()
        {
            InitializeComponent();
        }
        public double aspAenderung;
        public decimal aspAenderungAspPunkte;
        public decimal aspAenderungMinAsp;
        public double zauberDauerAenderung;
        public decimal zauberDauerAenderungMinAktionen;
        public decimal zuschlag;
        public decimal standardZuschlag;
    }
}
