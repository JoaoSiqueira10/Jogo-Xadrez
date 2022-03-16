

namespace Calcula
{
    class Calculator
    {
        //solucao usando sobrecarga
        //inviavel pois fica dependente de ter uma funcao de sobrecarga com um determinado numero de parametros
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        //solucao com vetor
        public static int Som(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //solucao com modificador params
        public static int Soma(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //solucao sem modificador
        public static void Triple(int x)
        {
            x = x * 3;
        }

        //solucao com modificador ref
        public static void Triplo(ref int y)
        {
            y = y * 3;
        }

        //solucao com modificador out
        public static void Tri(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
