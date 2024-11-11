using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsFahrzeugDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public struct stFahrzeug
        {
            public int fahrzeugNummer;
            public string bezeichnung;
            public string kennzeichen;
            public float preisProTag;
            public string typ;
            public bool ausgeliehen;
            public bool reserviert;
        }

        public static DataTable GetAllVerfügbareFahrzeuge()
        {
            DataTable dt = new DataTable();
            string abfrage = @"select bezeichnung, kennzeichen, typ, preisProTag from Fahrzeug
                                  Where Fahrzeug.ausgeliehen = 0 And Fahrzeug.reserviert = 0";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return dt;
        }

        public static DataTable GetAllFahrzeugType()
        {
            DataTable dt = new DataTable();

            string abfrage = @"select distinct typ from Fahrzeug
                                  Where 
                                    Fahrzeug.ausgeliehen = 0 And Fahrzeug.reserviert = 0";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return dt;
        }


        public static DataTable GetFahrzeugDatenByType(string typ)
        {
            DataTable dt = new DataTable();
            string abfrage = @"select * from Fahrzeug
                                  Where typ = @typ And
                                    Fahrzeug.ausgeliehen = 0 And Fahrzeug.reserviert = 0";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@typ", typ);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                //fahrzeug.fahrzeugNummer = (int)reader["fahrzeugNummer"];
                                //fahrzeug.bezeichnung = (string)reader["bezeichnung"];
                                //fahrzeug.kennzeichen = (string)reader["kennzeichen"];
                                //fahrzeug.preisProTag = (float)reader["preisProTag"];
                                //fahrzeug.ausgeliehen = (bool)reader["ausgeliehen"];
                                //fahrzeug.reserviert = (bool)reader["reserviert"];
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return dt;
        }

        public static float GetPreisProTagByBezeichnungAndTyp(string bezeichnung, string Typ)
        {
            float preisProTag = 0;
            string abfrage = @"select preisProTag From Fahrzeug 
                                    Where bezeichnung = @bezeichnung And typ = @typ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@bezeichnung", bezeichnung);
                        command.Parameters.AddWithValue("@typ", Typ);


                        connection.Open();
                        preisProTag = Convert.ToSingle(command.ExecuteNonQuery());
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return preisProTag;
        }

        public static bool GetFahrzeugDatenByBezeichnungAndTyp(ref stFahrzeug fahrzeug)
        {
            bool isfound = false;
            string abfrage = @"select * From Fahrzeug
                                Where bezeichnung = @bezeichnung And typ = @typ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@bezeichnung", fahrzeug.bezeichnung);
                        command.Parameters.AddWithValue("@typ", fahrzeug.typ);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                isfound = true;

                                fahrzeug.fahrzeugNummer = (int)reader["fahrzeugNummer"];
                                fahrzeug.bezeichnung = (string)reader["bezeichnung"];
                                fahrzeug.kennzeichen = (string)reader["kennzeichen"];
                                fahrzeug.preisProTag = (float)reader["preisProTag"];
                                fahrzeug.typ = (string)reader["typ"];
                                fahrzeug.ausgeliehen = (bool)reader["ausgeliehen"];
                                fahrzeug.reserviert = (bool)reader["reserviert"];
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

        public static bool SetzeFahrzeugAlsReserviert(int fahrzeugNummer)
        {
            int rowsAffected = 0;
            string abfrage = @"UPDATE Fahrzeug SET reserviert = 1 
                                   WHERE fahrzeugNummer = @fahrzeugNummer";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@fahrzeugNummer", fahrzeugNummer);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                    return false;
                }
            }
            return rowsAffected > 0;
        }
    }
}
