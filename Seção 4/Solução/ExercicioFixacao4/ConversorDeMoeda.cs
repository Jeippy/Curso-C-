namespace ExercicioFixacao4
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6;
        public static double Converter(double cotacao, double dolares)
        {
            return dolares * cotacao * (1 + IOF/100.0);
        }
    }
}
