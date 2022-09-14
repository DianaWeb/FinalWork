/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → [] */

string[] startArrayStrings = { "Hello", "2", "world", "Hi!", ":-)" };
int numberElementsLessThree = CountingNumberElements(startArrayStrings);
FillNewArray(startArrayStrings, numberElementsLessThree);

int CountingNumberElements(string[] str)
{
	int count = 0;
	for (int i = 0; i < str.Length; i++)
	{
		if (str[i].Length < 4)
		{
			count++;
		}
	}
	return count;
}

void FillNewArray(string[] str, int count)
{
	string[] newStr = new string[count];
	int j = 0;

	for (int i = 0; i < str.Length; i++)
	{
		if (str[i].Length < 4)
		{
			newStr[j] = str[i];
			j++;
		}
	}
	Console.WriteLine($"Новый массив из строк, длина которых меньше, либо равна 3 символам: [\"{string.Join("\", \"", newStr)}\"]");
}

