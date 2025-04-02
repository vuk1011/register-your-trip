using Domen;
using Microsoft.Data.SqlClient;

namespace BrokerBazePodataka
{
    public class BrokerBazePodataka
    {
        private string connStringBPStanovnistvo = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stanovnistvo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string connStringBPPrijavaPutovanja = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Sistem za prijavu putovanja"";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private SqlConnection? connection;

        public void ConnectBPStanovnistvo()
        {
            try
            {
                connection = new SqlConnection(connStringBPStanovnistvo);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void ConnectBPPrijavaPutovanja()
        {
            try
            {
                connection = new SqlConnection(connStringBPPrijavaPutovanja);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Disconnect()
        {
            connection?.Close();
        }

        public bool PostojiStanovnik(Stanovnik s)
        {
            try
            {
                string query = "SELECT * FROM Stanovnik WHERE jmbg = @jmbg AND brojPasosa = @brojPasosa AND ime = @ime AND prezime = @prezime";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@jmbg", s.Jmbg);
                cmd.Parameters.AddWithValue("@brojPasosa", s.BrojPasosa);
                cmd.Parameters.AddWithValue("@ime", s.Ime);
                cmd.Parameters.AddWithValue("@prezime", s.Prezime);
                using SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public bool PostojiStanovnikSaJmbgIBrojPasosa(Stanovnik s)
        {
            try
            {
                string query = "SELECT * FROM Stanovnik WHERE jmbg = @jmbg AND brojPasosa = @brojPasosa";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@jmbg", s.Jmbg);
                cmd.Parameters.AddWithValue("@brojPasosa", s.BrojPasosa);
                using SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<DrzavaEU> VratiDrzavaEU()
        {
            List<DrzavaEU> drzaveEU = new List<DrzavaEU>();
            try
            {
                string query = "SELECT * FROM DrzavaEU";
                using SqlCommand cmd = new SqlCommand(query, connection);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DrzavaEU d = new DrzavaEU
                    {
                        Naziv = reader.GetString(0),
                        Kod = reader.GetString(1)
                    };
                    drzaveEU.Add(d);
                }
                return drzaveEU;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public bool PostojiKorisnikSaUsername(string username)
        {
            try
            {
                string query = "SELECT * FROM Korisnik WHERE username = @username";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                using SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public bool PostojiKorisnikZaStanovnika(Stanovnik stanovnik)
        {
            try
            {
                string query = "SELECT * FROM Korisnik WHERE ime = @ime AND prezime = @prezime AND jmbg = @jmbg AND brojPasosa = @brojPasosa";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ime", stanovnik.Ime);
                cmd.Parameters.AddWithValue("@prezime", stanovnik.Prezime);
                cmd.Parameters.AddWithValue("@jmbg", stanovnik.Jmbg);
                cmd.Parameters.AddWithValue("@brojPasosa", stanovnik.BrojPasosa);
                using SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Korisnik PrijaviKorisnika(Korisnik k)
        {
            try
            {
                string query = "SELECT * FROM Korisnik WHERE username = @username AND password = @password";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", k.Username);
                cmd.Parameters.AddWithValue("@password", k.Password);
                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    k.Email = reader.GetString(2);
                    k.Jmbg = reader.GetString(3);
                    k.BrojPasosa = reader.GetString(4);
                    k.Ime = reader.GetString(5);
                    k.Prezime = reader.GetString(6);
                    return k;
                }
                else
                {
                    throw new Exception("Лоши креденцијали.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void DodajKorisnika(Korisnik k)
        {
            try
            {
                string query = "INSERT INTO Korisnik VALUES (@username, @password, @email, @jmbg, @brojPasosa, @ime, @prezime)";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", k.Username);
                cmd.Parameters.AddWithValue("@password", k.Password);
                cmd.Parameters.AddWithValue("@email", k.Email);
                cmd.Parameters.AddWithValue("@jmbg", k.Jmbg);
                cmd.Parameters.AddWithValue("@brojPasosa", k.BrojPasosa);
                cmd.Parameters.AddWithValue("@ime", k.Ime);
                cmd.Parameters.AddWithValue("@prezime", k.Prezime);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<Prijava> VratiPrijave(string jmbg)
        {
            List<Prijava> prijave = new List<Prijava>();

            try
            {
                string query = "SELECT * FROM Prijava p JOIN PrijavaDrzavaEU pd ON p.id = pd.prijava JOIN DrzavaEU d ON pd.drzavaEU = d.naziv WHERE jmbg = @jmbg";
                using SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@jmbg", jmbg);
                using SqlDataReader reader = cmd.ExecuteReader();

                long prethodniId = -1;
                Prijava prijava = new Prijava();
                DrzavaEU drzava = new DrzavaEU();

                while (reader.Read())
                {
                    long id = (long)reader["id"];
                    if (id == prethodniId)
                    {
                        prijava.Drzave.Add(new DrzavaEU
                        {
                            Naziv = (string)reader["naziv"],
                            Kod = (string)reader["kod"],
                        });
                        continue;
                    }
                    if (prethodniId != -1)
                    {
                        prijave.Add(prijava);
                    }
                    prijava = new Prijava
                    {
                        Id = id,
                        Ime = (string)reader["ime"],
                        Prezime = (string)reader["prezime"],
                        Jmbg = (string)reader["jmbg"],
                        BrojPasosa = (string)reader["brojPasosa"],
                        DatumUlaska = DateOnly.FromDateTime((DateTime)reader["datumUlaska"]),
                        DatumIzlaska = DateOnly.FromDateTime((DateTime)reader["datumIzlaska"]),
                        NacinPrevoza = (NacinPrevoza)Enum.Parse(typeof(NacinPrevoza), (string)reader["nacinPrevoza"]),
                        TrebaPlatiti = (bool)reader["trebaPlatiti"],
                        Drzave = new List<DrzavaEU>(),
                    };
                    prijava.Drzave.Add(new DrzavaEU
                    {
                        Naziv = (string)reader["naziv"],
                        Kod = (string)reader["kod"],
                    });
                    prethodniId = id;
                }
                prijave.Add(prijava);
                return prijave;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void DodajPrijavu(Prijava p)
        {
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // INSERT u tabelu Prijava
                string query1 = "INSERT INTO Prijava output inserted.Id VALUES (@ime, @prezime, @jmbg, @brojPasosa, @datumUlaska, @datumIzlaska, @nacinPrevoza, @trebaPlatiti)";
                using SqlCommand cmd1 = new SqlCommand(query1, connection, transaction);
                cmd1.Parameters.AddWithValue("@ime", p.Ime);
                cmd1.Parameters.AddWithValue("@prezime", p.Prezime);
                cmd1.Parameters.AddWithValue("@jmbg", p.Jmbg);
                cmd1.Parameters.AddWithValue("@brojPasosa", p.BrojPasosa);
                cmd1.Parameters.AddWithValue("@datumUlaska", p.DatumUlaska);
                cmd1.Parameters.AddWithValue("@datumIzlaska", p.DatumIzlaska);
                cmd1.Parameters.AddWithValue("@nacinPrevoza", p.NacinPrevoza.ToString());
                cmd1.Parameters.AddWithValue("@trebaPlatiti", p.TrebaPlatiti);
                p.Id = (long)cmd1.ExecuteScalar();

                // INSERT u tabelu PrijavaDrzavaEU
                string query2 = "INSERT INTO PrijavaDrzavaEU VALUES (@prijava, @drzavaEU)";
                foreach (var d in p.Drzave)
                {
                    using SqlCommand cmd2 = new SqlCommand(query2, connection, transaction);
                    cmd2.Parameters.AddWithValue("@prijava", p.Id);
                    cmd2.Parameters.AddWithValue("@drzavaEU", d.Naziv);
                    cmd2.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void IzmeniPrijavu(Prijava p)
        {
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // UPDATE tabele Prijava
                string query1 = "UPDATE Prijava SET datumUlaska = @datumUlaska, datumIzlaska = @datumIzlaska, nacinPrevoza = @nacinPrevoza WHERE id = @id";
                using SqlCommand cmd1 = new SqlCommand(query1, connection, transaction);
                cmd1.Parameters.AddWithValue("@datumUlaska", p.DatumUlaska);
                cmd1.Parameters.AddWithValue("@datumIzlaska", p.DatumIzlaska);
                cmd1.Parameters.AddWithValue("@nacinPrevoza", p.NacinPrevoza.ToString());
                cmd1.Parameters.AddWithValue("@id", p.Id);
                cmd1.ExecuteNonQuery();

                // DELETE u tabeli PrijavaDrzavaEU
                string query2 = "DELETE FROM PrijavaDrzavaEU WHERE prijava = @id";
                using SqlCommand cmd2 = new SqlCommand(query2, connection, transaction);
                cmd2.Parameters.AddWithValue("@id", p.Id);
                cmd2.ExecuteNonQuery();

                // INSERT u tabelu PrijavaDrzavaEU
                string query3 = "INSERT INTO PrijavaDrzavaEU VALUES (@prijava, @drzavaEU)";
                foreach (var d in p.Drzave)
                {
                    using SqlCommand cmd3 = new SqlCommand(query3, connection, transaction);
                    cmd3.Parameters.AddWithValue("@prijava", p.Id);
                    cmd3.Parameters.AddWithValue("@drzavaEU", d.Naziv);
                    cmd3.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void ObrisiPrijavu(Prijava p)
        {
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // DELETE u tabeli Prijava
                string query1 = "DELETE FROM Prijava WHERE id = @id";
                using SqlCommand cmd1 = new SqlCommand(query1, connection, transaction);
                cmd1.Parameters.AddWithValue("@id", p.Id);
                cmd1.ExecuteNonQuery();

                // DELETE u tabeli PrijavaDrzavaEU
                string query2 = "DELETE FROM PrijavaDrzavaEU WHERE prijava = @id";
                using SqlCommand cmd2 = new SqlCommand(query2, connection, transaction);
                cmd2.Parameters.AddWithValue("@id", p.Id);
                cmd2.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
