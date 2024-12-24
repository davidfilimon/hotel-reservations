using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_tap
{
    public partial class Form3 : Form
    {
        private string db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:Users\David\Documents\tap.accdb;";
        private static DataGridViewRow randCurent;
        public Form3(DataGridViewRow randSelectat)
        {
            randCurent = randSelectat;
            InitializeComponent();
            this.Text = "Inregistrare rezervare";

        }

        // procesul de salvare ale informatiilor ale clientului
        private void salveazaInformatii()
        {
                int idClient = detaliiClient();
                if (idClient != -1) // validator
                { 
                    var (idCamera, nrCamera, nrLocuri, etaj, pretZi) = alegeCamera();
                    dataCazarii(idClient, nrCamera, pretZi);
                    MessageBox.Show("Datele au fost salvate cu succes!", "Succes", MessageBoxButtons.OK);
                }           
        }

        // buton confirmare
        private void confirmButton_Click(object sender, EventArgs e)
        {
            salveazaInformatii();
            this.Hide();
        }

        // tuplu pentru alegerea camerei selectate in datagridview
        private (int idCamera, int nrCamera, string nrLocuri, string etaj, decimal pretZi) alegeCamera()
        {
            if(randCurent != null)
            {
                int idCamera = (int) randCurent.Cells["IdCamera"].Value;
                int nrCamera = (int) randCurent.Cells["NrCamera"].Value;
                string nrLocuri = randCurent.Cells["NrLocuri"].Value?.ToString() ?? "N/A";
                string etaj = randCurent.Cells["Etaj"].Value?.ToString() ?? "N/A";
                string pret = randCurent.Cells["PretZi"].Value?.ToString() ?? "-1";
                decimal pretZi;
                if(!decimal.TryParse(pret, out pretZi))
                {
                    MessageBox.Show("Valorea pentru PretZi nu este valida.", "Eroare", MessageBoxButtons.OK);
                }

                return (idCamera, nrCamera, nrLocuri, etaj, pretZi);
            }
            return (-1, -1, "N/A", "N/A", -1);

        }

        // detaliile clientului preluate din formular si introducerea in baza de date
        private int detaliiClient()
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                con.Open();
                string nume = numeBox.Text.Trim();
                string prenume = prenumeBox.Text.Trim();
                string numarTelefon = numarBox.Text.Trim();
                DateTime data = dataBox.Value;
                if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(prenume)) // validator
                {
                     MessageBox.Show("Va rugam completati toate spatiile.", "Invalid", MessageBoxButtons.OK);
                     return -1;
                }

                if(!System.Text.RegularExpressions.Regex.IsMatch(numarTelefon, @"\d{10}$")) // validator
                {
                    MessageBox.Show("Numarul de telefon trebuie sa contina exact 10 cifre");
                    return -1;
                }

                if(zileBox.Value < 1) // validator
                {
                    MessageBox.Show("Numarul de zile trebuie sa fie mai mare decat 0");
                    return -1;
                }
                
                string query = "INSERT INTO Clienti (Nume, NrTelefon) VALUES (@Nume, @NrTelefon)"; // inserarea datelor
                string numarTelefonValid = "+4" + numarTelefon;
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nume", $"{nume} {prenume}");
                    cmd.Parameters.AddWithValue("@NrTelefon", $"{numarTelefonValid}");
                    cmd.ExecuteNonQuery();
                }

                string idClientQuery = "SELECT MAX(IdClient) FROM Clienti"; // preluarea ultimului id al clientului introdus
                using (OleDbCommand cmd = new OleDbCommand(idClientQuery, con))
                {
                    object result = cmd.ExecuteScalar();
                    return (int) result;                    
                }
            }               
        }
     
        // realizarea rezervarii
        private void dataCazarii(int idClient, int idCamera, decimal pretZi)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                con.Open();
                string data = dataBox.Value.ToString("yyyy-MM-dd");
                int nrZile = (int) zileBox.Value;
                string query = "INSERT INTO RezervariContinut (Nrc, IdCamera, DataCazarii, PretZi, NrZile) VALUES (@NrClient, @IdCamera, @DataCazarii, @PretZi, @NrZile)"; // stocarea in baza de date
                if (nrZile > 0)
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NrClient", idClient);
                        cmd.Parameters.AddWithValue("@IdCamera", idCamera);
                        cmd.Parameters.AddWithValue("@DataCazarii", data);
                        cmd.Parameters.AddWithValue("@PretZi", pretZi);
                        cmd.Parameters.AddWithValue("@NrZile", nrZile);

                        cmd.ExecuteNonQuery();
                    }

                    string query2 = "INSERT INTO Rezervari (DataRezervarii, IdClient) VALUES (@DataRezervare, @IdClient)"; // stocarea in baza de date
                    using (OleDbCommand cmd = new OleDbCommand(query2, con))
                    {
                        cmd.Parameters.AddWithValue("@DataRezervare", data);
                        cmd.Parameters.AddWithValue("@IdClient", idClient);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Numarul de zile trebuie sa fie mai mult de 0.", "Eroare", MessageBoxButtons.OK);
                    return;
                }

            }
        }

    }
}
