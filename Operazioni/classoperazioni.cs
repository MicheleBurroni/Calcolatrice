using System;

namespace Operazioni
{
    public class classoperazioni
    {
        public static double PRIMONUMERO()
        {
            Console.Write("inserisci il primo numero");
            double num1 = double.Parse(Console.ReadLine());
            return num1;
        }
        public static double SECONDONUMERO()
        {
            Console.Write("inserisci il secondo numero");
            double num2 = double.Parse(Console.ReadLine());
            return num2;
        }
        public static double SOMMA(double num1, double num2)
        {
            double somma = num1 + num2;
            return somma;


        }
        public static double SOTTRAZIONE(double num1, double num2)
        {
            double sottra = num1 + num2;
            return sottra;


        }
        public static double MOLTIPLICAZIONE(double num1, double num2)
        {
            double molt = num1 * num2;
            return molt;


        }
        public static double DIVISIONE(double num1, double num2)
        {
            double div = num1 / num2;
            return div;


        }

    }
}
