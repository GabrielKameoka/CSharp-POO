namespace Projeto2_5
{
    class Animal
    {
        public virtual void FazerSom ()
        {
            Console.WriteLine ("Fazendo um som genérico");
        }
    }

    class Cachorro : Animal
    {
        public override void FazerSom ()
        {
            Console.WriteLine ("Au au!");
        }
    }

    class Gato : Animal
    {
        public override void FazerSom ()
        {
            Console.WriteLine ("Miau!");

        }
    }
}