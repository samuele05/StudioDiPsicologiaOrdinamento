using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPsicologia
{
    class Appuntamento : IComparable<Appuntamento>
    {
        Medico medico;
        Paziente paziente;
        string data;
        string argomento;
        int orario;
        bool concluso;

        public Medico _medico { get { return medico; } set { medico = value; } }
        public Paziente _paziente { get { return paziente; } set { paziente = value; } }
        public string _data { get { return data; } set { data = value; } }
        public string _argomento { get { return argomento; } set { argomento = value; } }
        public int _orario { get { return orario; } set { orario = value; } }
        public bool _concluso { get { return concluso; } set { concluso = value; } }


        public Appuntamento(Medico medico, Paziente paziente, string data, string argomento, int orario, bool concluso)
        {
            this.medico = medico;
            this.paziente = paziente;
            this.data = data;
            this.argomento = argomento;
            this.orario = orario;
            this.concluso = concluso;
        }

        public Appuntamento() : this(new Medico(), new Paziente(), "", "", 0, false) { }


        // funzione scrivi appuntamento
        public void scriviAppuntemento()
        {
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);

            scrivi.Write(medico.getCodice());             // 10 + 1
            scrivi.Write(paziente.getCodice());           // 27 + 1
            scrivi.Write(data);                           // 10 + 1
            scrivi.Write(formattaStringa(argomento));     // 20 + 1
            scrivi.Write(orario);                         // 4
            scrivi.Write(concluso);                       // 1 
            scrivi.Write(codiceAppuntamento());           // 50 + 1

            fs.Close();
        }


        // funzione scrivi app
        public void scriviApp(BinaryWriter scrivi)
        {
            scrivi.Write(medico.getCodice());        
            scrivi.Write(paziente.getCodice());       
            scrivi.Write(data);                        
            scrivi.Write(formattaStringa(argomento));    
            scrivi.Write(orario);              
            scrivi.Write(concluso);           
            scrivi.Write(codiceAppuntamento());
        }


        // codice appuntameto (utile per la eliminare e modificare appuntamenti)  50 caratteri
        public string codiceAppuntamento()
        {
            string codiceAppuntamento =
                $"{medico.getCodice()}" +                             // 10
                $"{paziente.getCodice()}" +                           // 27
                $"{data}" +                                           // 10
                $"{formattaNumero(orario)}" +                         // 2
                $"{concluso.ToString().Substring(0, 1).ToUpper()}";   // 1

            return codiceAppuntamento;
        }



        // formatta stringa
        private string formattaStringa(string stringa)
        {
            if (stringa.Length > 20)
                stringa = stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa = stringa.PadRight(20);
            return stringa;
        }

        // formatta numero
        private string formattaNumero(int numero)
        {
            if (numero < 10)
                return $"{0}{numero}";
            return numero.ToString();
        }


        // mi restituisce la lunghezza dell'appuntamento nel file binario
        public int getByte()
        {
            return 127;
        }


        // lunghezza codice
        public int lunghezzaCodice()
        {
            return 51;
        }

        // compareTo  (raggruppamento per medico e paziente)
        public int CompareTo(Appuntamento other)
        {
            if (medico.CompareTo(other.medico) == 0)
                if (paziente.CompareTo(other.paziente) == 0)
                    return paziente.CompareTo(other.paziente);
            return medico.CompareTo(other.medico);
        }
    }
}


