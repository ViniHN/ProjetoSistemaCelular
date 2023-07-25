using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelulares.Models
{
    abstract internal class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando ...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
