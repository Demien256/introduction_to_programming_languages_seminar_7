// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 
// a = 2, b = 10 
// a = 9, b = -3 
// a = -3, b = 9 


// 1 вариант решения

        /*
    int first_Num = 100; // первое число
    int second_Num = 11; // второе число


    // Является ли первое число квадратом второго?

    if (first_Num == second_Num * second_Num)
    {
    Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine("Нет");
    }
        */


// 2 вариант решения(другой формат вывода данных)

        /*
    int firstNum = 100; // первое число
    int secondNum = 11; // второе число

    string str = "a = " + firstNum + ", b = " + secondNum + " => да"; // конкатенация 

    if (firstNum == secondNum * secondNum)
    {
      Console.WriteLine(str);
    }
    else
    {
        Console.WriteLine($"a = {firstNum}, b = {secondNum} => нет"); // форматированная строка или же F-строка. Output(a = 100, b = 11 => нет)
    }
        */


// 3 вариант решения(прием данных от пользователя)

            /*
    Console.Write("Введите первое число: "); // ввод данных пользователя 

    string strNum = Console.ReadLine(); // запись введенных данных в переменную "strNum"
    int firstNum = int.Parse(strNum); // конвертация типа данных 'string', в тип данных int

    Console.WriteLine(firstNum); // вывод целочисленного результата в консоль 
            */
    // OR (применение конвертора 'int.Parse')
            /*
    Console.Write("Введите первое число: "); // ввод данных пользователя 
    int firstNum = int.Parse(Console.ReadLine()); // конвертированная запись введенных данных в переменную "firstNum"
    Console.WriteLine(firstNum); // вывод целочисленного результата в консоль 

    Console.Write("Введите второе число: "); // ввод данных пользователя 
    int secondNum = int.Parse(Console.ReadLine()); // конвертированная запись введенных данных в переменную "firstNum"
    Console.WriteLine(secondNum); // вывод целочисленного результата в консоль 
            */
    // OR (применение конвертора 'Convert.ToInt32'(int) 'Convert.ToInt16'(byte'255') 'Convert.ToInt64(long)') - в отличии от 'int.Parse' может принимать значения NULL (т.е. ничего)

    Console.Write("Введите первое число: "); // ввод данных пользователя 
    int firstNum = Convert.ToInt32(Console.ReadLine()); // конвертированная запись введенных данных в переменную "firstNum"
    Console.WriteLine(firstNum); // вывод целочисленного результата в консоль 

    Console.Write("Введите второе число: "); // ввод данных пользователя 
    int secondNum = Convert.ToInt32(Console.ReadLine()); // конвертированная запись введенных данных в переменную "firstNum"
    Console.WriteLine(secondNum); // вывод целочисленного результата в консоль 


    string str = "a = " + firstNum + ", b = " + secondNum + " => да"; // конкатенация 


    if (firstNum == secondNum * secondNum)
    {
        Console.WriteLine(str);
    }
    else
    {
        Console.WriteLine($"a = {firstNum}, b = {secondNum} => нет"); // форматированная строка или же F-строка. Output(a = 100, b = 11 => нет)
    }