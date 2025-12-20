/* 1.Створити масив із 10 елементів типу int. 
    Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random. 
    Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!) 

int[] array1 = new int[10];
var random = new Random();

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = random.Next(-10, 10);

    if (i % 2 == 0)
        Console.WriteLine($"The even index is: {i}, value: {array1[i]}");

}
Console.WriteLine($"The original array is: {string.Join(", ", array1)}");
*/

//----------------------------------------------------------------------------------------

/*
2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.

int total = 0;

foreach (int i in array1)
    total += i;

Console.WriteLine($"The total is: {total}");

string message =  total < 0 ? "The total is less than 0." : "The total is greater than 0.";
Console.WriteLine(message);
*/

//----------------------------------------------------------------------------------------

/*
3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення 
(у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). 
Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

int[,] multiplicationTableArray = new int[9, 9];

for (int i = 0; i < multiplicationTableArray.GetLength(0); i++)
{

    for (int j = 0; j < multiplicationTableArray.GetLength(1); j++)
    {
        multiplicationTableArray[i, j] = (i + 1) * (j + 1);
        Console.Write(multiplicationTableArray[i, j] + "\t");
    }
    Console.WriteLine();
}
*/

//----------------------------------------------------------------------------------------

/*
 4. Створити двовимірний масив 5х5. 
Заповнити його будь-якими числами. 
Визначити та вивести на екран: 
а) максимальний елемент масиву; 
б) мінімальний елемент масиву; 
в) координати мінімального елемента масиву. 
г) координати максимального елемента масиву.

int[,] array2 = new int [5, 5];
var random2 = new Random();

// filled the arr
for (int i = 0; i < array2.GetLength(0); i++) {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = random2.Next(-10, 35);
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}

// the max el + coordinates
int maxEl = array2[0,0];
int maxElRow = -1;
int maxElCol = -1;

for (int i = 0; i < array2.GetLength(0); i++)
    for (int j = 0; j < array2.GetLength(1); j++) {
        if (array2[i, j] > maxEl)
        {
            maxEl = array2[i, j];
            maxElRow = i;
            maxElCol = j;
        }
    }

Console.WriteLine($"maxEl: {maxEl}, coordinates: {maxElRow}, {maxElCol}");

// the min el + coordinates
int minEl = array2[0,0];
int minElRow = -1;
int minElCol = -1;

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        if (array2[i, j] < minEl)
        {
            minEl = array2[i, j];
            minElRow = i;
            minElCol = j;
        }
    }
}

Console.WriteLine($"minEl: {minEl}, coordinates: {minElRow}, {minElCol}");
 */

//----------------------------------------------------------------------------------------

/*
5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів, 
а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. 
Наприклад: 
Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday
 */

int dayNumber = 0;
bool isValidDay = false;

do
{
    Console.WriteLine("Enter the day`s number:");
    var input = Console.ReadLine();
    isValidDay = int.TryParse(input, out dayNumber);

} while (!isValidDay);

weekDays day = (weekDays)(dayNumber % 7);
Console.WriteLine(day);

enum weekDays { 
    Monday,
    Tuesday,
    Wednersday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
