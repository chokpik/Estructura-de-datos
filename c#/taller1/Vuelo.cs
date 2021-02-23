using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace taller1
{
    class Vuelos
    {
        string codigo;
        string trayecto;
        string origen;
        string destino;
        string horapartida;
        string horallegada;
        double valor;

        public string Codigo {get; set; }
        public string Trayecto {get; set; }
        public string Origen {get; set; }
        public string Destino {get; set; }
        public string Horapartida {get; set; }
        public string Horallegada {get; set; }
        public double Valor {get; set; }

        public Vuelos()
        { }

        public Vuelos(string codigo, string trayecto, string origen, string destino, string horapartida, string horallegada, double valor)
        {
            this.codigo = codigo;
            this.trayecto = trayecto;
            this.origen = origen;
            this.destino = destino;
            this.horapartida = horapartida;
            this.horallegada = horallegada;
            this.valor = valor;
        }

        public void Guardar(List<Vuelos> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\vuelo.json";
            File.WriteAllText(path, json);
        }




    }
}