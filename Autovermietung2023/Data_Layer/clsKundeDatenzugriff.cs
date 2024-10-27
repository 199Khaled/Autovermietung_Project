using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.clsPersonDatenzugriff;

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
            public string lizenzNummer;
            public DateTime ausstellungDatum;
            public DateTime ablaufDatum;
            public string lizenzFoto;
            public bool istAktive;
        }
        public static int AddNewKunde(stKunde kunde)
        {
            int kundeNummer = -1;

            string abfrage = @"Insert Into Kunde(personID, kundenSeit, lizenzNummer,
                                      ausstellungsDatum, ablaufDatum, lizenzFoto, istAktive)
                              Values(@personID, @kundeSeit,@lizenzNummer,
                                      @ausstellungsDatum, @ablaufDatum, @lizenzFoto, @istAktive);
	                                Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@personID", kunde.personID);
                        command.Parameters.AddWithValue("@kundeSeit", kunde.kundeSeit);
                        command.Parameters.AddWithValue("@lizenzNummer", kunde.lizenzNummer);
                        command.Parameters.AddWithValue("@ausstellungsDatum", kunde.ausstellungDatum);
                        command.Parameters.AddWithValue("@ablaufDatum", kunde.ablaufDatum);
                        command.Parameters.AddWithValue("@lizenzFoto", kunde.lizenzFoto);
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
                                      strasse, postleitzahl, ort, kundenSeit,lizenzNummer,
                                      ausstellungsDatum, ablaufDatum, lizenzFoto, istAktive
                                   
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
                                kunde.lizenzNummer = (string)reader["lizenzNummer"];
                                kunde.ausstellungDatum = (DateTime)reader["ausstellungsDatum"];
                                kunde.ablaufDatum = (DateTime)reader["ablaufDatum"];
                                kunde.lizenzFoto = (string)reader["lizenzFoto"];
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
