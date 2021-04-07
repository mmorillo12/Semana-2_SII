using System;

namespace Punto
{
    class Punto{
        double X;
        double Y;

        public Punto(){}
        public Punto(int X, int Y){
            this.X = X;
            this.Y = Y;
        }
        public Punto(int X){
            this.X = X;
            this.Y = 0;
        }
        public void agregarpuntos(){
            double X = 0, Y = 0;
            Console.WriteLine("Ingrese la cantidad de puntos");
            int cantidad = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidad; i++){
                Console.WriteLine("\nEscriba un numero para el punto X");
                X = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba un numero para el punto Y");
                Y = double.Parse(Console.ReadLine());
                Console.WriteLine("({0},{1})", X, Y);
                Cuadrante(X, Y);
                vector(X, Y);
            }
        }
        public void Mostrar(){
            Console.WriteLine("({0},{1})", X, Y);
        }
        public void Cuadrante(double X, double Y){
            if(X == 0 && Y != 0){
                Console.WriteLine("\nEl punto se situa sobre el eje Y");
            }
            else if(X != 0 && Y == 0){
                Console.WriteLine("El punto se situa sobre el eje X");
            }
            else{
                Console.WriteLine("El punto se situa sobre el origen");
            }
        }
        public void vector(double X, double Y){
            double numx = 0, numy = 0;
            Console.WriteLine("\nEncontremos el vector");
            for(int i = 0; i < 1; i++){
                Console.WriteLine("\nEscriba un numero para el punto X");
                numx = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba un numero para el punto Y");
                numy = double.Parse(Console.ReadLine());
                if(numy == ' '){
                    Y = 0;
                }
            } 
            double nx = numx - X;
            double ny = numy - Y;
                Console.WriteLine("\nEl vector de las dos coordenadas es ({0}, {1})\n",nx,ny);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punto p = new Punto(30);
            p.agregarpuntos();
        }
    }
}
