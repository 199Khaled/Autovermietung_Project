using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace clsHilfsMethoden
{
    public class clsDateiZumSpeichern
    { 
        
        private static string _GetDateiPfad()
        {
            string dateiPfad = string.Empty;
            try
            {
                string ordnerPfad = Directory.GetCurrentDirectory();
                dateiPfad = Path.Combine(ordnerPfad,"date.txt");

                if (!File.Exists(dateiPfad))
                {
                    using (File.Create(dateiPfad)) { } //um Filestream zu schließen
                    
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Fehler beim Erstellen oder Überprüfen des Datei-Pfads.", ex);
            }

            return dateiPfad;
        }
        public static bool SaveToFile(string email, string passwort, bool erinnerMich)
        {
            string dateiPfad = _GetDateiPfad();
            //als zeichenkette speichern
            string neuEintrag = $"{email}#//#{passwort}";

            try
            {
                
                if (erinnerMich)
                {
                    using (StreamWriter schreiber = new StreamWriter(dateiPfad))
                    {
                        schreiber.WriteLine(neuEintrag);
                    }
                    return true;
                }
                else
                {
                    if (email == "" && File.Exists(dateiPfad))
                    {
                        File.Delete(dateiPfad);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Erstellen oder Überprüfen des Datei-Pfads.", ex);
            }
            return false;
        }

        public static bool ReadFromFile(ref string email, ref string passwort)
        {
            string dateiPfad = _GetDateiPfad();

            try
            {
                if (!File.Exists(dateiPfad))
                {
                    return false;
                }

                using (StreamReader leser = new StreamReader(dateiPfad))
                {
                    string zeile = string.Empty;

                    while ((zeile = leser.ReadLine()) != null)
                    {
                        string[] result = zeile.Split(new string[] { "#//#" }, StringSplitOptions.None);

                        email = result[0];
                        passwort = result[1];
                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Laden der Datei.", ex);
            }
        }

            //public static List<(string email, string passwort)> ReadFromFile()
            //{
            //    string dateiPfad = _GetDateiPfad();

            //    var datenListe = new List<(string email, string passwort)>();

            //    try
            //    {
            //        if (File.Exists(dateiPfad))
            //        {
            //            var zeilen = File.ReadAllLines(dateiPfad);

            //            foreach (var zeile in zeilen)
            //            {
            //                string[] teile = zeile.Split(new string[] { "#//#" }, StringSplitOptions.None);

            //                if (teile.Length == 2)
            //                {
            //                    datenListe.Add((teile[0].Trim(), teile[1].Trim()));
            //                }
            //            }

            //        }
            //        else
            //            return null;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception("Fehler beim Laden der Datei.", ex);
            //    }

            //    return datenListe;
            //}

            //public static bool Einloggen(string Email, string Passwort)
            //{
            //    var datenListe = ReadFromFile();

            //    // Prüfen, ob es einen passenden Eintrag gibt
            //    return datenListe.Any(eintrag => eintrag.email == Email && eintrag.passwort == Passwort);

            //}


        }
}
