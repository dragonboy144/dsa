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
        int[] steigerungsFaktor = { 1, 1, 2, 3, 4, 5, 8, 10, 20 };

        bool grosseModifikation;
        List<ZWNummericUpDown> großemodifikationen = new List<ZWNummericUpDown>();
        List<NumericUpDown> zfWNuD= new List<NumericUpDown>();
        List<ListBox> faktorBoxListe = new List<ListBox>();

        decimal gesamtzuschlag;
        double aspAenderungProzent;
        decimal aspAenderungAsp;
        decimal aspAenderungAspMin;
        decimal zauberdauerAenderungAktionen;
        decimal zauberdauerAenderungAktionenMin;
        double zauberdauerAenderungProzent;


        private void ZauberWerkstatt_Load(object sender, EventArgs e)
        {
            zfWNuD.Add(nUDZfW1);
            zfWNuD.Add(nUDZfW2);
            zfWNuD.Add(nUDZfW3);
            zfWNuD.Add(nUDZfW4);

            faktorBoxListe.Add(lbFaktor2);
            faktorBoxListe.Add(lbFaktor3);
            faktorBoxListe.Add(lbFaktor4);

            lBSpalte.SelectedIndex = 0;
            lbFaktor2.SelectedIndex = 0;
            lbFaktor3.SelectedIndex = 0;
            lbFaktor4.SelectedIndex = 0;
            WerteFestlegen();
        }

        private void WerteFestlegen()
        {

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
            modZauberdauerVerkuerzen.aspAenderungMinAsp = 1;
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
            modFesteWirkungsdauer.zuschlag = 14;
            //Verringerung der Wirkungsdauer + 4 und je +6
            modWirkungsdauer05X.zuschlag = 6;
            modWirkungsdauer05X.standardZuschlag = 4;
            modWirkungsdauer05X.aspAenderung = -0.10;
            #endregion

            #region Große Modifikationen
            //Veränderung des Wirkungsbereichs + 16 + AF
            modWirkungsbereichAendern.zuschlag = 16 + steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modWirkungsbereichAendern);
            //Freier Wirkungsbereich + 24 + AF 
            modFreierWirkungsbereich.zuschlag = 24 + steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modFreierWirkungsbereich);
            //Minimierung der Zauberdauer + 8 und je +(AF + 12)
            modDauerMinimieren.zuschlag = 12 + steigerungsFaktor[lBSpalte.SelectedIndex];
            modDauerMinimieren.zauberDauerAenderung = -0.10;
            modDauerMinimieren.standardZuschlag = 8;
            großemodifikationen.Add(modDauerMinimieren);
            //Optimierung der AsP - Kosten + 8 und je +(2 x AF +12)
            modAspOptimieren.zuschlag = 12 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];
            modAspOptimieren.aspAenderung = -0.10;
            modAspOptimieren.standardZuschlag = 8;
            großemodifikationen.Add(modAspOptimieren);
            //Potenzierung der Wirkung + 8 und je +(AF + 12)
            modPotenzieren.zuschlag = 12 + steigerungsFaktor[lBSpalte.SelectedIndex];
            modPotenzieren.standardZuschlag = 8;
            modPotenzieren.aspAenderung = 0.80;
            großemodifikationen.Add(modPotenzieren);
            //Erweiterung der Ziele(freiwillig) + 14 + 2 x AF
            modErweitrungFreiwillig.zuschlag = 14 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];
            modErweitrungFreiwillig.aspAenderung = 0.10;
            modErweitrungFreiwillig.aspAenderungMinAsp = 1;
            großemodifikationen.Add(modErweitrungFreiwillig);
            //Erweiterung der Ziele(selbst) + 12 + AF
            modErweiterungSelbst.zuschlag = 12 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];
            modErweiterungSelbst.aspAenderung = 0.10;
            modErweiterungSelbst.aspAenderungMinAsp = 1;
            großemodifikationen.Add(modErweiterungSelbst);
            //Elementare Transition +24 + 4 x AF
            modElementareTransition.zuschlag = 24 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modElementareTransition);
            //Elementare Transition Gegenelement  +30 + 4  x AF
            modElementareTransitionGegenelement.zuschlag = 30 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modElementareTransitionGegenelement);
            //Dämonische Transition +28 + 4 x AF(evtl. +7)
            modDämonischeTransition.zuschlag = 28 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modDämonischeTransition);
            //Metaphorische Transition +30 + 4 x AF
            //Naheliegend
            modMetaphorischeTransition.zuschlag = 30 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modMetaphorischeTransition);
            //Nicht Naheliegend +40 + 4 x AF
            modMetaphorischnichtNah.zuschlag = 40 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modMetaphorischnichtNah);
            //Kombination + 20 + doppelte Summe der AF
            modKombination.zuschlag = 20 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];
            modKomboGegenElement.zuschlag = 7;
            i = Convert.ToInt32(nUDAnzahl.Value);
            i += -2;
            while (i >= 0)
            {
                modKombination.zuschlag += 2 * steigerungsFaktor[faktorBoxListe[i].SelectedIndex];
                i--;
            }
            if (cLBModifikationen.CheckedItems.Contains("SF Simultanzauber"))
            {
                modKombination.zuschlag += -4;
            }
            großemodifikationen.Add(modKombination);
            großemodifikationen.Add(modKomboGegenElement);
            // Umkehrung mit REVERSALIS +18 + 4 x AF
            modReversalis.zuschlag = 18 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];
            modReversalis.aspAenderungAspPunkte = 2;
            modReversalis.zauberDauerAenderungMinAktionen = 2;
            großemodifikationen.Add(modReversalis);
            //Synthese + 32 + doppelte Summe der AF
            modSynthese.zuschlag = 32 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];
            i = Convert.ToInt32(nUDAnzahl.Value);
            i += -2;
            while (i >= 0)
            {
                modSynthese.zuschlag += 2 * steigerungsFaktor[faktorBoxListe[i].SelectedIndex];
                i--;
            }
            großemodifikationen.Add(modSynthese);
            if (cLBModifikationen.CheckedItems.Contains("SF Simultanzauber"))
            {
                modSynthese.zuschlag += -4;
            }

            //merkmale nicht in beiden Zaubern
            modMerkmalenureinmal.zuschlag = 2;
            großemodifikationen.Add(modMerkmalenureinmal);
            //gegensätzliche Elementare Merkmale
            modGegensaetzlicheMerkmale.zuschlag = 7;
            großemodifikationen.Add(modGegensaetzlicheMerkmale);
            //Dämonische und Elementare Merkmale
            modDaemonischElementar.zuschlag = 7;
            großemodifikationen.Add(modDaemonischElementar);
            // Übertragung in eigene Repräsentation +40 + 4 x AF (evtl.nur +25 + 2 x AF)
            if (cLBModifikationen.CheckedItems.Contains("Kenntnis beider Repräsentationen"))
            {
                modRepraesentation.zuschlag = 25 + 2 * steigerungsFaktor[lBSpalte.SelectedIndex];

            }
            else
            {
                modRepraesentation.zuschlag = 40 + 4 * steigerungsFaktor[lBSpalte.SelectedIndex];

            }
            if (cLBModifikationen.CheckedItems.Contains("schelmischer Zauber"))
            {
                modRepraesentation.zuschlag += 7;
            }
            großemodifikationen.Add(modRepraesentation);

            //Kombination von Repräsentationen + 30 + 3xAF
            modKomboRepraesentationen.zuschlag = 30 + 3 * steigerungsFaktor[lBSpalte.SelectedIndex];
            großemodifikationen.Add(modKomboRepraesentationen);

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


        private void bBerechnen_Click(object sender, EventArgs e)
        {
            Berechnen();
        }


        #region Berechnungen durchführen
        private void Berechnen()
        {
            WerteFestlegen();

            gesamtzuschlag = 0;
            aspAenderungAsp = 0;
            aspAenderungAspMin = 0;
            aspAenderungProzent = 0;
            zauberdauerAenderungAktionen = 0;
            zauberdauerAenderungAktionenMin = 0;
            zauberdauerAenderungProzent = 0;

            #region Checken ob Große modifikationen vorgenommen werden
            if (!großemodifikationen.All(ZWNummericUpDown => ZWNummericUpDown.Value <= 0))
            {
                //fals min 1 > 0 ist
                grosseModifikation = true;
            } else
            {
                //fals alle <= 0 sind
                grosseModifikation = false;
            }
            #endregion
            
            #region Zuschläge und Änderungen
            
            List<ZWNummericUpDown> modListe = new List<ZWNummericUpDown>();

            foreach (Control c in gBGrosseModifikationen.Controls) { 
            if (c is ZWNummericUpDown) modListe.Add(c as ZWNummericUpDown);
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is ZWNummericUpDown) modListe.Add(c as ZWNummericUpDown);
            }


            foreach (ZWNummericUpDown mod in modListe)
            {
                if (mod.Value > 0) 
                {
                    decimal i = mod.Value;
                    while(i > 0)
                    {
                        aspAenderungAsp += mod.aspAenderungAspPunkte;
                        aspAenderungProzent += mod.aspAenderung;
                        gesamtzuschlag += mod.zuschlag;
                        zauberdauerAenderungProzent += mod.zauberDauerAenderung;

                        i--;
                    }
                    gesamtzuschlag += mod.standardZuschlag;
                    zauberdauerAenderungAktionen += mod.zauberDauerAenderungMinAktionen;                        
                    aspAenderungAspMin += mod.aspAenderungMinAsp;
                    

                }

            }
           
            if(modZentTechnickAendern.Value > 0 || modZentTechnickWeg.Value > 0 || modTechnickAendern.Value > 0 || modTechnickWeg.Value > 0) 
            {
                gesamtzuschlag += 4;
            }
            #endregion

            #region Veränderungen des Zuschlags 
            
            if(cLBModifikationen.CheckedItems.Contains("Merkmalskenntnis Metamagie"))
            {
                gesamtzuschlag += -1;
            }
            if (cLBModifikationen.CheckedItems.Contains("SF Matrixverständnis"))
            {
                gesamtzuschlag += -2;
            }
            if (cLBModifikationen.CheckedItems.Contains("Spezialisierung Zauberwerkstatt"))
            {
                gesamtzuschlag += -2;
            }
            if (cLBModifikationen.CheckedItems.Contains("zweite passende Merkmalskenntnis"))
            {
                gesamtzuschlag += -2;
            }
            if (cLBModifikationen.CheckedItems.Contains("Hauszauber"))
            {
                gesamtzuschlag += -2;
            }
            if (cLBModifikationen.CheckedItems.Contains("passende Begabung"))
            {
                gesamtzuschlag += -2;
            }
            gesamtzuschlag += nUDMerkmalskenntnisse.Value * -2;
            gesamtzuschlag += nUDBedingungen.Value; 

            if (cLBModifikationen.CheckedItems.Contains("SF Matrixkontrolle"))
            {
                gesamtzuschlag = gesamtzuschlag / 2;
            }

            #endregion

            //Komplexität für neuen Zauber Berechnen


            #region Ap Berechnen
            if (grosseModifikation == true)
            {
                lApKosten.Text = "AP Kosten des neuen Zaubers: " + (steigerungsFaktor[lBSpalte.SelectedIndex] * 40);
            }
            else
            {
                lApKosten.Text = "AP Kosten des neuen Zaubers: " + (steigerungsFaktor[lBSpalte.SelectedIndex] * 20);
            }

            #endregion

            #region ZfW Berechnen
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


            lASPAenderung.Text = "ASP Kosten Änderung in %: " + aspAenderungProzent * 100;
            lASPinASP.Text = "ASP kosten Änderung in ASP: " + aspAenderungAsp;
            lASPMin.Text = "Mindest ASP Änderung in ASP: " + aspAenderungAspMin;
            lZauberdauerAenderung.Text = "Zauberdaueränderung in %: " + zauberdauerAenderungProzent * 100;
            lZauberdauerinAktionen.Text = "Zauberdaueränderung in Aktionen: " + zauberdauerAenderungAktionen;
            lMinZauberdaueränderung.Text = "Mindest Zauberdaueränderung in Aktionen: " + zauberdauerAenderungAktionenMin;
            lZuschlag.Text = "Gesamtzuschlag:" + gesamtzuschlag;
           
            
        }
        #endregion

        private void nUDAnzahl_ValueChanged(object sender, EventArgs e)
        {
            foreach(NumericUpDown nud in zfWNuD)
            {
                nud.Enabled = false;
            }

            i = Convert.ToInt32(nUDAnzahl.Value);
            while(i > 0)
            {
                zfWNuD[i-1].Enabled = true;
                i--;
            }
        }
    }
}
