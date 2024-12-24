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
    public partial class Form4 : Form
    {
        // path baza de date
        private string db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:Users\David\Documents\tap.accdb;";

        // initializare form
        public Form4()
        {
            InitializeComponent();
            this.Text = "Camere ocupate";
            afiseazaCamere();
        }
        // buton de confirm
        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // initializarea camerelor ocupate default, fara criterii de cautare
        private void afiseazaCamere()
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "SELECT C.IdCamera, C.NrCamera, C.NrLocuri, C.Etaj, C.PretZi FROM Camere C INNER JOIN RezervariContinut RC ON C.IdCamera = RC.IdCamera;";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    this.dataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

        // metoda de check-out a clientului, cu toate datele calculate la final
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();

                    string selectQuery = "SELECT R.IdClient, Clienti.Nume, RC.PretZi, RC.DataCazarii " +
                                         "FROM ((RezervariContinut RC " +
                                         "INNER JOIN Rezervari R ON RC.IdRezervare = R.IdRezervare) " +
                                         "INNER JOIN Camere C ON C.IdCamera = RC.IdCamera) " +
                                         "INNER JOIN Clienti ON Clienti.IdClient = R.IdClient " +
                                         "WHERE RC.IdCamera = @IdCamera";
                    string insertQuery = "INSERT INTO RezervariComplete (Plata, NrZile, NumeClient, DataCheckIn) VALUES (@Plata, @NrZile, @NumeClient, @DataCheckIn)";
                    string deleteClientiQuery = "DELETE FROM Clienti WHERE IdClient = @IdClient";
                    string deleteRezervariQuery = "DELETE FROM Rezervari WHERE IdClient = @IdClient";
                    string deleteContinutQuery = "DELETE FROM RezervariContinut WHERE Nrc = @IdClient";

                    DataGridViewRow row = dataGridView1.CurrentRow;
                    if (row != null)
                    {
                        DialogResult dialog = MessageBox.Show("Esti sigur ca vrei sa faci check-out?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes && checkBox.Checked)
                        {
                            int idSelectat = Convert.ToInt32(row.Cells["IdCamera"].Value);

                            using (OleDbCommand cmd = new OleDbCommand(selectQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@IdCamera", idSelectat);
                                OleDbDataReader reader = cmd.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        try
                                        {
                                            int idClient = Convert.ToInt32(reader["IdClient"]);
                                            string numeClient = reader["Nume"].ToString();
                                            DateTime dataCheckIn = Convert.ToDateTime(reader["DataCazarii"]);
                                            decimal pretZi = Convert.ToDecimal(reader["PretZi"]);
                                            int nrZile = (DateTime.Now - dataCheckIn).Days;
                                            decimal pretRezervare = pretZi * (nrZile + 1);

                                            using (OleDbCommand insertcmd = new OleDbCommand(insertQuery, con))
                                            {
                                                insertcmd.Parameters.AddWithValue("@Plata", pretRezervare);
                                                insertcmd.Parameters.AddWithValue("@NrZile", nrZile);
                                                insertcmd.Parameters.AddWithValue("@NumeClient", numeClient);
                                                insertcmd.Parameters.AddWithValue("@DataCheckIn", dataCheckIn);

                                                insertcmd.ExecuteNonQuery();
                                            }

                                            using (OleDbCommand deletecmd = new OleDbCommand(deleteClientiQuery, con))
                                            {
                                                deletecmd.Parameters.AddWithValue("@IdClient", idClient);
                                                deletecmd.ExecuteNonQuery();
                                            }

                                            using (OleDbCommand deletecmd = new OleDbCommand(deleteRezervariQuery, con))
                                            {
                                                deletecmd.Parameters.AddWithValue("@IdClient", idClient);
                                                deletecmd.ExecuteNonQuery();
                                            }

                                            using (OleDbCommand deletecmd = new OleDbCommand(deleteContinutQuery, con))
                                            {
                                                deletecmd.Parameters.AddWithValue("@IdClient", idClient);
                                                deletecmd.ExecuteNonQuery();
                                            }

                                            DateTime dataCheckout = DateTime.Now;
                                            string message = $"Nume client: {numeClient}\n" +
                                                             $"Data check-in: {dataCheckIn}\n" +
                                                             $"Data check-out: {dataCheckout}\n" +
                                                             $"Suma de plata: €{pretRezervare.ToString("F2")}";

                                            MessageBox.Show(message, "Succes", MessageBoxButtons.OK);
                                        }
                                        catch (IndexOutOfRangeException ex)
                                        {
                                            MessageBox.Show($"Coloana IdClient nu a fost gasita: {ex}", "Eroare", MessageBoxButtons.OK);
                                        }

                                    }
                                    MessageBox.Show("Check-out-ul a fost realizat cu succes", "Succes", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else MessageBox.Show("Va rugam asigurati-va ca ati primit cheile inapoi.", "Eroare", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Nu exista un id selectat", "Eroare", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

        // functionalitate pentru stergerea unei rezervari
        private void stergeButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string deleteClientiQuery = "DELETE FROM Clienti WHERE IdClient = @IdClient";
                    string deleteRezervariQuery = "DELETE FROM Rezervari WHERE IdClient = @IdClient";
                    string deleteContinutQuery = "DELETE FROM RezervariContinut WHERE Nrc = @IdClient";
                    DataGridViewRow row = dataGridView1.CurrentRow;

                    int idSelectat = Convert.ToInt32(row.Cells["IdCamera"].Value);
                    if (row != null)
                    {
                        DialogResult dialog = MessageBox.Show("Esti sigur ca vrei sa stergi rezervarea?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            using (OleDbCommand cmd = new OleDbCommand(deleteClientiQuery, con))
                            {
                                cmd.Parameters.AddWithValue("IdClient", idSelectat);
                                cmd.ExecuteNonQuery();
                            }

                            using (OleDbCommand cmd = new OleDbCommand(deleteContinutQuery, con))
                            {
                                cmd.Parameters.AddWithValue("IdClient", idSelectat);
                                cmd.ExecuteNonQuery();
                            }

                            using (OleDbCommand cmd = new OleDbCommand(deleteRezervariQuery, con))
                            {
                                cmd.Parameters.AddWithValue("IdClient", idSelectat);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Rezervarea a fost stearsa cu succes.", "Eroare", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

        // functionalitate pentru butonul de cautare a camerelor ocupate
        private void searchButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "SELECT C.IdCamera, C.NrCamera, C.NrLocuri, C.Etaj, C.PretZi FROM Camere C INNER JOIN RezervariContinut RC ON C.IdCamera = RC.IdCamera WHERE 1+1";

                    if ((int)cameraBox.Value != 0)
                    {
                        query += " AND NrCamera = @NrCamera";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NrCamera", Convert.ToInt32(cameraBox.Value));

                        DataTable dataTable = new DataTable();
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare: {ex}", "Eroare", MessageBoxButtons.OK);
                }
            }
        }

        // functionalitate pentru butonul de detalii client
        private void detaliiButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(db))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Nume, NrTelefon FROM Clienti C INNER JOIN RezervariContinut RC ON C.IdClient = RC.Nrc WHERE RC.IdCamera = @IdCamera";

                    DataGridViewRow row = dataGridView1.CurrentRow;

                    if(row != null)
                    {
                        int cameraSelectata = (int)row.Cells["IdCamera"].Value;
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@IdCamera", (int) cameraSelectata);

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string nume = reader["Nume"].ToString();
                                    string NrTelefon = reader["NrTelefon"].ToString();

                                    string mesaj = $"Nume client: {nume}\n" +
                                                   $"Numar de telefon: {NrTelefon}";

                                    MessageBox.Show(mesaj, "Detalii client", MessageBoxButtons.OK);
                                }
                            }
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Nu exista camere ocupate.", "Invalid", MessageBoxButtons.OK);
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
    

