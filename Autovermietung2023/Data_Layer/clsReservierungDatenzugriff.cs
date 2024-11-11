using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsReservierungDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static int AddNewReservierung(DateTime reservierungsDatum, int fahrzeugNummer, int kundeNummer)
        {
            int reservierungNummer = -1;

            string abfrage = @"Insert Into Reservierung (reservierungsDatum, fahrzeugNummer, kundeNummer)
                                        Values (@reservierungsDatum, @fahrzeugNummer, @kundeNummer);
                               Select Scope_Identity()";

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand(abfrage ,connection))
                    {
                        command.Parameters.AddWithValue("@reservierungsDatum", reservierungsDatum);
                        command.Parameters.AddWithValue("@fahrzeugNummer", fahrzeugNummer);
                        command.Parameters.AddWithValue("@kundeNummer", kundeNummer);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if(result != null)
                              reservierungNummer = Convert.ToInt32(result);
                    }
                }
                catch (SqlException ex)
                {
                    // Fange SQL-bezogene Fehler ab
                    Console.WriteLine("SQL-Fehler: " + ex.Message);
                }
            }

            return reservierungNummer;
        }
    }
}
