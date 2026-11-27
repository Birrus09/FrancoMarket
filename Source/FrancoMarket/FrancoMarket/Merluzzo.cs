using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merluzzi
{
    public class Merluzzo
    {
        public string Nome;
        public float lunghezza;
        public float peso;
        public int numerator;

        public Merluzzo(string nome, float lunghezza, float peso, int n)
        {
            Nome = nome;
            this.lunghezza = lunghezza;
            this.peso = peso;
            numerator = n;
        }
        public void updateData(string nome, float lunghezza, float peso, int n)
        {
            Nome = nome;
            this.lunghezza = lunghezza;
            this.peso = peso;
            numerator = n;
        }
    }
}
