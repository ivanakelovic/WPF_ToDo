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
using System.Windows.Navigation;
using System.Windows.Shapes;

//Uključivanje namespace-a za rad sa mysql bazom
using MySql.Data.MySqlClient;

namespace ToDo
{
    public partial class ucObaveza : UserControl
    {
        //Globalne promjenljive koje služe da bi informacije sa kontrole mogle da se iskoriste u drugim funkcijama
        bool trenutniStatus;
        int idObaveze;
        string nazivObaveze, opisObaveze;
        MySqlConnection konekcija;
        StackPanel panel;

        public ucObaveza(int id, string naziv, string opis, bool zavrsena, MySqlConnection con, StackPanel sp)
        {
            InitializeComponent();

            //Vrijwednosti dobijene kroz konstruktor se dodjeljuju globalnim promjenljivim
            this.trenutniStatus = zavrsena;
            this.idObaveze = id;
            this.nazivObaveze = naziv;
            this.opisObaveze = opis;
            this.konekcija = con;
            this.panel = sp;

            //Ono što je dobijeno u konstruktoru postavlja se na odgovarajuće labele
            lblNaziv.Content = naziv;
            lblOpis.Content = opis;

            //U zavisnosti od statusa obaveze (da li je završena ili nije) postavlja se odgovarajuća slika i pozadina
            //Slike su importovane preko Properties.Resurces i postavljene su na Copy Always da bi se kopirale u izlazni direktorijum aplikacije pa se mogu učitati preko relativne putanje.
            if (zavrsena == true)
            {
                Okvir.Background = Brushes.LightGreen;
                imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\checked.png") as ImageSource; 
            }
            else
            {
                Okvir.Background = Brushes.LightCoral;
                imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\unchecked.png") as ImageSource;
            }
        }

        private void imgSlika_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Klikom na sliku poziva se funkcija za promjenu statusa
            promjeniStatusObaveze();
        }
        
        private void promjeniStatusObaveze()
        {
            //Prilikom promjene statusa obaveze mjenja se vrijednost promjenljive trenutniStatus
            trenutniStatus = !trenutniStatus;

            string sql = "UPDATE obaveze SET Zavrsena = " + trenutniStatus + " WHERE ID = " + idObaveze;
            MySqlCommand komanda = new MySqlCommand(sql, konekcija);
            //Izvršava se upit i postavlja se drugi status obaveze (Ovdje su podaci ažurirani u bazi)
            komanda.ExecuteNonQuery();//Upiti koji nisu tipa SELECT se samo izvršavaju pomoću komande ExecuteNonQuery()

            //Ažurira se odmah i na kontroli stanje (slika i pozadina) - Ovdje se ažuriraju podaci na aplikaciji
            if (trenutniStatus == true)
            {
                Okvir.Background = Brushes.LightGreen;
                imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\checked.png") as ImageSource;
            }
            else
            {
                Okvir.Background = Brushes.LightCoral;
                imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\unchecked.png") as ImageSource;
            }
        }

        private void mniPromjeniStatus_Click(object sender, RoutedEventArgs e)
        {
            //Klikom na stavku menija poziva se funkcija za promjenu statusa
            promjeniStatusObaveze();
        }

        private void mniObrisiObavezu_Click(object sender, RoutedEventArgs e)
        {
            string sql = "DELETE FROM obaveze WHERE ID = " + idObaveze;
            MySqlCommand komanda = new MySqlCommand(sql, konekcija);
            //Upiti koji nisu tipa SELECT se samo izvršavaju pomoću komande ExecuteNonQuery()
            komanda.ExecuteNonQuery();//(Ovdje su podaci obrisani u bazi)

            //Obrisana obaveza se uklanja sa StackPanela - Ovdje se ažurira stanje aplikacije
            panel.Children.Remove(this);
        }

        //Klik na stavku menija Izmjeni obavezu
        private void mniIzmjeniObavezu_Click(object sender, RoutedEventArgs e)
        {
            //Poziva se prozor inputObaveza ali se koristi konstruktor za izmjenu i prosleđuje mu se sve od podataka obaveze na koju je korisnik kliknuo
            inputObaveza izmjeniObavezu = new inputObaveza(nazivObaveze, opisObaveze, trenutniStatus);
            izmjeniObavezu.ShowDialog();
            //Ako je DialogResult = true (Ako je korisnik kliknuo na snimi) izvršava se upit UPDATE
            if (izmjeniObavezu.DialogResult == true)
            {
                //preuzimanje podataka sa forme za izmjenu u lokalne promjenljive, koje se koriste u nastavku.
                trenutniStatus = izmjeniObavezu.statusObaveze;
                nazivObaveze = izmjeniObavezu.nazivObaveze;
                opisObaveze = izmjeniObavezu.opisObaveze;

                //Kreira se upit za UPDATE podataka u bazi. Podaci se preuzimaju iz Property-ja sa prozora inputObaveza
                string sql = "UPDATE obaveze SET Naziv = '" + nazivObaveze + "', Opis = '" + opisObaveze + "', Zavrsena = " + trenutniStatus + " WHERE ID = " + idObaveze;
                MySqlCommand komanda = new MySqlCommand(sql, konekcija);
                //Izvršava se upit UPDATE
                komanda.ExecuteNonQuery();

                //Ažuriraju se podaci na kontroli
                lblNaziv.Content = nazivObaveze;
                lblOpis.Content = opisObaveze;
                
                //Ažurira se odmah i na kontroli stanje (slika i pozadina) - Ovdje se ažuriraju podaci na aplikaciji
                if (trenutniStatus == true)
                {
                    Okvir.Background = Brushes.LightGreen;
                    imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\checked.png") as ImageSource;
                }
                else
                {
                    Okvir.Background = Brushes.LightCoral;
                    imgSlika.Source = new ImageSourceConverter().ConvertFromString(@"Resources\unchecked.png") as ImageSource;
                }
            }
        }
    }
}
