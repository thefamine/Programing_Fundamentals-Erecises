using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); //it works
            string input = Console.ReadLine();
            //int[] tempArray = new int[array.Length];

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                if (command[0] == "exchange") // it works
                {
                    //int delimer = int.Parse(command[1].ToString()); //тук не ти трябва ToString!?
                    int delimer = int.Parse(command[1]);
                    if (delimer < 0 || delimer > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = Exchange(array, delimer);
                    }
                }
                else if (command[0] == "max")
                {
                    string evenOrOdd = command[1].ToString();
                    if (evenOrOdd == "even")
                    {
                        int maxIndex = MaxEvenIndex(array, command);//това го вадя от иф проверката

                        if (maxIndex != -1) // 
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else //ако върне -1 като резултат влизаме в елса
                        {
                            Console.WriteLine("No matches");
                        }
                    }      // ДО ТУК ДОБРЕ
                    else if (evenOrOdd == "odd")
                    {
                        int maxIndex = MaxOddIndex(array, command);
                        if (maxIndex != -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command[0] == "min")
                {
                    string evenOrOddMin = command[1]; //it works
                    if (evenOrOddMin == "even")
                    {
                        int minIndex = MinEvenIndex(array, command);

                        if (minIndex != -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (evenOrOddMin == "odd")
                    {
                        int minIndex = MinOddIndex(array, command);

                        if (minIndex != -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                } // ДО ТУК РАБОТИ
                else if (command[0] == "first")
                {
                    int counter = int.Parse(command[1].ToString());
                    if (counter > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            if (IsEvenInArray(array) == false)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                FirstEvenElements(array, counter);
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (IsOddInArray(array) == false)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                FirstOddElements(array, counter);
                            }
                        }
                    }
                }
                else if (command[0] == "last")
                {
                    int counter = int.Parse(command[1].ToString());
                    if (counter > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (command[2] == "even")
                        {
                            if (IsEvenInArray(array) == false)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                LastEvenElements(array, counter);
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (IsOddInArray(array) == false)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                LastOddElements(array, counter);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static int[] Exchange(int[] array, int delimer)
        {
            array = array.Skip(delimer + 1).Concat(array.Take(delimer + 1)).ToArray();
            return array;
        }
        static bool IsEvenInArray(int[] array)
        {
            bool isEvenInArray = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    isEvenInArray = true;
                }
            }
            return isEvenInArray;
        }
        static bool IsOddInArray(int[] array)
        {
            bool isOddInArray = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    isOddInArray = true;
                }
            }
            return isOddInArray;
        }
        static int MaxEvenIndex(int[] array, string[] command)
        {

            int maxEvenNumber = int.MinValue;
            int maxEvenNumberIndex = -1; // ако търсим индекси никога не сетваме променлива на "0", защото нула е валиден индекс

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    //if (array[i] > maxEvenNumber) If there are two or more equal min/max elements, return the index of the rightmost one
                    if (array[i] >= maxEvenNumber)
                    {
                        maxEvenNumber = array[i]; //тук търсим максималният елемент
                        //if (i > maxEvenNumberIndex)
                        //{
                        //    maxEvenNumberIndex = i; // това цялото е излишно
                        //}
                    }
                }

            }
            return maxEvenNumberIndex = array.ToList().LastIndexOf(maxEvenNumber); ; // връщаме индекса на максималният елемент + използваме ToList за да можем да извикаме функцията LastIndexOf
        }
        static int MaxOddIndex(int[] array, string[] command)
        {
            int maxOddNumber = int.MinValue;
            int maxNumberIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    //if (array[i] > maxOddNumber) If there are two or more equal min/max elements, return the index of the rightmost one
                    if (array[i] >= maxOddNumber)
                    {
                        maxOddNumber = array[i];
                    }
                }
            }
            return maxNumberIndex = array.ToList().LastIndexOf(maxOddNumber);
        }
        static int MinOddIndex(int[] array, string[] command)
        {
            int minOddNumber = int.MaxValue;
            int minNumberIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    //if (array[i] < minOddNumber)
                    if (array[i] <= minOddNumber) //If there are two or more equal min/max elements, return the index of the rightmost one
                    {
                        minOddNumber = array[i];
                    }
                }
            }
            return minNumberIndex = array.ToList().LastIndexOf(minOddNumber);
        }
        static int MinEvenIndex(int[] array, string[] command)
        {
            int minEvenNumber = int.MaxValue;
            int minNumberIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    //if (array[i] < minEvenNumber) //If there are two or more equal min/max elements, return the index of the rightmost one
                    if (array[i] <= minEvenNumber)
                    {
                        minEvenNumber = array[i];

                    }
                }
            }
            return minNumberIndex = array.ToList().LastIndexOf(minEvenNumber);
        }
        static void FirstEvenElements(int[] array, int counter)
        {
            string[] result = new string[array.Length];
            int currentCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && counter > currentCount)
                {
                    currentCount++;
                    result[i] = array[i].ToString();
                }
            }

            result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
        static void FirstOddElements(int[] array, int counter)
        {
            string[] result = new string[array.Length];
            int currentCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && counter > currentCount)
                {
                    currentCount++;
                    result[i] = array[i].ToString();
                }
            }

            result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
        static void LastEvenElements(int[] array, int counter)
        {
            //array = array.Reverse().ToArray(); - тук не е добра идея да си обръщаш основната колекция - по добре ако искаш да я ползваш обърната направи друга променлива която да сочи към нея и работи с втората променлива
            List<int> result = new List<int>();
            int currentCount = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0 && counter > currentCount)
                {
                    currentCount++;
                    result.Add(array[i]);
                }
            }

            result.Reverse();// това е най кофти ситуацията от цялата задача - ако не обърна тази колекция ще ми ги отпечата в обратен ред(в реда на добавяне), което на judge не му харесва.
            //result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
        static void LastOddElements(int[] array, int counter)
        {
            //array = array.Reverse().ToArray();
            //string[] result = new string[array.Length]; // инт масив , не стринг, за какво ти е стринг като работим с числа
            List<int> result = new List<int>();
            int currentCount = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0 && counter > currentCount)
                {
                    currentCount++;
                    result.Add(array[i]);
                }
            }

            result.Reverse();

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}