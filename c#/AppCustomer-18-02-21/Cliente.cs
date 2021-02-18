using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AppCustomer_18_02_21
{
    class Clientes
    {
        string nombre;
        string email;
        int edad;
        string ciudad;

        public string Nombre
        {
            get{return nombre; } 
            set{nombre = value; } 
        }

        public string Email
        {
            get{return email;}
            set{email = value;}
        }

        public int Edad
        {
            get{return edad;}
            set{edad = value;}

        }
        public string Ciudad
        {
            get{return ciudad;}
            set{ciudad = value;}
        }

        public Clientes()
        { }

        public Clientes(string nombre, string email, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
            this.ciudad = ciudad;
        }
        
        ///<summary>
        ///Permite visualizar los clientes
        ///</summary>


        public void ListarClientes(List<Clientes> miLista)
        {
            foreach (Clientes cliente in miLista)
            {
                Console.WriteLine("Nombre: {0}",cliente.Nombre);
                Console.WriteLine("email: {0}",cliente.Email);
                Console.WriteLine("Ciudad: {0}",cliente.Ciudad);
                Console.WriteLine("Edad: {0}",cliente.Edad);
                
            }
        }

        public void BuscarClientexCiudad(List<Clientes> miLista, string ciudad)
        {
            IEnumerable<Clientes> clientQuery =
            from cliente in miLista
            where cliente.Ciudad.Contains(ciudad)
            select cliente;

            foreach (Clientes cliente in clientQuery)
            {
                Console.WriteLine("Nombre: {0}",cliente.Nombre);
                Console.WriteLine("email: {0}",cliente.Email);
                Console.WriteLine("Ciudad: {0}",cliente.Ciudad);
                Console.WriteLine("Edad: {0}",cliente.Edad);
                
            }
            
        }

    }
}