using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToDo
{
    public partial class inputObaveza : Window
    {
        //Kreirani su Property-ji za sve podatke iz polja
        public string nazivObaveze { get; set; }
        public string opisObaveze { get; set; }
        public bool statusObaveze { get; set; }

        //Konstruktor koji se poziva kada se dodaje nova obaveza
        public inputObaveza()
        {
            InitializeComponent();
        }

        //Konstruktor koji se poziva kada se mijenja postojeća obaveza
        //Zbog toga se prilikom poziva prosleđuju podaci o obavezi koja se mijenja
        public inputObaveza(string naziv, string opis, bool status)
        {
            InitializeComponent();

            //U polja na formi se učitavaju podaci koji su dobijeni kroz konstruktor
            txtNazivObaveze.Text = naziv;
            txtOpisObaveze.Text = opis;
            chkStatusObaveze.IsChecked = status;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        //Koristi se za snimanje podataka i kod unosa i kod izmjene
        private void btnSnimi_Click(object sender, RoutedEventArgs e)
        {
            //Omogućeno snimanje samo ako ima nešto u poljima
            if (txtNazivObaveze.Text != "" && txtOpisObaveze.Text != "")
            {
                //Vrijednost property-ja se postavlja na vrijednosti iz polja
                nazivObaveze = txtNazivObaveze.Text;
                opisObaveze = txtOpisObaveze.Text;
                statusObaveze = (bool)chkStatusObaveze.IsChecked;

                //DialogResult se postavlja na true. Ovim se zatvara forma  i znamo da su podaci uspješno snimljeni
                this.DialogResult = true;
            }
            else
                MessageBox.Show("Moraju biti popunjena sva polja!");
        }
    }
}
