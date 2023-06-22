using System;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим ввода");
            Console.WriteLine("Для режима считывания файла введите 1");
            Console.WriteLine("Для режима ввод через консоль введите 2");
            Console.WriteLine();
            int mode = int.Parse(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    Console.WriteLine("\nВыбран режим ввода через коносоль");
                    Console.WriteLine("\nВыберите режим работы программы:");
                    Console.WriteLine("\nВведите (t1) для использования функционала первой задачи");
                    Console.WriteLine("Введите (t2) для использования функционала второй задачи");
                    Console.WriteLine("Введите (t3) для использования функционала третьей задачи");
                    Console.WriteLine("Введите exit для остановки программы");
                    Console.Write("\nВыбор режима:\t");
                    string p = Console.ReadLine();
                    switch (p)
                    {
                        case ("t1"):
                            Console.WriteLine("\nВыбран режим 1:");
                            StreamReader file = new StreamReader("C:\\visual\\2.txt");
                            string sort = file.ReadLine();
                            if (sort != "b")
                            {
                                if (sort != "a")
                                {
                                    Console.WriteLine("\nОшибка заданного значения сортировки. Исправьте вводимый файл.");
                                }
                            }
                            string s = file.ReadToEnd();
                            string[] Massive_0 = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int n = Massive_0.Length;
                            int[] myArray = new int[n];
                            for (int i = 0; i < n; i++)
                            {
                                if (int.TryParse(Massive_0[i], out myArray[i]))
                                {
                                }
                                else
                                {
                                    while (!int.TryParse(Massive_0[i], out myArray[i]))
                                    {
                                        Console.WriteLine("Перепешите значение с номером:  " + i);
                                        Massive_0[i] = Console.ReadLine();
                                    }
                                }
                            }
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("\n" + myArray[i] + "\t");
                            }
                            Console.WriteLine();
                            int mx = myArray[0];
                            int mxn = 0;
                            for (int i = 1; i < myArray.Length; i++)
                            {
                                if (myArray[i] > mx)
                                {
                                    mx = myArray[i];
                                    mxn = i;
                                }
                            }
                            Console.WriteLine($"\nМаксимальный элемент массива - {mx} номер которого - {mxn}");
                            int mnn = 0;
                            int mn = myArray[0];
                            for (int i = 1; i < myArray.Length; i++)
                            {
                                if (myArray[i] < mn)
                                {
                                    mn = myArray[i];
                                    mnn = i;
                                }
                            }
                            Console.WriteLine($"\nМинимальный элемент массива - {mn}, номер которого - {mnn}");
                            Console.WriteLine("\nВыберите режим работы сортировки массива!");
                            int id_0 = 0;
                            int current_number_0 = 0;
                            switch (sort)
                            {
                                case "a":
                                    Console.WriteLine("Вывод прямой сортировки одномерного массива:");
                                    for (int i = 0; i < myArray.Length; i++)
                                    {
                                        id_0 = i;
                                        current_number_0 = myArray[i];
                                        while (id_0 > 0 && current_number_0 < myArray[id_0 - 1])
                                        {
                                            myArray[id_0] = myArray[id_0 - 1];
                                            id_0--; //-1
                                        }
                                        myArray[id_0] = current_number_0;
                                    }
                                    for (int i = 0; i < myArray.Length; i++)
                                    {
                                        Console.Write(myArray[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Вывод обратной сортировки одномерного массива:");
                                    for (int i = myArray.Length - 1; i >= 0; i--)
                                    {
                                        Console.Write(myArray[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    break;
                                case "b":
                                    Console.WriteLine("Вывод прямой сортировки одномерного массива:");
                                    Array.Sort(myArray);
                                    for (int i = 0; i < myArray.Length; i++)
                                    {
                                        Console.Write(myArray[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    Array.Reverse(myArray);
                                    Console.WriteLine("Вывод обратной сортировки одномерного массива:");
                                    for (int i = 0; i < myArray.Length; i++)
                                    {
                                        Console.Write(myArray[i] + "\t");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Режим не выбран, заканчиваю работу!");
                                    return;
                            }
                            Console.WriteLine();
                            break;
                        case ("t2"):
                            StreamReader file_1 = new StreamReader("C:\\visual\\3.txt");
                            bool error = true;
                            int k = 0;
                            int j = 0;
                            string data = file_1.ReadLine();
                            string[] dvmas = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int check = 1;
                            if (dvmas.Length == 2)
                            {
                                if ((!int.TryParse(dvmas[0], out k)) || (k < 1))
                                {
                                    check = 0;
                                    error = false;
                                }
                                else if ((!int.TryParse(dvmas[1], out j)) || (j < 1))
                                {
                                    check = 0;
                                    error = false;
                                }
                            }
                            if (dvmas.Length == 1)
                            {
                                if ((!int.TryParse(dvmas[0], out k)) || (k < j))
                                {
                                    check = 0;
                                    error = false;
                                }
                            }
                            if (check == 0)
                            {
                                while (error != true)
                                {
                                    if ((int.TryParse(dvmas[0], out k)) && (k >= 1))
                                    {
                                        if ((int.TryParse(dvmas[1], out j)) && (j >= 1))
                                        {
                                            error = true;
                                        }
                                    }
                                }
                            }
                            int[,] DVMassive = new int[j, k];
                            string t = file_1.ReadLine();
                            for (int i = 0; i < k; i++)
                            {
                                string[] myArraystr = t.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                for (int h = 0; h < j; h++)
                                {
                                    if (int.TryParse(myArraystr[h], out DVMassive[h, i]))
                                    {
                                    }
                                    else
                                    {
                                        Console.WriteLine("Перепешите значения под номером " + i + " " + h + " внутри файла");
                                        return;
                                    }
                                }
                            }
                            for (int i = 0; i < k; i++)
                            {
                                for (int h = 0; h < j; h++)
                                {
                                    Console.Write(DVMassive[h, i] + "\t");
                                }
                                Console.WriteLine();
                            }
                            int DVmx = -2147483647;
                            int DVmn = 2147483647;
                            int DVmxx = 0;
                            int DVmxy = 0;
                            int DVmnx = 0;
                            int DVmny = 0;
                            for (int i = 0; i < DVMassive.GetLength(0); i++)
                            {
                                for (int h = 0; h < DVMassive.GetLength(1); h++)
                                {
                                    if (DVMassive[i, h] > DVmx)
                                    {
                                        DVmx = DVMassive[i, h];
                                        DVmxx = i;
                                        DVmxy = h;
                                    }
                                    if (DVMassive[i, h] < DVmn)
                                    {
                                        DVmn = DVMassive[i, h];
                                        DVmnx = i;
                                        DVmny = h;
                                    }
                                }
                            }
                            Console.WriteLine($"\nМаксимальный элемент двумерного массива - {DVmx}, находящийся на координатах: (y, x) = ({DVmxy}, {DVmxx})");
                            Console.WriteLine($"\nМинимальный элемент двумерного массива - {DVmn}, находящийся на координатах: (y, x) = ({DVmny}, {DVmnx})");
                            Console.WriteLine();
                            break;
                    }
                        break;
                case 2:
                    Console.WriteLine("\nВыбран режим ввода через коносоль");
                    Console.WriteLine("\nВыберите режим работы программы:");
                    Console.WriteLine("\nВведите (t1) для использования функционала первой задачи");
                    Console.WriteLine("Введите (t2) для использования функционала второй задачи");
                    Console.WriteLine("Введите (t3) для использования функционала третьей задачи");
                    Console.WriteLine("Введите exit для остановки программы");
                    Console.Write("\nВыбор режима:\t");
                    string l = Console.ReadLine();
                    switch (l)
                    {
                        case ("t1"):
                            Console.Write("Введите количество элементов одномерного массива -\t");
                            string number = Console.ReadLine();
                            int ElCount;
                            bool result = int.TryParse(number, out ElCount);
                            if (result)
                            {
                                ElCount = int.Parse(number);
                            }
                            else
                            {
                                while (result == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определени количества элементов -\t");
                                    string number_0 = Console.ReadLine();
                                    bool result_0 = int.TryParse(number_0, out ElCount);
                                    if (result_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (ElCount <= 0)
                            {
                                while (ElCount <= 0)
                                {
                                    Console.Write("\nВы ввели некорректное число, введите число больше нуля! -\t");
                                    string number0 = Console.ReadLine();
                                    bool result0 = int.TryParse(number0, out ElCount);
                                    if (result0)
                                    {
                                        ElCount = int.Parse(number0);
                                    }
                                    else
                                    {
                                        while (result0 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определени количества элементов -\t");
                                            string number0_0 = Console.ReadLine();
                                            bool result0_0 = int.TryParse(number0_0, out ElCount);
                                            if (result0_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            int[] Massive = new int[ElCount];
                            for (int i = 0; i < Massive.Length; i++)
                            {
                                Console.Write($"\nВведите элемент под индексом {i}:\t");
                                string number0_1 = Console.ReadLine();
                                bool result1 = int.TryParse(number0_1, out Massive[i]);
                                if (result1)
                                {
                                    Massive[i] = int.Parse(number0_1);
                                }
                                else
                                {
                                    while (result1 == false)
                                    {
                                        Console.Write("\nВведите корректное число (не символ) для значения элемента массива -\t");
                                        string number0_1_0 = Console.ReadLine();
                                        bool result1_0 = int.TryParse(number0_1_0, out Massive[i]);
                                        if (result1_0 == true)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            Console.WriteLine("\nВывод элементов массива:");
                            for (int i = 0; i < ElCount; i++)
                            {
                                Console.Write(Massive[i] + "\t");
                            }
                            Console.WriteLine();
                            int mx = Massive[0];
                            int mxn = 0;
                            for (int i = 1; i < Massive.Length; i++)
                            {
                                if (Massive[i] > mx)
                                {
                                    mx = Massive[i];
                                    mxn = i;
                                }
                            }
                            Console.WriteLine($"\nМаксимальный элемент массива - {mx} номер которого - {mxn}");
                            int mnn = 0;
                            int mn = Massive[0];
                            for (int i = 1; i < Massive.Length; i++)
                            {
                                if (Massive[i] < mn)
                                {
                                    mn = Massive[i];
                                    mnn = i;
                                }
                            }
                            Console.WriteLine($"\nМинимальный элемент массива - {mn}, номер которого - {mnn}");
                            Console.WriteLine("\nВыберите режим работы сортировки массива!");
                            Console.WriteLine("Выберите символ ( a ) для запуска Режима 1 или ( b ) для запуска Режима 2");
                            Console.Write("Введите символ - ");
                            string k = Console.ReadLine();
                            Console.WriteLine();
                            int id = 0; //запоминать индекс числа
                            int currentnumb = 0; //текущее число
                            switch (k)
                            {
                                case "a":
                                    Console.WriteLine("Вывод прямой сортировки одномерного массива:");
                                    for (int i = 0; i < Massive.Length; i++)
                                    {
                                        id = i;
                                        currentnumb = Massive[i];
                                        while (id > 0 && currentnumb < Massive[id - 1])
                                        {
                                            Massive[id] = Massive[id - 1];
                                            id--; //-1
                                        }
                                        Massive[id] = currentnumb;
                                    }
                                    for (int i = 0; i < Massive.Length; i++)
                                    {
                                        Console.Write(Massive[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Вывод обратной сортировки одномерного массива:");
                                    for (int i = Massive.Length - 1; i >= 0; i--)
                                    {
                                        Console.Write(Massive[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    break;
                                case "b":
                                    Console.WriteLine("Вывод прямой сортировки одномерного массива:");
                                    Array.Sort(Massive);
                                    for (int i = 0; i < Massive.Length; i++)
                                    {
                                        Console.Write(Massive[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    Array.Reverse(Massive);
                                    Console.WriteLine("Вывод обратной сортировки одномерного массива:");
                                    for (int i = 0; i < Massive.Length; i++)
                                    {
                                        Console.Write(Massive[i] + "\t");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Режим не выбран, заканчиваю работу!");
                                    return;
                            }
                            Console.WriteLine();
                            break;

                        case ("t2"):
                            Console.WriteLine();
                            Console.Write("\nВведите количество строк - (y) во втором массиве:\t");
                            string el_y = Console.ReadLine();
                            int y;
                            bool result2 = int.TryParse(el_y, out y);
                            if (result2)
                            {
                                y = int.Parse(el_y);
                            }
                            else
                            {
                                while (result2 == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                    el_y = Console.ReadLine();
                                    bool result2_0 = int.TryParse(el_y, out y);
                                    if (result2_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (y <= 0)
                            {
                                while (y <= 0)
                                {
                                    Console.Write("\nВы ввели некорректное число, введите число больше нуля! -\t");
                                    string number1 = Console.ReadLine();
                                    bool result2_1 = int.TryParse(number1, out y);
                                    if (result2_1)
                                    {
                                        y = int.Parse(number1);
                                    }
                                    else
                                    {
                                        while (result2_1 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определени количества элементов -\t");
                                            number1 = Console.ReadLine();
                                            bool result21_0 = int.TryParse(number1, out ElCount);
                                            if (result21_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            Console.Write("\nВведите количество столбцов - (x) во втором массиве:\t");
                            string el_x = Console.ReadLine();
                            int x;
                            bool result3 = int.TryParse(el_x, out x);
                            if (result3)
                            {
                                x = int.Parse(el_x);
                            }
                            else
                            {
                                while (result3 == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                    el_x = Console.ReadLine();
                                    bool result3_0 = int.TryParse(el_x, out x);
                                    if (result3_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (x <= 0)
                            {
                                while (x <= 0)
                                {
                                    Console.Write("\nВы ввели некорректное число, введите число больше нуля! -\t");
                                    string number2 = Console.ReadLine();
                                    bool result3_1 = int.TryParse(number2, out x);
                                    if (result3_1)
                                    {
                                        y = int.Parse(number2);
                                    }
                                    else
                                    {
                                        while (result3_1 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            number2 = Console.ReadLine();
                                            bool result22_0 = int.TryParse(number2, out x);
                                            if (result22_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            int[,] DVMassive = new int[y, x];
                            Console.WriteLine();
                            Console.WriteLine("Ввод y & x:");
                            for (int i = 0; i < DVMassive.GetLength(0); i++) //y
                            {
                                for (int j = 0; j < DVMassive.GetLength(1); j++) //x
                                {
                                    Console.WriteLine($"\nY: {i} | X: {j}");
                                    string elementsxy = Console.ReadLine();
                                    bool result4 = int.TryParse(elementsxy, out DVMassive[i, j]);
                                    if (result4)
                                    {
                                        DVMassive[i, j] = int.Parse(elementsxy);
                                    }
                                    else
                                    {
                                        while (result4 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            elementsxy = Console.ReadLine();
                                            bool result4_0 = int.TryParse(elementsxy, out DVMassive[i, j]);
                                            if (result4_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            Console.WriteLine("\nВывод двумерного массива:");
                            for (int igr = 0; igr < DVMassive.GetLength(0); igr++)
                            {
                                for (int iks = 0; iks < DVMassive.GetLength(1); iks++)
                                {
                                    Console.Write(DVMassive[igr, iks] + "\t");
                                }
                                Console.WriteLine();
                            }
                            int DVmx = -2147483647;
                            int DVmn = 2147483647;
                            int DVmxx = 0;
                            int DVmxy = 0;
                            int DVmnx = 0;
                            int DVmny = 0;
                            for (int i = 0; i < DVMassive.GetLength(0); i++)
                            {
                                for (int j = 0; j < DVMassive.GetLength(1); j++)
                                {
                                    if (DVMassive[i, j] > DVmx)
                                    {
                                        DVmx = DVMassive[i, j];
                                        DVmxx = i;
                                        DVmxy = j;
                                    }
                                    if (DVMassive[i, j] < DVmn)
                                    {
                                        DVmn = DVMassive[i, j];
                                        DVmnx = i;
                                        DVmny = j;
                                    }
                                }
                            }
                            Console.WriteLine($"\nМаксимальный элемент двумерного массива - {DVmx}, находящийся на координатах: (y, x) = ({DVmxy}, {DVmxx})");
                            Console.WriteLine($"\nМинимальный элемент двумерного массива - {DVmn}, находящийся на координатах: (y, x) = ({DVmny}, {DVmnx})");
                            Console.WriteLine();
                            break;

                        case ("t3"):
                            // [ [1, 2, 3], [4, 5, 6] ] - y=2, x=3
                            Console.Write("\nВведите количество строк в зубчатом массиве:\t");
                            string kol_y1_1 = Console.ReadLine();
                            int y1;
                            bool result5 = int.TryParse(kol_y1_1, out y1);
                            if (result5)
                            {
                                y1 = int.Parse(kol_y1_1);
                            }
                            else
                            {
                                while (result5 == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                    kol_y1_1 = Console.ReadLine();
                                    bool result5_0 = int.TryParse(kol_y1_1, out y1);
                                    if (result5_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (y1 <= 0)
                            {
                                while (y1 <= 0)
                                {
                                    Console.Write("\nВы ввели некорректное число, введите число больше нуля! -\t");
                                    string number3 = Console.ReadLine();
                                    bool result5_1 = int.TryParse(number3, out y1);
                                    if (result5_1)
                                    {
                                        y1 = int.Parse(number3);
                                    }
                                    else
                                    {
                                        while (result5_1 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            number3 = Console.ReadLine();
                                            bool result51_0 = int.TryParse(number3, out y1);
                                            if (result51_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            int[][] Massivezub = new int[y1][];
                            int x1 = 0;
                            for (int i = 0; i < y1; i++)
                            {
                                Console.Write($"\nВведите количество элементов в {i} строке в зубчатом массиве:\t");
                                string kol_x1 = Console.ReadLine();
                                bool result6 = int.TryParse(kol_x1, out x1);
                                if (result6)
                                {
                                    x1 = int.Parse(kol_x1);
                                }
                                else
                                {
                                    while (result6 == false)
                                    {
                                        Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                        kol_x1 = Console.ReadLine();
                                        bool result6_0 = int.TryParse(kol_x1, out x1);
                                        if (result6_0 == true)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (x1 <= 0)
                                {
                                    while (x1 <= 0)
                                    {
                                        Console.Write("\nВы ввели некорректное число, введите число больше нуля! -\t");
                                        string number5 = Console.ReadLine();
                                        bool result6_1 = int.TryParse(number5, out x1);
                                        if (result6_1)
                                        {
                                            x1 = int.Parse(number5);
                                        }
                                        else
                                        {
                                            while (result6_1 == false)
                                            {
                                                Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                                number5 = Console.ReadLine();
                                                bool result61_0 = int.TryParse(number5, out x1);
                                                if (result61_0 == true)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                                int[] subMassive = new int[x1];
                                for (int j = 0; j < x1; j++)
                                {
                                    Console.WriteLine($"\nY: {i} | X: {j}");
                                    string el_j = Console.ReadLine();
                                    bool result7 = int.TryParse(el_j, out subMassive[j]);
                                    if (result7)
                                    {
                                        subMassive[j] = int.Parse(el_j);
                                    }
                                    else
                                    {
                                        while (result7 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            el_j = Console.ReadLine();
                                            bool result7_0 = int.TryParse(el_j, out subMassive[j]);
                                            if (result7_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                                Massivezub[i] = subMassive;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Вывод зубчатого массива:");
                            for (int i = 0; i < Massivezub.Length; i++)
                            {
                                for (int j = 0; j < Massivezub[i].Length; j++)
                                {
                                    Console.Write(Massivezub[i][j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Вывод зубчатого массива:");
                            int mxzub = -2147483647;
                            int mnzub = 2147483647;
                            int mxzub_id_y = 0;
                            int mxzub_id_x = 0;
                            int mnzub_id_y = 0;
                            int mnzub_id_x = 0;
                            int numbers = 0;
                            for (int i = 0; i < Massivezub.Length; i++)
                            {
                                for (int j = 0; j < Massivezub[i].Length; j++)
                                {
                                    numbers += 1; //счёт количества элементов зубчатого массива
                                    if (Massivezub[i][j] > mxzub)
                                    {
                                        mxzub = Massivezub[i][j];
                                        mxzub_id_y = i;
                                        mxzub_id_x = j;
                                    }
                                    if (Massivezub[i][j] < mnzub)
                                    {
                                        mnzub = Massivezub[i][j];
                                        mnzub_id_y = i;
                                        mnzub_id_x = j;
                                    }
                                }
                            }
                            Console.WriteLine($"\nМаксимальный элемент двумерного массива - {mxzub}, находящийся на координатах: (y, x) = ({mxzub_id_y}, {mxzub_id_x})");
                            Console.WriteLine($"\nМинимальный элемент двумерного массива - {mnzub}, находящийся на координатах: (y, x) = ({mnzub_id_y}, {mnzub_id_x})");
                            Console.WriteLine($"\nВведите строку элемента массива для замены его на случайный, в пределе от (0, до {y1 - 1})");
                            string y_rd = Console.ReadLine();
                            int numbers_test;
                            bool result8 = int.TryParse(y_rd, out numbers_test);
                            if (result8)
                            {
                                numbers_test = int.Parse(y_rd);
                            }
                            else
                            {
                                while (result8 == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                    y_rd = Console.ReadLine();
                                    bool result8_0 = int.TryParse(y_rd, out numbers_test);
                                    if (result8_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if ((numbers_test < 0) || (numbers_test > y1 - 1))
                            {
                                while ((numbers_test < 0) || (numbers_test > y1 - 1))
                                {
                                    Console.WriteLine($"\nВы ввели некорректное число, введите число в пределе от (0, до {y1 - 1})");
                                    string numbers_tst = Console.ReadLine();
                                    bool result9 = int.TryParse(numbers_tst, out numbers_test);
                                    if (result9)
                                    {
                                        numbers_test = int.Parse(numbers_tst);
                                    }
                                    else
                                    {
                                        while (result9 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            numbers_tst = Console.ReadLine();
                                            bool result9_0 = int.TryParse(numbers_tst, out numbers_test);
                                            if (result9_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            Console.WriteLine($"\nВведите строку элемента массива для замены его на случайный, в пределе от (0, до {Massivezub[numbers_test].Length - 1})");
                            string x_rd = Console.ReadLine();
                            int numbers_test1;
                            bool result10 = int.TryParse(x_rd, out numbers_test1);
                            if (result10)
                            {
                                numbers_test1 = int.Parse(x_rd);
                            }
                            else
                            {
                                while (result10 == false)
                                {
                                    Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                    x_rd = Console.ReadLine();
                                    bool result10_0 = int.TryParse(x_rd, out numbers_test1);
                                    if (result10_0 == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if ((numbers_test1 < 0) || (numbers_test1 > Massivezub[numbers_test].Length - 1))
                            {
                                while ((numbers_test1 < 0) || (numbers_test1 > Massivezub[numbers_test].Length - 1))
                                {
                                    Console.WriteLine($"\nВы ввели некорректное число, введите число в пределе от (0, до {Massivezub[numbers_test].Length - 1})");
                                    string numbers_tst1 = Console.ReadLine();
                                    bool result11 = int.TryParse(numbers_tst1, out numbers_test1);
                                    if (result11)
                                    {
                                        numbers_test1 = int.Parse(numbers_tst1);
                                    }
                                    else
                                    {
                                        while (result11 == false)
                                        {
                                            Console.Write("\nВведите корректное число (не символ) для определения количества элементов -\t");
                                            numbers_tst1 = Console.ReadLine();
                                            bool result11_0 = int.TryParse(numbers_tst1, out numbers_test1);
                                            if (result11_0 == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            Random random = new Random();
                            Massivezub[numbers_test][numbers_test1] = random.Next(1000);
                            Console.WriteLine();
                            Console.WriteLine($"Вывод зубчатого массива с изменённым элементом под номером {numbers_test}");
                            for (int i = 0; i < Massivezub.Length; i++)
                            {
                                for (int j = 0; j < Massivezub[i].Length; j++)
                                {
                                    Console.Write(Massivezub[i][j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;

                        case ("exit"):
                            return;

                        default:
                            Console.WriteLine("Неккоректный символ, заканчиваю работу!");
                            Console.WriteLine();
                            break;
                    }
                    break;
            }
        }
    }
}