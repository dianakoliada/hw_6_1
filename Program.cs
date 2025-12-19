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



