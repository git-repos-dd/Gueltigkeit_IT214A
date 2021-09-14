using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gueltigkeit
{
    public partial class frm_gueltigkeit : Form
    {
        // Deklaration einer Variable mit dem Namen Zaehler
        // dieser wird der Wert 0 zugewiesen
        // Variable hat den Datentyp int
        // private besagt, dass Variable innerhalb der Klasse gültig ist, also benutzt werden kann
        // die Variable behält ihren Wert auch wenn Methoden verlassen werden
        private int Zaehler = 0;

        public frm_gueltigkeit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zaehler um 1 erhöhen
            Zaehler++;

            // ebenso möglich
            // der neue Wert von Zaehler ist gleich der alte Wert + 1
            Zaehler = Zaehler + 1;

            // lbl_gueltigkeit_1.Text ist vom Datentyp string
            // Zaehler ist vom Datentyp int
            // Konvertierung von int in string mit Hilfe der Methode ToString()
            lbl_gueltigkeit_1.Text = Zaehler.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Variablen, die in der Methode deklariert und zugewiesen werden, sind nur innerhalb der Methode gültig
            // wird die Methode verlassen, ist der Wert der Variablen weg
            int Zaehler_lokal = 0;

            Zaehler_lokal++;

            Zaehler_lokal = Zaehler_lokal + 1;

            lbl_gueltigkeit_2.Text = Zaehler_lokal.ToString();
        }
    }
}
