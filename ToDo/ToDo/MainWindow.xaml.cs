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
    public partial class MainWindow : Window
    {
        //Globalno definisana promjenljiva da bi se mogla upotrebljavati u svsim funkcijama ove klase
        MySqlConnection konekcija = null;
        //prikaz null - prikazane sve obaveze
        //true - prikazane završene; false - prikazane ne završene obaveze
        bool? prikaz = null;//Sa bool? definiše se bool vrijednost koja može imati 3 vrijednosti (null, true ili false)

        public MainWindow()
        {
            InitializeComponent();
            //konekcioni string 
            string con_string = "Server=localhost;Database=ispit;Uid=root;Pwd=;";
            konekcija = new MySqlConnection(con_string);

            try
            {
                //Otvara se konekcija na bazu podataka
                konekcija.Open();
                //Poziva se funkcija za učitavanje svih obaveza
                ucitajObaveze();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u konekciji sa bazom!");
            }
        }

        private void lblZatvori_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void ucitajObaveze()
        {
            //Prije učitavanja obaveza čisti se stack panel da bi se prikazale samo one obaveze koje trebaju (zavisno od filtriranja)
            spObaveza.Children.Clear();

            //Definisanje osnovnog dijela upita
            string sql = "SELECT * FROM obaveze WHERE 1";

            //Ako je prikaz = null - učitavaju se sve, ako je true samo završene i ako je false samo ne završene
            //Upitu se dodaje odgovarajući uslov
            if (prikaz == true)
                sql += " AND zavrsena=true";
            else if (prikaz == false)
                sql += " AND zavrsena=false";


            MySqlCommand komanda = new MySqlCommand(sql, konekcija);
            MySqlDataReader reader = komanda.ExecuteReader();

            while (reader.Read())
            {
                //Svi podaci iz baze smještaju se u promjenljive radi lakšeg pozivanja na iste
                int id = Int32.Parse(reader["id"].ToString());
                string naziv = reader["naziv"].ToString();
                string opis = reader["opis"].ToString();
                bool zavrsena = (bool)reader["zavrsena"];

                //Kreira se novi objekat (kontrola) obaveza
                ucObaveza obaveza = new ucObaveza(id, naziv, opis, zavrsena, konekcija, spObaveza);
                //Nova kontrola se postavlja na stackPanel
                spObaveza.Children.Add(obaveza);
            }
            reader.Close();
        }

        //Filtriranje završenih obaveza
        private void btnZavrsene_Click(object sender, RoutedEventArgs e)
        {
            if (prikaz == true)//Ako su bile prikazane završene obaveze
                prikaz = null;//Promjeni trenutni prikaz na sve obaveze
            else//Inače je prikaz samo završenih pošto je u pitanju klik na btnZavrsene
                prikaz = true;
            ucitajObaveze();//Učitavaju se sve obaveze a filtriranje zavisi od novog stanja promjenljive prikaz
        }

        private void btnNeZavrsene_Click(object sender, RoutedEventArgs e)
        {
            if (prikaz == false)//Ako su bile prikazane nezavršene obaveze
                prikaz = null;//Promjeni trenutni prikaz na sve obaveze
            else//Inače je prikaz samo ne završenih pošto je u pitanju klik na btnNeZavrsene
                prikaz = false;
            ucitajObaveze();//Učitavaju se sve obaveze a filtriranje zavisi od novog stanja promjenljive prikaz
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            //Otvara se forma za dodavanje nove obaveze
            inputObaveza novaObaveza = new inputObaveza();
            novaObaveza.ShowDialog();

            //Ako je DialogResult= true (to jeste ako je korisnik kliknuo na snimi) izvršava se upit INSERT
            if (novaObaveza.DialogResult == true)
            {
                //Upit za INSERT u bazu. Vrijednosti se čitaju iz Propertija prozora inputObaveza
                string sql = "INSERT INTO obaveze (Naziv, Opis, Zavrsena) VALUES ('" + novaObaveza.nazivObaveze + "', '" + novaObaveza.opisObaveze + "', " + novaObaveza.statusObaveze + ")";
                MySqlCommand komanda = new MySqlCommand(sql, konekcija);
                //Izvršava se komanda
                komanda.ExecuteNonQuery();
                //Osvježava se prikaz obaveza u stackPanel-u
                ucitajObaveze();
            }
        }
    }
}
