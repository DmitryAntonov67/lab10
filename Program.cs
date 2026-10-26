//1
using System.IO.Compression;

string subject = "программирование";
foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"количество букв{subject.Length}");

//2
double sum = 0;
int[] grades = { 4, 5, 3, 5, 4 };
foreach (int grade in grades)
{
    sum += grade;
}
double average = sum / grades.Length;
Console.WriteLine($"средний балл:{average}");
Console.WriteLine($"сумма{sum}");

//3
string[] students = { "Аня", "Борис", "Вика" };
int number = 1;
foreach (string student in students)
{
    Console.WriteLine($"{number}.{students}");
    number++;
}