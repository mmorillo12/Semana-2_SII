using System;

namespace Personas
{
    class Persona{
        string nombre;
        public string Nombre { get{return nombre;} set{nombre = value;} }
        string[] lapersona = new string[3];

        public Persona(){
            for(int i = 0; i < 3;i++){
                Console.WriteLine("Ingrese un nombre: ");
                nombre = Console.ReadLine();
                lapersona[i] = nombre;
            }
        }
        public void Mostrar(){
            for(int i = 0; i < 3; i++){
            Console.WriteLine("\nEl nombre del apersona es {0}", lapersona[i]);
            }
        }
        ~Persona(){
            //limpiar
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Mostrar();
        }
    }
}
