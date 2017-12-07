namespace Calculadora.Domain
{
    public class Soma
    {
        public Soma(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int Numero1 { get; }
        public int Numero2 { get; }

        public int Resultado()
        {
            return Numero1 + Numero2;
        }
    }
}
