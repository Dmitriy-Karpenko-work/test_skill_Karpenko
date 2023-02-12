void ArrayFind3(string[] firstarray, string[] finalarray)// основной метод
{
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
    if(firstarray[i].Length <= 3)
        {
        finalarray[count] = firstarray[i];
        count++;
        }
    }
}
void PrintArray(string[] array) // метод показа массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] firstarray = new string[4] { "hello","2","world",":-)"}; // массив вводим в ручную 
string[] finalarray = new string[firstarray.Length]; // преобразованый массив

ArrayFind3(firstarray, finalarray);
PrintArray(finalarray);

// Пример
//{ "hello","2","world",":-)"}
//{ "1234","1567","-2","conputer science"}
//{"Russia","Denmark","Kazan"}