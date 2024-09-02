using System;
namespace Projeto2_5
{
    class Program
    {
        static void Main (string[] args)
        {
            Animal ani = new Animal ();
            Gato gato = new Gato ();

            //UPCASTING
            Animal ani1 = gato; //Se diz "o gato É UM animal"
            ani1.FazerSom ();

            Animal cachorro = new Cachorro ();
            cachorro.FazerSom ();

            Console.ReadLine ();
        }
    }
}