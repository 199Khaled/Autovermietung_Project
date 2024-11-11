using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using static Data_Layer.clsPersonDatenzugriff;

namespace Data_Layer
{
    public class clsKundeDatenzugriff
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

        public struct stKunde
        {
            public int kundeNummer;
            public int personID;
            public DateTime kundeSeit;
            public bool istAktive;
        }
        public static int AddNewKunde(stKunde kunde)
        {
            int kundeNummer = -1;

            string abfrage = @"Insert Into Kunde(personID, kundenSeit, istAktive)
                              Values(@personID, @kundeSeit,@istAktive);
	                                Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@personID", kunde.personID);
                        command.Parameters.AddWithValue("@kundeSeit", kunde.kundeSeit);
                        command.Parameters.AddWithValue("@istAktive", kunde.istAktive);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if(result!= null)
                        {
                            kundeNummer = Convert.ToInt32(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return kundeNummer;
        }

        public static bool FindKundeByKundeNummer(int kundeNummer, ref stPerson person, ref stKunde kunde)
        {

            bool isfound = false;
            string abfrage = @"select name, vorname, geburtsDatum, geschlecht, 
                                      strasse, postleitzahl, ort, kundenSeit, istAktive
                                   
                             from Kunde Inner join Person ON
                                             Kunde.personID = Person.personID
		                     Where Kunde.kundeNummer = @kundeNummer";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@kundeNummer", kundeNummer);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                person.PersonID = (int)reader["personID"];
                                person.Name = (string)reader["name"];
                                person.Vorname = (string)reader["vorname"];
                                person.GeburtsDatum = (DateTime)reader["geburtsDatum"];
                                person.Geschlecht = (byte)reader["geschlecht"];
                                person.Straße = (string)reader["strasse"];
                                person.Postleitzahl = (string)reader["postleitzahl"];
                                person.Ort = (string)reader["ort"];

                                kunde.kundeSeit = (DateTime)reader["kundeSeit"];
                                kunde.istAktive = (bool)reader["istAktive"];

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

        public static bool GetKundeByEmailAndPasswort(string email, string passwort,
            ref stPerson person, ref stKunde kunde)
        {

            bool isfound = false;
            string abfrage = @"Select * From  Kunde Inner Join Person ON
                                                        Kunde.personID = Person.personID 
                                                    Inner Join Kontakt ON
					                                      Person.personID = Kontakt.personID
			                      Where Kontakt.email = @email And Kontakt.passwort = @passwort";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        string verschlüsseltesPasswort = clsVerschlüsselungHelfer.Encrypt(passwort);
                        command.Parameters.AddWithValue("@passwort", verschlüsseltesPasswort);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                person.PersonID = (int)reader["personID"];
                                person.Name = (string)reader["name"];
                                person.Vorname = (string)reader["vorname"];
                                person.GeburtsDatum = (DateTime)reader["geburtsDatum"];
                                person.Geschlecht = (byte)reader["geschlecht"];
                                person.Straße = (string)reader["strasse"];
                                person.Postleitzahl = (string)reader["postleitzahl"];
                                person.Ort = (string)reader["ort"];

                                kunde.kundeNummer = (int)reader["kundeNummer"];
                                kunde.kundeSeit = (DateTime)reader["kundeSeit"];
                                kunde.istAktive = (bool)reader["istAktive"];
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
