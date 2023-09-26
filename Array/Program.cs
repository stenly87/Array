// Массивы
// ссылочный тип данных, позволяющий хранить множество
// значений/объектов
// синтаксис объявления массива

// одномерный массив
//тип[] название;  объявление массива
//тип[] название = new тип[кол-во]; инициализация
// кол-во это емкость (вместимость) массива (кол-во ячеек)
/*
int[] array = new int[10]; // пример одномерного массива на 10 ячеек
// типа int
// для работы с ячейками массива используют индексы
// в одномерном массиве у каждой ячейки есть индекс - одно число
// первая ячейка в массивах имеет индекс 0

array[0] = 1; // запись значения в ячейке
Console.WriteLine(array[0]); // чтение ячейки

// массивы в C# являются неизменяемыми объектами (с точки зрения 
// размера, т.е. нельзя поменять размер массиву (добавить или удалить
// ячейки)
// пара вариантов инициализации с указанием значений
int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
int[] array2 = new int[6] { 1, 2, 3, 4, 5, 6 };

// копирование ссылки, array1 будет указывать на массив array2
array1 = array2; // массив, на который ранее указывала ссылка
// array1, будет утерян

Array.Reverse(array1); // "переворачивание" массива
Array.Sort(array2); // сортировка по значению по возрастанию
Array.Copy(array1, 0, array2, 0, 6); //копирование элементов
// из массива array1, начиная с 0 индекса, в массив array2, 6 ячеек
array1.CopyTo(array2, 0); // то же самое
*/
/*
Console.WriteLine("Сколько элементов надо в массиве?");
int.TryParse(Console.ReadLine(), out int count);

int[] sampleArray = new int[count];
// мы хотим ввести данные в массив
// 1. ввод данных с клавиатуры (через консоль)
/*for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введи-ка значение для {i}-ой ячейки");
    int.TryParse(Console.ReadLine(), out sampleArray[i]);
}*/
/*
// 2. ввод данных с помощью рандомайзера
Random random = new Random();
for (int i = 0; i < count; i++)
    sampleArray[i] = random.Next(-10, 10); // числа от 0 до 100
// можно вывести массив на консоль
for (int i = 0; i < count; i++)
    Console.WriteLine($"[{i}] = {sampleArray[i]}");
// среднее геометрическое для положительных цифр в массиве
int p = 1;
for (int i = 0; i < count; i++)
    if (sampleArray[i] > 0)
        p *= sampleArray[i];
Console.WriteLine(Math.Sqrt(p));
// сложить пары ячеек и создать новый массив из этих пар
int[] newArray = new int[count/2];
int plusCount = 0;
for (int i = 1; i < count; i += 2)
    newArray[plusCount++] = sampleArray[i - 1] + sampleArray[i];
// вывод данных из нового массива
for (int i = 0; i < newArray.Length; i++)
    Console.WriteLine($"[{i}] = {newArray[i]}");

int[,] array2d = new int[10, 10];
array2d[9, 6] = 5;

int[,,] array3d = new int[10,10,10];
array3d[8, 7, 1] = 10;

*/

// Тема 7, задача 2
Console.WriteLine("Сколько элементов надо в массиве?");
int.TryParse(Console.ReadLine(), out int count);

int[] array = new int[count]; // создаем массив с заданным размером
Random random = new Random(); // рандомизатор для случайного ввода
int zeroCount = 0;
for (int i = 0; i < count; i++)
{
    array[i] = random.Next(-1, 1); // числа от -1 до 1
    Console.WriteLine($"[{i}] = {array[i]}"); // вывод первого массива
    if (array[i] == 0)
        zeroCount++; // считаем кол-во 0 для второго массива
}
if (zeroCount == 0)
{
    Console.WriteLine("Нулевых элементов не обнаружено");
    return;
}
int[] array2 = new int[zeroCount]; // создаем второй массив
for (int i = 0, j = 0; i < count; i++) // перебираем первый массив
    if (array[i] == 0) // ищем нулевые ячейки (с 0 в значении)
        array2[j++] = i; // назначение номера во второй массив
Console.WriteLine("Получен массив:");
for (int i = 0; i < zeroCount; i++) // вывод на консоль второго массива
    Console.WriteLine($"[{i}] = {array2[i]}");