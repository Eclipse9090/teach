/*Task 1. Составить программу обмена значениями двух переменных (при возможности не создавать третью переменную).*/

Console.WriteLine("Введите значение первой переменной");
string firstValue = Console.ReadLine(); 
Console.WriteLine("Введите значение второй переменной");
string secondValue = Console.ReadLine();
Console.WriteLine("Значение первой переменной = " + firstValue);
Console.WriteLine("Значение второй переменной = " + secondValue);
string input = Console.ReadLine();
if (int.TryParse(firstValue, out int firstValueOut)&& int.TryParse(secondValue, out int secondValueOut))
{
    firstValueOut = firstValueOut + secondValueOut;
    secondValueOut = firstValueOut - secondValueOut;
    firstValueOut = firstValueOut - secondValueOut;
    Console.WriteLine("Выводим первую переменную после обмена значениями: " + firstValueOut);
    Console.WriteLine("Выводим вторую переменную после обмена значениями: " + secondValueOut);
    Console.ReadLine();
}
else if (firstValue == "aye")
{
    Console.WriteLine("первое поле пустое");
}
else if (secondValue == null)
{
    Console.WriteLine("второе поле пустое");
}
else
{
    string thirdValue;
    thirdValue = firstValue;
    firstValue = secondValue;
    secondValue = thirdValue;
    Console.WriteLine("Выводим первую переменную после обмена значениями: " + firstValue);
    Console.WriteLine("Выводим вторую переменную после обмена значениями: " + thirdValue);
}


/*Task 2.  Реализовать сравнение двух введенных с клавиатуры чисел. После сравнения, программа
    не должна закрываться, а должна ожидать ввод следующих цифр для сравнения*/


/*while (true)
{
    Console.WriteLine("Введите значение первой переменной");
    int firstValue = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите значение второй переменной");
    int secondValue = int.Parse(Console.ReadLine());
    if (firstValue > secondValue)
    {
        Console.WriteLine(firstValue + " больше " + secondValue);
    }
    else if (firstValue < secondValue)
    {
        Console.WriteLine(firstValue + " меньше " + secondValue);
    }
    else
    {
        Console.WriteLine(firstValue + " равно " + secondValue);
    }
}*/


/*Task 3. Реализовать алгоритм, который определяет является ли введенное целочисленное число полиндромом
(читается одинаково слева направо и справа налево, для преобразования к типу int использовать Convert.ToInt32()) */

/*Console.WriteLine("Введите значение переменной");
String text = Console.ReadLine();
char[]  textChar = text.ToCharArray();
Array.Reverse(textChar);
String output = new string(textChar);
int i = Convert.ToInt32(output);
int j = Convert.ToInt32(text);
if (i == j)
    {
    Console.WriteLine("полиндром");
    }
    else
    {
       Console.WriteLine("не полииндром");
    }*/
 







