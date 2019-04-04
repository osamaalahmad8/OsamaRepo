using System;

namespace StatistikApp
{
    public partial class Customer
    {
        private int _ID;
        private string _VorName;
        private string _NachName;
        private string _HausNr;
        private string _Straße;
        private int _PLZ;
        private string _Ort;
        private string _Tele;
        private int _Jahr;
        private int _Monat;
        private string  _BundesLand;
        private string _BerichtsEinheit;
        private int _AnzahlBetten;
        private int _Anreisen;
        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The Kennung muss eine positive zahl sein..");
                }
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }
        public string VorName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("VorName darf nicht leer sein");
                }
                this._VorName = value;
            }
            get
            {
                return this._VorName.ToString();
            }
        }
        public string NachName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("NachName darf nicht leer sein");
                }
                this._NachName = value;
            }
            get
            {
                return this._NachName.ToString();
            }
        }
        public string Hausnr
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Hause nummer darf nicht leer sein");
                }
                this._HausNr = value;
            }
            get
            {
                return this._HausNr.ToString();
            }
        }
        public string Straße
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Straße darf nicht leer sein");
                }
                this._Straße = value;
            }
            get
            {
                return this._Straße.ToString();
            }
        }
        public int PLZ
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The PLZ muss eine positive zahl sein..");
                }
                this._PLZ = value;
            }
            get
            {
                return this._ID;
            }
        }
        public string Ort
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ort darf nicht leer sein");
                }
                this._Ort = value;
            }
            get
            {
                return this._Ort.ToString();
            }
        }
        public string Tele
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Telefon darf nicht leer sein");
                }
                this._Tele = value;
            }
            get
            {
                return this._Tele.ToString();
            }
        }
        public int Jahr
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The Jahr muss eine positive zahl sein.");
                }

                this._Jahr = value;
            }
            get
            {
                return this._Jahr;
            }
        }
        public int Monat
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The Monat muss eine positive zahl sein.");
                }
                this._Monat = value;
            }
            get
            {
                return this._Monat;
            }
        }
        public string  BundesLand
        {
            set
            {
              this._BundesLand = value;
            }
            get
            {
                return this._BundesLand.ToString ();
            }
        }
        public string BerichtsEinheit
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("BerichtsEinheit darf nicht leer sein");
                }
                this._BerichtsEinheit = value;
            }
            get
            {
                return this._BerichtsEinheit.ToString();
            }
        }
        public int AnzahlBetten
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Die zahl muss eine positive zahl sein.");
                }
                this._AnzahlBetten = value;
            }
            get
            {
                return this._AnzahlBetten;
            }
        }
        public int Anreisen
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Die zahl muss eine positive zahl sein.");
                }
                this._Anreisen = value;
            }
            get
            {
                return this._Anreisen;
            }
        }
         public override string ToString() => _ID + "    " + _VorName +"    "+ _NachName +"    "+ _Straße  + "   " +_HausNr  + "    " + _PLZ + "    " + _Ort  + "    " + _Tele  +"    "+ _Jahr  +"    "+ _Monat   + "    " +_BundesLand   + "    " +_BerichtsEinheit + "    " + _AnzahlBetten  + "    " + _Anreisen;
    }
}
