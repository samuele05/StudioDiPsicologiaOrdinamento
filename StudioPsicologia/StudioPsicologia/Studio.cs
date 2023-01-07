using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPsicologia
{
    class Studio
    {
        List<Appuntamento> appuntamenti;
        int orarioApertura;
        int orarioChiusura;

        public List<Appuntamento> _appuntamenti { get { return appuntamenti; } set { appuntamenti = value; } }
        public int _orarioApertura { get { return orarioApertura; } set { orarioApertura = value; } }
        public int _orarioChiusura { get { return orarioChiusura; } set { orarioChiusura = value; } }

        public Studio(List<Appuntamento> appuntamenti, int orarioApertura, int orarioChiusura)
        {
            this.appuntamenti = appuntamenti;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }
        public Studio(int orarioApertura, int orarioChiusura)
        {
            this.appuntamenti = new List<Appuntamento>();
        }
        public Studio() : this (new List<Appuntamento>(), 0, 23) { }


        // funzione aggiungi appuntamento
        public void aggiungiAppuntamento(Appuntamento appuntamento)
        {
            appuntamenti.Add(appuntamento);
        }

        public void rimuoviAppuntamento()
        {
            // non richiesto
        }




    }
}
