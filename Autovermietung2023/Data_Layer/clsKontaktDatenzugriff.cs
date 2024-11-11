using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.clsKontaktDatenzugriff;
using static Data_Layer.clsPersonDatenzugriff;

namespace Data_Layer
{
    public class clsKontaktDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public struct stKontakt
        {
            public int kotaktID;
            public int personID;
            public string email;
            public string passwort;
            public string telefon1;
            public string telefon2;
        }
        public static int AddNewKontakt(int personID, string email, string passwort, string telefon1, string  telefon2)
        {
            int kontaktID = -1;

            string abfrage = @"Insert Into Kontakt(personID, email, passwort, telefon1, telefon2)
                                             Values(@personID, @email, @passwort, @telefon1, @telefon2);
	                                Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@personID", personID);
                        command.Parameters.AddWithValue("@email", email);

                        //hier wird das passwort verschlüsselt.
                        string verschlüsseltesPasswort = clsVerschlüsselungHelfer.Encrypt(passwort);
                        
                        command.Parameters.AddWithValue("@passwort", verschlüsseltesPasswort);

                        if (string.IsNullOrEmpty(telefon1))
                            command.Parameters.AddWithValue("@telefon1", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@telefon1", telefon1);

                        if (string.IsNullOrEmpty(telefon2))
                            command.Parameters.AddWithValue("@telefon2", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@telefon2", telefon2);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                           kontaktID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return kontaktID;
        }

        public static bool FindKontaktByPersonID(int PersonID, ref stKontakt kontakt)
        {

            bool isfound = false;
            string abfrage = @"Select * from Kontakt 
                                          Where Kontakt.PersonID = @personID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@personID", PersonID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                kontakt.personID = (int)reader["personID"];
                                kontakt.kotaktID = (int)reader["kontaktID"];
                                kontakt.email = (string)reader["email"];

                                string entschlüsseltesPasswort = clsVerschlüsselungHelfer.Decrypt((string)reader["passwort"]);
                                kontakt.passwort = entschlüsseltesPasswort;

                                kontakt.telefon1 = (string)reader["telefon1"];
                                kontakt.telefon2 = (string)reader["telefon2"];
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    isfound = false;
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }
            return isfound;
        }

        public static bool GetKontaktByEmailAndPasswort(ref stKontakt kontakt)
        {
            bool isfound = false;
            string abfrage = @"Select * from Kontakt
                         where Kontakt.email = @email and Kontakt.passwort = @passwort";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@email", kontakt.email);

                        string verschlüsseltePasswort = clsVerschlüsselungHelfer.Encrypt(kontakt.passwort);
                        command.Parameters.AddWithValue("@passwort", verschlüsseltePasswort);


                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                kontakt.personID = (int)reader["personID"];
                                kontakt.kotaktID = (int)reader["kontaktID"];

                                if (reader["telefon1"] == DBNull.Value)
                                    kontakt.telefon1 = DBNull.Value.ToString();
                                else
                                    kontakt.telefon1 = (string)reader["telefon1"];

                                if (reader["telefon2"] == DBNull.Value)
                                    kontakt.telefon1 = DBNull.Value.ToString();
                                else
                                    kontakt.telefon1 = (string)reader["telefon2"];
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    isfound = false;
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }
            return isfound;
        }
    }
}
