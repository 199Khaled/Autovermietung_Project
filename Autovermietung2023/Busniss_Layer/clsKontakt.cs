using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Layer
{
    public class clsKontakt
    {
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;

        public int kontakID { get; set; }
        public int personID { get; set; }
        public clsPerson personInfos
        {
            get; set;
        }
        public string email { get; set; }
        public string  passwort { get; set; }  
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        
        private clsKontakt(int kontaktID, int personID, string email, string passwort, string telefon1, string telefon2)
        {
            this.kontakID = kontaktID;
            this.personID = personID;
            this.email = email;
            this.passwort = passwort;
            this.telefon1 = telefon1;
            this.telefon2 = telefon2;
            _mode = enMode.update;
        }

        public clsKontakt()
        {
            this.kontakID = -1;
            this.personID = -1;
            this.email = string.Empty;
            this.passwort = string.Empty;
            this.telefon1 = string.Empty;
            this.telefon2 = string.Empty;
        }

        public static clsKontakt FindKontaktByPersonID(int personID)
        {
            clsKontaktDatenzugriff.stKontakt kontakt = new clsKontaktDatenzugriff.stKontakt();

            bool isfound = clsKontaktDatenzugriff.FindKontaktByPersonID(personID, ref kontakt);
            if (isfound)
            {
                return new clsKontakt(kontakt.kotaktID, personID, kontakt.email, kontakt.passwort,
                                             kontakt.telefon1, kontakt.telefon2);
            }
            else
                return null;
        }
        private bool _Addnew(int personID)
        {
            this.kontakID = clsKontaktDatenzugriff.AddNewKontakt(personID, this.email, this.passwort, this.telefon1, this.telefon2);
            return (this.kontakID != -1);
        }

        public bool Save(int personID)
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_Addnew(personID))
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }
    }
}
