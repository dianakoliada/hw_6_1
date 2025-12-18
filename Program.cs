/* 1.Створити масив із 10 елементів типу int. 
    Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random. 
    Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!) */

int[] array1 = new int[10];
var random = new Random();

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = random.Next(-10, 10);

    if (i % 2 == 0)
        Console.WriteLine($"i: {i}, value: {array1[i]}");

}
Console.WriteLine(string.Join(", ", array1));

