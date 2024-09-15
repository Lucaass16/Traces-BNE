namespace TracesEx1
{
    public class Traces
    {
        public static void Trace1()
        {
            
            int a, b, c;
            a = 10;
            b = 20;
            c = ((a + b) / 2);
            c -= 40;

            int[] v = new int[6];

            for (int i = 0; i < 6; i++)
            {
                if (i == 3) 
                {
                    v[i] = a+b+c;
                }

                Console.WriteLine($"v[{i}] = {v[i]}");

                if (v[i] == 5) 
                {
                    Console.WriteLine($"VERDADEIRO: v[{i}] é igual a 5");
                }
                else 
                {
                    Console.WriteLine($"FALSO: v[{i}] é diferente de 5");
                }

                Console.WriteLine("----------");


            }
        }

        public static void Trace2()
        {
            
            int a = 2;

            int[] v = new int[7];

            while (a<6)
            {
                v[a] = a*10;
                a++;
            }

            Console.WriteLine("Valores de v: ");
            Console.Write("{ ");
            foreach (var value in v)
            {
                Console.Write($"{value} ");
            }
            Console.Write("}");
        }

        public static void Trace3()
        {
            int a, b;
            a = 7;
            b = a-6;

            int[] v = new int[a];

            while (b<a)
            {
                if (b < v.Length) 
                {
                    v[b] = b+a;
                }
                
                b += 2;

                if (b >= v.Length) 
                {
                    break;
                }
            }

            Console.WriteLine("Valores Inseridos: ");
            Console.Write("{ ");
            foreach (var value in v)
            {
                Console.Write($"{value} ");
            }
            Console.Write("}");
        }
    }
}