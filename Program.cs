/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.Write("Введите  3 элемента массива строк через пробел чтобы закончить ввод, нажмите 'Enter': ");
string? str = Console.ReadLine();
str.Trim();
string[] arr1 = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[arr1.Length];

 int count = 0;
 for (int i = 0; i < arr1.Length; i++) 
 if(arr1[i].Length <= 3)
 {
 array2[count] = arr1[i];
 count++;
 }
void PrintArray(string[] arr1)
{
 for (int i = 0; i < arr1.Length; i++)
 {
 Console.Write($"{arr1[i]} ");

 }
  Console.WriteLine();
}
PrintArray(arr1);
PrintArray(array2);


	
				

		
			
		



		



			
