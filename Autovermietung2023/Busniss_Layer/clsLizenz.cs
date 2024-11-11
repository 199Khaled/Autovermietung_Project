using Data_Layer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Layer
{
    public class clsLizenz
    {
        public enum enmode { addnew =0, update = 1}
        private enmode _mode = enmode.addnew;
        public int lizenzID { get; set; }
        public string lizenzNummer { get; set; }
        public DateTime ausstellungsDatum { get; set; }
        public DateTime ablaufDatum { get; set; }
        public string lizenzFoto { get; set; }
        public int kundeNummer { get; set; }

        private clsLizenz(int lizenzID, string lizenzNummer, DateTime ausstellungsDatum, 
            DateTime ablaufDatum, string lizenzFoto, int kundeNummer)
        {
            this.lizenzID = lizenzID;
            this.lizenzNummer = lizenzNummer;
            this.ausstellungsDatum = ausstellungsDatum;
            this.ablaufDatum = ablaufDatum;
            this.lizenzFoto = lizenzFoto;

            _mode = enmode.update;
        }
        public clsLizenz()
        {
            this.lizenzID = -1;
            this.lizenzNummer = string.Empty;
            this.ausstellungsDatum = DateTime.Now;
            this.ablaufDatum = DateTime.Now;
            this.lizenzFoto = string.Empty;
        }

        public static  clsLizenz FindLizenzByKundeNummer(int kundeNummer)
        {
            clsLizenzDatenzugriff.stLizenz lizenz = new clsLizenzDatenzugriff.stLizenz();

            bool isfound = clsLizenzDatenzugriff.FindLizenzByKundeNummer(kundeNummer, ref lizenz);

            if (isfound)
            {
                return new clsLizenz(lizenz.LizenzID, lizenz.lizenzNummer, lizenz.ausstellungDatum,
                    lizenz.ablaufDatum, lizenz.lizenzFoto, kundeNummer);
            }
            else
                return null;
        }
        private bool _AddNew(int kundeNummer)
        {
            this.kundeNummer = kundeNummer;

            clsLizenzDatenzugriff.stLizenz lizenz = new clsLizenzDatenzugriff.stLizenz()
            {
                lizenzNummer = this.lizenzNummer,
                ausstellungDatum = this.ausstellungsDatum,
                ablaufDatum = this.ablaufDatum,
                lizenzFoto = this.lizenzFoto,
                kundeNummer = this.kundeNummer
            };

            this.lizenzID = clsLizenzDatenzugriff.AddNewLizenz(lizenz);
            return (this.lizenzID != -1);
        }

        public bool Save(int kundeNummer)
        {
            switch(_mode)
            {
                case enmode.addnew:
                    if (_AddNew(kundeNummer))
                    {
                        _mode = enmode.update;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }
    }
}
