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
        string path = null;
        string[] steigerungskosten = { "" };

        bool fileSelected = false;

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
            SteigerungsTabelleEinlesen(spalte);
        }

        private void SteigerungsTabelleEinlesen(string spalte)
        {
            int zeilenNr = 1;
            StreamReader Daten = null;

            int gesuchteZeile = 0;

            Console.WriteLine(spalte);
            if (spalte == "A*")
            {
                gesuchteZeile = 1;
            }
            else if (spalte == "A")
            {
                gesuchteZeile = 2;
            }
            else if (spalte == "B")
            {
                gesuchteZeile = 3;
            }
            else if (spalte == "C")
            {
                gesuchteZeile = 4;
            }
            else if (spalte == "D")
            {
                gesuchteZeile = 5;
            }
            else if (spalte == "E")
            {
                gesuchteZeile = 6;
            }
            else if (spalte == "F")
            {
                gesuchteZeile = 7;
            }
            else if (spalte == "G")
            {
                gesuchteZeile = 8;
            }
            else if (spalte == "H")
            {
                gesuchteZeile = 9;
            }
            if (path != null)
            {
                try
                {
                    Daten = new StreamReader(path);

                    // bis Dateiende einlesen
                    while (!Daten.EndOfStream)
                    {
                        Console.WriteLine(zeilenNr);
                        Console.WriteLine(gesuchteZeile);
                        if (zeilenNr != gesuchteZeile)
                        {
                            Daten.ReadLine();
                        }
                        else
                        {
                            string eineZeile = Daten.ReadLine();
                            // Semikolon am Ende der Zeile ggf. löschen
                            if (eineZeile[eineZeile.Length - 1] == ';')
                                eineZeile = eineZeile.Remove(eineZeile.Length - 1);
                            // eingelesene Zeile aufsplitten
                            steigerungskosten = eineZeile.Split(';');
                            Console.WriteLine(steigerungskosten);
                            fileSelected = true;
                            //Daten des Halters einlesen
                        }
                        //Nächste Zeile
                        zeilenNr++;
                    }


                }
                catch (Exception Ex)
                {
                    //Fehler abfangen
                    MessageBox.Show(String.Format("Es ist ein Fehler bei Einlesen der Datei aufgetreten: {0} bei Zeile {1}", Ex.Message, zeilenNr));
                }
                finally
                {
                    if (Daten != null)
                        Daten.Close();
                }
                int i = 0;

                if (nUDStartwert.Value < -1)
                {
                    i = 0;
                }
                else { i = Convert.ToInt32(nUDStartwert.Value + 1); }

                int Ap = 0;
                while (i <= nUDEndwert.Value)
                {
                    
                    if (i <= 31)
                    { 
                        Ap += Convert.ToInt32(steigerungskosten[i]);
                        Console.WriteLine(i + " Steigerungskosten = " + steigerungskosten[i]);
                    } else if(i > 31)
                    {
                        Ap += Convert.ToInt32(steigerungskosten[31]);
                        Console.WriteLine(i + " Steigerungskosten = " + steigerungskosten[31]);
                    }
                    i++;
                }
                tBAPPreis.Text = Ap.ToString();
            }




        }

        private void lBSpalte_SelectedIndexChanged(object sender, EventArgs e)
        {
            spalte = lBSpalte.Text;
            Console.WriteLine(spalte);
        }

        private void bTabelle_Click(object sender, EventArgs e)
        {

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)

            {
                path = OpenFileDialog.FileName;
                bBerechnen.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
