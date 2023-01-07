using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudioPsicologia
{
    class Medico : IComparable<Medico>
    {
        string nome;               // 20 + 1 byte
        string cognome;            // 20 + 1 byte
        string specializzazione;   // 20 + 1 byte
        bool inCarica;             // 1 byte
        int inizioOrario;          // 4 byte
        int fineOrario;            // 4 byte

        // 21 + 21 + 21 + 1 + 4 + 4  = 72 + codice 10 + 1

        public string _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        public string _specializzazione { get { return specializzazione; } set { specializzazione = value; } }
        public bool _inCarica { get { return inCarica; } set { inCarica = value; } }

        public int _inizioOrario { get { return inizioOrario; } set { inizioOrario = value; } }
        public int _fineOrario { get { return fineOrario; } set { fineOrario = value; } }


        public Medico(string nome, string cognome, string specializzazione, bool inCarica, int inizioOrario, int fineOrario)
        {
            this.nome = nome;
            this.cognome = cognome;

            this.specializzazione = specializzazione;
            this.inCarica = inCarica;

            this.inizioOrario = inizioOrario;
            this.fineOrario = fineOrario;
        }
        public Medico() : this("Medico", "Medico", "//", false, 0, 0) { }


        // to string medico
        public override string ToString()
        {
            return $"{nome} {cognome}";
        }


        // formatta stringa
        private string formattaStringa(string stringa)
        {
            if (stringa.Length > 20)
                stringa  = stringa.Substring(0, 20);
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


        // salva il medici nel file pazienti
        public void scriviMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);
            int posizione = Convert.ToInt32(fs.Position);

            scrivi.Write(formattaStringa(nome));
            scrivi.Write(formattaStringa(cognome));
            scrivi.Write(formattaStringa(specializzazione));
            scrivi.Write(inCarica);
            scrivi.Write(inizioOrario);
            scrivi.Write(fineOrario);

            scrivi.Write(getCodice());

            scriviArchivoMedici(posizione);

            fs.Close();
        }


        // funzione scrivi archivioMedici
        private void scriviArchivoMedici(int posizione)
        {
            FileStream fs = new FileStream("archivioMedici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);

            scrivi.Write(getCodice());
            scrivi.Write(posizione);

            fs.Close();
        }


        // crea codice medico
        private string codiceMedico()  // 10 caratteri
        {
            string codiceMedico =
                $"{nome.Substring(0, 1).ToUpper()}" +
                $"{cognome.Substring(0, 1).ToUpper()}" +
                $"{specializzazione.Substring(0, 3).ToUpper()}" +
                //$"{inCarica.ToString().Substring(0, 1).ToUpper()}" +
                $"0" +
                $"{formattaNumero(inizioOrario)}" +
                $"{formattaNumero(fineOrario)}";
            return codiceMedico;
        }
        public string getCodice()
        {
            return codiceMedico();
        }

        // mi restituisce la lunghezza del medico nel file binario
        public int getByte()
        {
            return 72 + 11;
        }

        // lunghezza codice
        public int lunghezzaCodice()
        {
            return 11;
        }

        // compareTo
        public int CompareTo(Medico other)
        {
            if (nome.CompareTo(other.nome) == 0)
                if (cognome.CompareTo(other.cognome) == 0)
                    return cognome.CompareTo(other.cognome);
            return nome.CompareTo(other.nome);
        }
    }
}
