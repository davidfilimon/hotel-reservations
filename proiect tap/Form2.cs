using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_tap
{
    public partial class Form2 : Form
    {
        // path baza de date
        private string db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:Users\David\Documents\tap.accdb;";

        // initializare form
        public Form2()
        {
            InitializeComponent();
            if(dataGridViewCamere.Rows.Count > 0)
            {
                this.dataGridViewCamere.Rows[0].Selected = true;
            }
            this.FormClosing += new FormClosingEventHandler(CloseApplication);
            this.Text = "Camere disponibile";
            this.dataGridViewCamere.SelectionChanged += new System.EventHandler(afiseazaPoza);
        }

        // incarcarea tuturor camerelor care nu sunt ocupate
        private void Form2_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdCamera, NrCamera, NrLocuri, Etaj, PretZi FROM Camere WHERE IdCamera NOT IN (SELECT IdCamera FROM RezervariContinut);"; // afisare camere
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    this.dataGridViewCamere.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex.Message}");
                }
            }
        }

        // oprirea aplicatiei total
        private void CloseApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // butonul de inchiriaza si intializarea paginii de inregistrare a clientului
        private void inchiriazaButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewCamere.CurrentRow;
            Form3 form3 = new Form3(row);
            form3.Show();
        }

        // deschiderea paginii cu camerele ocupate
        private void ocupateButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        // buton refresh
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        // metoda de afisare a pozei in picturebox
        private void afiseazaPoza(object sender, EventArgs e)
        {
            if(dataGridViewCamere.SelectedRows.Count > 0) // validator
            {
                int idSelectat = Convert.ToInt32(dataGridViewCamere.SelectedRows[0].Cells["IdCamera"].Value);
                
                incarcaImagine(idSelectat);
            }
        }

        // cautarea imaginii in baza de date pentru a o afisa
        private void incarcaImagine(int idSelectat)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "Select SpImagine FROM Camere WHERE IdCamera = @Id;"; // preluare cale imagine
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", idSelectat);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value) // validator
                    {
                        string calePoza = result.ToString();
                        cameraBox.Image = Image.FromFile(calePoza);
                    }
                    else
                    {
                        MessageBox.Show("Nu exista o cale catre imagine", "Invalid", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

        // buton de cautare pentru camere in functie de etaj / nr locuri
        private void searchButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdCamera, NrCamera, NrLocuri, Etaj, PretZi FROM Camere WHERE IdCamera NOT IN (SELECT IdCamera FROM RezervariContinut)"; // preluarea datelor

                    if ((int)etajBox.Value != 0) // validator search
                    {
                        query += " AND Etaj = @Etaj"; 
                    }

                    if ((int)numarLocuriBox.Value != 0) // validator search
                    {
                        query += " AND NrLocuri = @NrLocuri"; 
                    }

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Etaj", Convert.ToInt32(etajBox.Value));
                        cmd.Parameters.AddWithValue("@NrLocuri", Convert.ToInt32(numarLocuriBox.Value));

                        DataTable dataTable = new DataTable();
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        dataGridViewCamere.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }
    }
}
