using System;

namespace Banco
{
    class CLiente{
        private string nombre;
        private int monto;
        private int deposito;
        public CLiente(string nom){
            nombre = nom;
            monto = 0;
        }
        public void Depositar(int dep){
            deposito = dep;
            monto += dep;
        }
        public void Extraer(int dep){
            deposito = dep;
            monto -= dep;
        }
        public int RetornarMonto(){
            return monto;
        }
        public int Retornardeposito(){
            return deposito;
        }
        public void Mostrar(){
            Console.WriteLine("{0} tiene un monto de {1}", nombre, monto);
        } 
    }
    class Bancos{
        CLiente cliente1;
        CLiente cliente2;
        CLiente cliente3;
public Bancos(){
        cliente1 = new CLiente("Katiuska");
        cliente2 = new CLiente("Yuderkis");
        cliente3 = new CLiente("Joel");
        }
    
    public void AsignarDep(int dep, int depo, int deposi){
        cliente1.Depositar(dep);
        cliente2.Depositar(depo);
        cliente3.Depositar(deposi);
    }
    public void Asignar_Ext(int ex, int ext, int extr){
        cliente1.Extraer(ex);
        cliente2.Extraer(ext);
        cliente3.Extraer(extr);
    }

    public void MostrarTodo(){
        Console.WriteLine("El cliente 1 deposito {0}", cliente1.RetornarMonto());
        Console.WriteLine("El cliente 2 deposito {0}", cliente2.RetornarMonto());
        Console.WriteLine("El cliente 3 deposito {0} \n", cliente3.RetornarMonto());
        Console.WriteLine("El cliente 1 extrajo {0}", cliente1.Retornardeposito());        
        Console.WriteLine("El cliente 2 extrajo {0}", cliente2.Retornardeposito());        
        Console.WriteLine("El cliente 3 extrajo {0}\n", cliente3.Retornardeposito());




    }
    public void Extracciones_total(){
     int exttotal = cliente1.Retornardeposito() + cliente2.Retornardeposito() + cliente3.Retornardeposito();
     Console.WriteLine("El total de extracciones es de {0}", exttotal);
    }
    public void Deposito_total(){
     int deptotal = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
     Console.WriteLine("El total de depositos es de {0}", deptotal);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Bancos b = new Bancos();
            b.AsignarDep(200,400,1000);
            b.Asignar_Ext(100,20,50);
            b.MostrarTodo();
            b.Extracciones_total();
            b.Deposito_total();
        }
    }
}
