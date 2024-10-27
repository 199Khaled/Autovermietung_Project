using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data_Layer
{
    public class clsPersonDatenzugriff
    {

        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public struct stPerson
        {
            public int PersonID;
            public string Name;
            public string Vorname;
            public DateTime GeburtsDatum;
            public byte Geschlecht;
            public string Straße;
            public string Postleitzahl;
            public string Ort;
        }
        public static int AddnewPerson(stPerson person)
        {
            int personID = -1;

            string abfrage = @"Insert Into Person(name, vorname,geburtsDatum,geschlecht, strasse,
                                                 postleitzahl, ort)
		                                 Values (@name, @vorname, @geburtsDatum, @geschlecht, @strasse,
		                                        @postleitzahl, @ort);
                         	Select SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@vorname", person.Vorname);
                        command.Parameters.AddWithValue("@geburtsDatum", person.GeburtsDatum);
                        command.Parameters.AddWithValue("@geschlecht", person.Geschlecht);
                        command.Parameters.AddWithValue("@strasse", person.Straße);
                        command.Parameters.AddWithValue("@postleitzahl", person.Postleitzahl);
                        command.Parameters.AddWithValue("@ort", person.Ort);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                            personID = InsertedID;
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return personID;
        }

        public static DataTable GetAllPersonen()
        {
            DataTable dtPerson = new DataTable();

            string abfrage = @"Select * From Person";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dtPerson.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }
            return dtPerson;
        }

        public static bool FindPersonByID(int personID, ref stPerson person)
        {
            bool isfound = false;
            string abfrage = @"Select * From Person Where personID = @personID";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@personID", personID);
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isfound = true;

                                person.Name = (string)reader["name"];
                                person.Vorname = (string)reader["vorname"];
                                person.GeburtsDatum = (DateTime)reader["geburtsDatum"];
                                person.Geschlecht = (byte)reader["geschlecht"];
                                person.Straße = (string)reader["strasse"];
                                person.Postleitzahl = (string)reader["postleitzahl"];
                                person.Ort = (string)reader["ort"];
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
