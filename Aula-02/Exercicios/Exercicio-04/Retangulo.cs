namespace Exercicio4_2
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double CalculaArea ()
        {
            return largura * altura;
        }

        public double CalculaPerimetro ()
        {
            return 2 * (largura * altura);
        }

        public double CalculaDiagonal ()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }

    }

}