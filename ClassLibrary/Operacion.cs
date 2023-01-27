namespace ClassLibrary
{
    public class Operacion
    {
        public int SumarNumeros(int n, int m)
        {
            return n + m;
        }

        public bool IsValorPar(int numero)
        {
            return numero % 2 == 0;
        }

        public double SumarDecimal(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }
    }
}