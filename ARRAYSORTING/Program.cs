using System;

namespace ARRAYSORTING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ARVIND = new int[10];
            ARVIND[0] = 021222;
            ARVIND[1] = 100111;
            ARVIND[2] = 20012;
            ARVIND[3] = 30021;
            ARVIND[4] = 4002;
            ARVIND[5] = 5254;
            ARVIND[6] = 664;
            ARVIND[7] = 716;
            ARVIND[8] = 8255;
            ARVIND[9] = 902;

            ///PRINTING ARRAYS VALUE//
            int I = 0;
            foreach (int K in ARVIND) 
            {
                Console.WriteLine("ARVIND["+I+"]: " + K);
                I++;
            }

           
            Console.WriteLine("==============================================");
            /// SORTIN ASCENDIN ORDER OF ARRAY//
            Array.Sort(ARVIND);
            foreach(int r in ARVIND)
            {
                Console.Write(r+" ");
                Console.WriteLine("=========================================================");
            }
            /// REVESING  ORDER OF ARRAY//
            Array.Reverse(ARVIND);
            foreach (int r in ARVIND)
            {
                Console.Write(r + " ");
                Console.WriteLine("=========================================================");
            }
            /// MINIMUM VALUE IN  ARRAY//
            int min = ARVIND[0];
            Console.WriteLine(min);

            Console.WriteLine("=========================================================");


            /// MAXIMUM VALUE IN  ARRAY//
            int max = ARVIND[ARVIND.Length - 1];
            Console.WriteLine(max);


            Console.WriteLine("=========================================================");

            /// SUM OF ELEMENT OF ARRAY//
            int sum = 0;
                foreach (int k in ARVIND)
            {
                sum = sum + k;
            }
            Console.WriteLine(sum);

            
            Console.WriteLine("=========================================================");

            /// COPY ARRAY FROM ONE TO ANOTHER ARRAY//
            int[] AJIT = new int[ARVIND.Length];
            
            for(int N = 0; N<ARVIND.Length; N++)
            {
                AJIT[N] = ARVIND[N];
                Console.WriteLine(AJIT[N]);

            }
            Console.WriteLine("=========================================================");


















        }
    }
}
