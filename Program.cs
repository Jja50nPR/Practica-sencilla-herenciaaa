using System;

namespace PracticandoPildorasInformaticas
{
    class Practicando
    {
        static void Main(string[] args)
        {
            LlamandoObjetos();
      
        }

        public static void LlamandoObjetos()
        {
            LlamandoVehiculo();
            LlamandoAutomovil();
            LlamandoAvion();

        }

        public static void LlamandoVehiculo()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Vehiculo");
            Vehiculo vehiculo = new Vehiculo();
            Vehiculo.ArrancarMotor();
            vehiculo.Conducir();
            Vehiculo.PararMotor();
            Console.WriteLine("***********************************");
        }

        public static void LlamandoAvion()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Avion");
            Avion.ArrancarMotor();
            Avion avion = new Avion();
            avion.Conducir();
            Avion.PararMotor();
            Console.WriteLine("***********************************");
        }
        
        public static void LlamandoAutomovil()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Automovil");
            Automovil.ArrancarMotor();
            Automovil automovil = new Automovil();
            automovil.Conducir();
            Automovil.PararMotor();
            Console.WriteLine("***********************************");
        }
    }

    class Vehiculo
    {
        public static void ArrancarMotor()
        {
            Console.WriteLine("El motor ha sido arrancado");
        }

        public static void PararMotor()
        {
            Console.WriteLine("El motor ha sido parado");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("El vehiculo esta siendo conducido");
        }
    }

    class Automovil : Vehiculo
    {

        public override void Conducir()
        {
            Console.WriteLine("El automovil esta siendo conducido");    
        }

    }

    class Avion : Vehiculo
    {

        public override void Conducir()
        {
            Console.WriteLine("El avión esta siendo conducido");    
        }


    }
}
