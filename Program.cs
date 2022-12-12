// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Домашнее задание №34

/*
void InputArray (int[] array){  //Запоним наш массив
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}


void ReleaseArray (int[] array){  //Посчитаем количество четных чисел в массиве
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"Количетво четных чисел в массиве {count}");
}


Console.WriteLine("Введите число элементов в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Наш массив [{string.Join(", ", array)}]"); //Выведем на экран наш массив для наглядности
ReleaseArray(array);
*/


//Домашнее задание №36

/*
void InputArray (int[] array){  //Запоним наш массив
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);  //Чтобы не было больших чисел ограничим их от -100 до 100
}


void ReleaseArray (int[] array){  //Посчитаем количество четных чисел в массиве
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0)
            sum += array[i];
    }
    Console.WriteLine($"Сумма элементов под нечетными индексами равна {sum}");
}


Console.WriteLine("Введите число элементов в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Наш массив [{string.Join(", ", array)}]"); //Выведем на экран наш массив для наглядности
ReleaseArray(array);
*/


//Домашнее задание №38
/*
Console.WriteLine("Введите размер массива ");
int n = int.Parse(Console.ReadLine());
double[] newarray = new double[n];
for (int i = 0; i < n; i++){
    double x = double.Parse(Console.ReadLine());
    newarray[i] = x;
}
Console.WriteLine($"[{string.Join(", ", newarray)}]");
double min = newarray[0], max = newarray[0];
for (int i = 0; i < newarray.Length; i++){
    if (min >= newarray[i])
        min = newarray[i];
    if (max <= newarray[i])
        max = newarray[i];
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");
*/

/*
var array_no = new List<int> {};
var array_yes = new List<int> {};
Console.WriteLine("Введите число элементов массива: ");
int N = int.Parse(Console.ReadLine());
int i;
for (i = 1; i <= N; i++){
    Console.WriteLine("Введите следующий номер дня: ");
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
        array_yes.Add(n); 
    if (n % 2 != 0)
        array_no.Add(n); 
}
Console.WriteLine($"{string.Join(", ", array_no)}");
Console.WriteLine($"{string.Join(", ", array_yes)}");
if (array_yes.Count >= array_no.Count)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
*/


