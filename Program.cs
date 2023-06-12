//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

void FinalTest()
{
Console.WriteLine("Введите исходный массив через пробел: ");
string text = Console.ReadLine();
string[] existArray = text.Split(" ");
string[] newArray = existArray.Where(text=>text.Length<4).ToArray();
Console.WriteLine("Итоговый массив значений, длина которых меньше либо равна 3:  ");
Console.WriteLine(String.Join(" ", newArray));
}
FinalTest();
