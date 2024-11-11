using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Layer
{
    public class clsReservierung
    {
        public enum enMode { addnew = 0, update = 1}
        private enMode _mode = enMode.addnew;

        public int reservierungNummer {  get; set; }
        public DateTime reservierungsDatum { get; set; }
        public int fahrzeugNummer { get; set; }
        public int kundeNummer { get; set; }

        private clsReservierung(int reservierungNummer, DateTime reservierungsDatum, 
            int fahrzeugNummer, int kundeNummer)
        {
            this.reservierungNummer = reservierungNummer;
            this.reservierungsDatum = reservierungsDatum;
            this.fahrzeugNummer = fahrzeugNummer;
            this.kundeNummer = kundeNummer;
            _mode = enMode.update;
        }

        public clsReservierung()
        {
            this.reservierungNummer = -1;
            this.reservierungsDatum = DateTime.Now;
            this.fahrzeugNummer = -1;
            this.kundeNummer = -1;

            _mode = enMode.addnew;
        }

        private bool _AddNew()
        {
            this.reservierungNummer = clsReservierungDatenzugriff.AddNewReservierung(this.reservierungsDatum,
                this.fahrzeugNummer, this.kundeNummer);

            return (this.reservierungNummer != -1);
        }

        public bool Save()
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_AddNew())
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
