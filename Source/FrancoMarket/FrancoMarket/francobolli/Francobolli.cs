using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Permanenza1
{
    class Francobollo
    {
        public int valore;
        public string nome;
        public string valuta;
        public int id;

        public Francobollo(int valore = 0, string nome = "aaa", string valuta = "euro")
        {
            this.valore = valore;
            this.nome = nome;
            this.valuta = valuta;
        }
    }
    class Collezione {
        public List<Francobollo> Francobolli;
        public List<int> posseduti;

        public Collezione()
        {
            this.Francobolli = new List<Francobollo>();
            this.posseduti = new List<int>();
        }

        public void salva(string percorso)
        {
            List<string> righe = new List<string>();

            foreach (Francobollo francobollo in Francobolli)
            {
                righe.Add(
                    $"{francobollo.nome}|{francobollo.valore.ToString(CultureInfo.InvariantCulture)}|{francobollo.valuta}|");
            }

            File.WriteAllLines(percorso, righe);
        }

        public void carica(string percorso)
        {
            List<Francobollo> francobolliCaricati = new List<Francobollo>();

            foreach (string riga in File.ReadAllLines(percorso))
            {
                if (string.IsNullOrWhiteSpace(riga))
                {
                    continue;
                }

                string[] dati = riga.Split('|');
                if (dati.Length < 4 ||
                    !int.TryParse(dati[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out int valore))
                {
                    throw new FormatException("Il file contiene una riga non valida.");
                }

                francobolliCaricati.Add(new Francobollo(valore, dati[0], dati[2]));
            }

            Francobolli.Clear();
            Francobolli.AddRange(francobolliCaricati);
        }
    
    }

}
