  using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;

namespace Shifrovanie_Cezar
{
    class Program
    {
        static void Main()
        {
            #region SHIFR 

            int k = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            string alfphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string s1 = "";
            int m = alfphabet.Length;
            s = s.ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (s[i] == alfphabet[j])
                    {
                        s1 += alfphabet[(Math.Abs((j + k) * m) + j + k) % m];
                        break;
                    }
                }
            }

            Console.WriteLine(s1);
            Console.ReadLine();
            #endregion

            #region MASSIVE
            //Random rand = new Random();

            // int[,] MyArray = new int[5, 5];

            int[,] MyArray = { { -50, 3, 5 }, { -80, 10, 15 }, { 4, 55, 78 } };

                Console.WriteLine("Это наш стартовый массив: ");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // MyArray[i, j] = rand.Next(-100, 101);
                        Console.Write(MyArray[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                IEnumerable<int> ConvertedArray = MyArray.Cast<int>();

                int MinValue = ConvertedArray.Min();

                int MaxValue = ConvertedArray.Max();

                Console.WriteLine("Минимальное значение массива: " + MinValue);

                Console.WriteLine("Максимальное значение массива : " + MaxValue);

                int IndexRMin = 0, IndexCMin = 0, IndexRMax = 0, IndexCMax = 0, Sum = 0;
                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (MyArray[i, j] == MinValue)
                        {
                            IndexRMin = i;
                            IndexCMin = j;
                        }
                        if (MyArray[i, j] == MaxValue)
                        {
                            IndexRMax = i;
                            IndexCMax = j;
                        }
                    }
                }

                Console.WriteLine("Позиция минимального значения: " + IndexRMin + IndexCMin);

                Console.WriteLine("Позиция максималього значения: " + IndexRMax + IndexCMax);

                
                for (int i = IndexRMin; i < IndexRMax; i++)
                {
                    for (int j = IndexCMin; j < IndexCMax; j++)
                    {
                        if (MyArray[i, j] == MyArray[IndexRMin, IndexCMin])
                        {
                            j++;
                        }
                        Sum += MyArray[i, j];
                    }
                }

                Console.WriteLine("Сумма = : " + Sum);
            #endregion 

        }
    }
}
    

