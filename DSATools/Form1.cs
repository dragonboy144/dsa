using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSATools
{
    public partial class Form1 : Form
    {
        string spalte = "A";

        double[] steigerungskosten = { };
        
        double[] steigerungskostenAp = {5, 1, 1, 1, 2, 4, 5, 6, 8, 9, 11, 12, 14, 15, 17, 19, 20, 22, 24, 25, 27, 29, 31, 32, 34, 36, 38, 40, 42, 43, 45, 48};
        double[] steigerungskostenA = {5, 1, 2, 3, 4, 6, 7, 8, 10, 11, 13, 14, 16, 17, 19, 21, 22, 24, 26, 27, 29, 31, 33, 34, 36, 38, 40, 42, 44, 45, 47, 50};
        double[] steigerungskostenB = {10, 2, 4, 6, 8, 11, 14, 17, 19, 22, 25, 28, 32, 35, 38, 41, 45, 48, 51, 55, 58, 62, 65, 69, 73, 76, 80, 84, 87, 91, 95, 100};
        double[] steigerungskostenC = {15, 2, 6, 9, 13, 17, 21, 25, 29, 34, 38, 43, 47, 51, 55, 60, 65, 70, 75, 80, 85, 95, 100, 105, 110, 115, 120, 125, 130, 135, 140, 150};
        double[] steigerungskostenD = {20, 3, 7, 12, 17, 22, 27, 33, 39, 45, 50, 55, 65, 70, 75, 85, 90, 95, 105, 110, 115, 125, 130, 140, 145, 150, 160, 165, 170, 180, 190, 200};
        double[] steigerungskostenE = {25, 4, 9, 15, 21, 28, 34, 41, 48, 55, 65, 70, 80, 85, 95, 105, 110, 120, 130, 135, 145, 155, 165, 170, 180, 190, 200, 210, 220, 230, 240, 250};
        double[] steigerungskostenF = {40, 6, 14, 22, 32, 41, 50, 60, 75, 85, 95, 105, 120, 130, 140, 155, 165, 180, 195, 210, 220, 230, 250, 260, 270, 290, 300, 310, 330, 340, 350, 375};
        double[] steigerungskostenG = {50, 8, 18, 30, 42, 55, 70, 58, 95, 110, 125, 140, 160, 175, 190, 210, 220, 240, 260, 270, 290, 310, 330, 340, 360, 380, 400, 420, 440, 460, 480, 500};
        double[] steigerungskostenH = {100, 16, 35, 60, 85, 110, 140, 165, 195, 220, 250, 280, 320, 350, 380, 410, 450, 480, 510, 550, 580, 620, 650, 690, 720, 760, 800, 830, 870, 910, 950, 1000 };

        public Form1()
        {
            InitializeComponent();
            lBSpalte.SelectedIndex = 0;
            spalte = lBSpalte.Text;
        }

        private void bBerechnen_Click(object sender, EventArgs e)
        {
            APBerechnen();
        }

        public void APBerechnen()
        {
            //SteigerungsTabelleEinlesen(spalte);
            if (spalte == "A*")
            {
                steigerungskosten = steigerungskostenAp;
            }
            else if (spalte == "A")
            {
                steigerungskosten = steigerungskostenA;
            }
            else if (spalte == "B")
            {
                steigerungskosten = steigerungskostenB;
            }
            else if (spalte == "C")
            {
                steigerungskosten = steigerungskostenC;
            }
            else if (spalte == "D")
            {
                steigerungskosten = steigerungskostenD;
            }
            else if (spalte == "E")
            {
                steigerungskosten = steigerungskostenE;
            }
            else if (spalte == "F")
            {
                steigerungskosten = steigerungskostenF;
            }
            else if (spalte == "G")
            {
                steigerungskosten = steigerungskostenG;
            }
            else if (spalte == "H")
            {
                steigerungskosten = steigerungskostenH;
            }

            double zeile = 0;

            if (nUDStartwert.Value < -1)
            {
                zeile = 0;
            }
            else { zeile = Convert.ToDouble(nUDStartwert.Value + 1); }

            double Ap = 0;
            while (zeile <= Convert.ToDouble(nUDEndwert.Value))
            {

                if (zeile <= 31)
                {
                    if(cBEidetisch.Checked == true && cBAkademisch.Checked == true) 
                    { 
                        if(zeile <= 10) 
                        {
                            Ap += (steigerungskosten[Convert.ToInt32(zeile)] / 2) * 0.75; 
                            Console.WriteLine(zeile + " Steigerungskosten = " + (steigerungskosten[Convert.ToInt32(zeile)] / 2) * 0.75); 
                        } else
                        {
                            Ap += steigerungskosten[Convert.ToInt32(zeile)] / 2;
                            Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[Convert.ToInt32(zeile)] / 2);
                        }
                        
                    } 
                    
                    else if(cBEidetisch.Checked == true && cBAkademisch.Checked == false)
                    {
                        Ap += steigerungskosten[Convert.ToInt32(zeile)] / 2;
                        Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[Convert.ToInt32(zeile)] / 2);
                    }
                    
                    else if(cBEidetisch.Checked == false && cBAkademisch.Checked == true)
                    {
                        if(zeile <= 10)
                        {
                            Ap += steigerungskosten[Convert.ToInt32(zeile)] * 0.75;
                            Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[Convert.ToInt32(zeile)] * 0.75);
                        } else
                        {
                            Ap += steigerungskosten[Convert.ToInt32(zeile)];
                            Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[Convert.ToInt32(zeile)]);
                        }
                    }

                    else
                    {
                        Ap += steigerungskosten[Convert.ToInt32(zeile)];
                        Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[Convert.ToInt32(zeile)]);
                    }
                    
                    
                }
                else if (zeile > 31)
                {
                    if(cBEidetisch.Checked == true) 
                    {
                        Ap += steigerungskosten[31] / 2;
                        Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[31] / 2);

                    } 
                    else
                    {
                        Ap += steigerungskosten[31];
                        Console.WriteLine(zeile + " Steigerungskosten = " + steigerungskosten[31]);
                    }
                    
                    
                }
                zeile++;
            }
            tBAPPreis.Text = Ap.ToString();
        }

        private void lBSpalte_SelectedIndexChanged(object sender, EventArgs e)
        {
            spalte = lBSpalte.Text;
            Console.WriteLine(spalte);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
