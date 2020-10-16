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
    public partial class ZauberWerkstatt : Form
    {
        public ZauberWerkstatt()
        {
            InitializeComponent();
        }
        
        int i;
        int[] steigerungsFaktor = {1,1,2,3,4,5,8,10,20};

        bool grosseModifikation;
        List<CheckBox> großemodifikationen = new List<CheckBox>();

        decimal gesamtzuschlag;
        decimal aspAenderung;
        decimal zauberdauerAenderung;

        private void ZauberWerkstatt_Load(object sender, EventArgs e)
        {
            lBSpalte.SelectedIndex = 0;
            #region Liste erstellen
            großemodifikationen.Add(cBDaemonischeTransition);
            großemodifikationen.Add(cBElementareTransition);
            großemodifikationen.Add(cBGegenelement);
            großemodifikationen.Add(cBKombination);
            großemodifikationen.Add(cBKomboRepraesentation);
            großemodifikationen.Add(cBMetaphorischeTransition);
            großemodifikationen.Add(cBReversalis);
            großemodifikationen.Add(cBSynthese);
            großemodifikationen.Add(cBUebertragungRepresentation);
            großemodifikationen.Add(cBWirkungsbereichAendern);
            großemodifikationen.Add(cBWirkungsbereichFrei);
            großemodifikationen.Add(cBErweiterungZieleF);
            großemodifikationen.Add(cbErweiterungZieleS);
            #endregion
            #region Werte festlegen
            #region Kleine Modifikationen
            //Zuschlag für Technick hinzufügen

            //Veränderte Technik +4 und je +4 / +8 bzw. + 8 / +14
            //Zentral weglassen
            modZentTechnickWeg.zuschlag = 14;
            //Zentral ändern
            modZentTechnickAendern.zuschlag = 8;
            //Nichtzentral weglassen
            modTechnickVerfeinern.zuschlag = 8;
            //Nichtzentral ändern
            modTechnickAendern.zuschlag = 4;
            //Verfeinerte Technik +4 und je +8
            modTechnickVerfeinern.zuschlag = 8;
            modTechnickVerfeinern.zauberDauerAenderung = 0.05;
            modTechnickVerfeinern.zauberDauerAenderungMinAktionen = 2;
            modTechnickVerfeinern.aspAenderung = -0.10;
            modTechnickVerfeinern.aspAenderungMinAsp = -1;
            modZauberdauerVerkuerzen.standardZuschlag = 4;
            //Verlängerte Zauberdauer +4 und je +AF
            modZauberdauerVerlängern.zuschlag = steigerungsFaktor[lBSpalte.SelectedIndex];
            modZauberdauerVerkuerzen.standardZuschlag = 4;
            //Verkürzte Zauberdauer +4 und je +(AF + 4)
            modZauberdauerVerkuerzen.zuschlag = steigerungsFaktor[lBSpalte.SelectedIndex] + 4;
            modZauberdauerVerkuerzen.standardZuschlag = 4;
            modZauberdauerVerkuerzen.aspAenderung = 0.10;
            modZauberdauerVerkuerzen.aspAenderungMinAsp= 1;
            //Zauberwirkung erzwingen +8 und je +6
            modErzwingen.zuschlag = 6;
            modErzwingen.standardZuschlag = 8;
            modErzwingen.aspAenderungAspPunkte = 3;
            modErzwingen.zauberDauerAenderungMinAktionen = 1;
            //Astralenergie einsparen +4 und je +(AF + 6)
            modAspSparen.zuschlag = 6 + steigerungsFaktor[lBSpalte.SelectedIndex];
            modAspSparen.aspAenderung = -0.10;
            modAspSparen.standardZuschlag = 4;
            //Zauber auf freiwillige Einzelperson +12
            modaufFreiwilligeEinzelperson.zuschlag = 12;
            modaufFreiwilligeEinzelperson.aspAenderung = -0.10;
            //Zauber auf Mehrere Gefährten +4 und je +7
            modMehrLeute.zuschlag = 7;
            modMehrLeute.standardZuschlag = 4;
            //Vergrößerung der Reichweite + 4 und je +8
            modReichweiteVergroessern.zuschlag = 8;
            modReichweiteVergroessern.standardZuschlag = 4;
            modReichweiteVergroessern.aspAenderung = 0.05;
            modReichweiteVergroessern.aspAenderungMinAsp = 1;
            //Verkleinerung der Reichweite + 4 und je +4
            modReichweiteVerkleinern.zuschlag = 4;
            modReichweiteVerkleinern.standardZuschlag = 4;
            modReichweiteVerkleinern.aspAenderung = -0.05;
            //Vergrößerung der Wirkungsdauer + 4 und je +10
            modWirkungsdauer2x.zuschlag = 10;
            modWirkungsdauer2x.standardZuschlag = 4;
            modWirkungsdauer2x.aspAenderung = 0.20;
            //Feste Wirkungsdauer +14

            //Verringerung der Wirkungsdauer + 4 und je +6
            modWirkungsdauer05X.zuschlag = 6;
            modWirkungsdauer05X.standardZuschlag = 4;
            modWirkungsdauer05X.aspAenderung = -0.10;
            #endregion
            #endregion

        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            e.Cancel = true;
            this.Hide();

        }

        private void lBSpalte_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void numericUpDownZauber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nUDAnzahl_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownZauber_ValueChanged(sender,e);
        }

        private void bTechnickAendern_Click(object sender, EventArgs e)
        {

        }

        private void bBerechnen_Click(object sender, EventArgs e)
        {
            Berechnen();
        }


        #region Berechnungen durchführen
        private void Berechnen()
        {
            //Checken ob Große modifikationen vorgenommen werden
            bool[] checkedList = {false,false,false,false,false,false,false,false,false,false,false,false,false};
            i = 0;
            foreach(CheckBox cb in großemodifikationen)
            {
                checkedList[i] = cb.Checked;
                i++;
            }
            //Überprüfen ob alle bools in checked list false sind
            if (!checkedList.All(cb => cb == false))
            {
                //false min 1 true ist
                grosseModifikation = true;
            } else
            {
                //false alle false sind
                grosseModifikation = false;
            }

            //Zuschlag für Technick hinzufügen



            //Ap Berechnen
            if (grosseModifikation == true)
            {
                lApKosten.Text = "AP Kosten des neuen Zaubers: " + (steigerungsFaktor[lBSpalte.SelectedIndex] * 40);
            }
            else
            {
                lApKosten.Text = "AP Kosten des neuen Zaubers: " + (steigerungsFaktor[lBSpalte.SelectedIndex] * 20);
            }

            #region Änderungen



            #endregion

            //ZfW Berechnen
            decimal[] zfWListedec = { nUDZfW1.Value, nUDZfW2.Value, nUDZfW3.Value, nUDZfW4.Value };
            int[] zfWListe = { Convert.ToInt32(zfWListedec[0]), 1000, 1000, 1000 };

            i = 0;

            while (i < Convert.ToInt32(nUDAnzahl.Value))
            {
                zfWListe[i] = Convert.ToInt32(zfWListedec[i]);
                i++;
            }

            if (zfWListe.Min() - gesamtzuschlag / 2 > 0)
            {
                lZfW.Text = "ZfW des neuen Zaubers: " + Convert.ToString(zfWListe.Min() - gesamtzuschlag / 2);
            }
            else
            {
                lZfW.Text = "ZfW des neuen Zaubers: 0";
            }

            #endregion

        }
    }
}
