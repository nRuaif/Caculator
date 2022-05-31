using System;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int answer = 0;
            char[] mark = {'+', '-', '*', '/' };  
            var listOfStrings = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                if (input[i] == mark[j])
                {
                        listOfStrings.Add(input[i]);
                }
            }


            char[] arrayOfStrings = listOfStrings.ToArray();
            Console.WriteLine(arrayOfStrings[0]);
            string[] raw = input.Split(mark);

            int[] number = Array.ConvertAll(raw, s => int.Parse(s));
            Console.WriteLine(number[0]);
            answer = 0;
            int answer2 = 0;
            bool check = false;
            var Nnumber = new List<int>();
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (arrayOfStrings[i] == '*')
                {
                    Console.WriteLine("the number is " + number[i] * number[i + 1]);
                    int answer1 = number[i] * number[i + 1];
                    Nnumber.Add(answer1);
                }
                if (arrayOfStrings[i] == '/')
                { Nnumber.Add(number[i] / number[i + 1]);
                    number[i] = 0;
                }
                
            }
            for (int j = 0; j <= arrayOfStrings.Length ; j++)
            {
                if (arrayOfStrings.Length == 1)
                {
                    if (arrayOfStrings[0] == '+')
                    {
                        Nnumber.Add(number[0]);
                        Nnumber.Add(number[1]);
                    }
                    else if (arrayOfStrings[0] == '-')
                    {
                        Nnumber.Add(number[0]);
                        Nnumber.Add(number[1] * -1);
                    }
                }
                else
                {
                    if (arrayOfStrings.Length > 1 && j < arrayOfStrings.Length - 1)
                    {
                        if (arrayOfStrings[j] == '+' && arrayOfStrings[j + 1] != '*' && arrayOfStrings[j + 1] != '/')
                        {
                            Nnumber.Add(number[j + 1]);
                        }
                        if (arrayOfStrings[j] == '-' && arrayOfStrings[j + 1] != '*' && arrayOfStrings[j + 1] != '/')
                        {
                            Nnumber.Add(number[j + 1] * -1);
                        }

                    }

                    if (j == arrayOfStrings.Length - 1 && j > 0)

                    {
                        if (arrayOfStrings[j] == '+')
                        {
                            Nnumber.Add(number[j + 1]);
                            Console.WriteLine("Check");
                        }
                        if (arrayOfStrings[j] == '-')
                        {
                            Nnumber.Add(number[j + 1] * -1);
                            Console.WriteLine("Check");
                        }
                    }
                    if (j == 0 && arrayOfStrings.Length > 1)
                    {
                        if (arrayOfStrings[0] != '*' && arrayOfStrings[0] != '/' )
                        {
                            Nnumber.Add(number[0]);
                        }
                    }
                }

        }


                answer = 0;
                int[] numberv2 = Nnumber.ToArray();
                for (int i = 0; i < numberv2.Length; i++)
                {
                    Console.WriteLine("debug" + numberv2[i]);
                    answer += numberv2[i];
                }


                Console.WriteLine(answer);
            
        }
    }
}
//Trung Anh yeu Trang, Trung Anh yeu Trang rat nhieu
