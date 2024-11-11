using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.clsKundeDatenzugriff;

namespace Data_Layer
{
    public class clsLizenzDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public struct stLizenz
        {
            public int LizenzID;
            public int kundeNummer;
            public string lizenzNummer;
            public DateTime ausstellungDatum;
            public DateTime ablaufDatum;
            public string lizenzFoto;
        }

        public static int AddNewLizenz(stLizenz lizenz)
        {
            int lizenzID = -1;

            string abfrage = @"Insert Into Lizenz(lizenzNummer,ausstellungsDatum, ablaufDatum, 
                                                                    lizenzFoto, kundeNummer)
                                   Values(@lizenzNummer,@ausstellungsDatum, @ablaufDatum, 
                                                                    @lizenzFoto, @kundeNummer);
	                                Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@lizenzNummer", lizenz.lizenzNummer);
                        command.Parameters.AddWithValue("@ausstellungsDatum", lizenz.ausstellungDatum);
                        command.Parameters.AddWithValue("@ablaufDatum", lizenz.ablaufDatum);

                        if (string.IsNullOrEmpty(lizenz.lizenzFoto))
                            command.Parameters.AddWithValue("@lizenzFoto", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@lizenzFoto", lizenz.lizenzFoto);

                        command.Parameters.AddWithValue("@kundeNummer", lizenz.kundeNummer);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            lizenzID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return lizenzID;
        }

        public static bool FindLizenzByKundeNummer(int kundeNummer, ref stLizenz lizenz)
        {

            bool isfound = false;
            string abfrage = @"select lizenzID, lizenzNummer,
                                      ausstellungsDatum, ablaufDatum, lizenzFoto, kundeNummer
                                   
                             from Lizenz 
		                     Where Lizenz.kundeNummer = @kundeNummer";

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

                                lizenz.lizenzNummer = (string)reader["lizenzNummer"];   
                                lizenz.ausstellungDatum = (DateTime)reader["ausstellungsDatum"];
                                lizenz.ablaufDatum = (DateTime)reader["ablaufDatum"];
                                lizenz.lizenzFoto = (string)reader["lizenzFoto"];
                                lizenz.kundeNummer = (int)reader["kundeNummer"];

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
