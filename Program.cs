//1

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
//4
int[] bs = { 4, 5, 3, 5, 4 };
for (int a = 0; a < bs.Length; a++)
{
    bs[a] = bs[a] + 1;
}
Console.WriteLine("изменение оценки");
foreach (int b in bs)
{
    Console.WriteLine(b);
}

//самостоятельная работа   А и Б
int summ = 0;
int[] figures = { 1, 2, 3, 4, 5 };
foreach (int figure in figures)
{
    Console.WriteLine(figure);
    summ += figure;
}
Console.WriteLine($"сумма:{summ}");

//b
string[] dey = { "pn", "vt", "sr", "ht", "py", "sy", "vs" };
foreach (string deys in dey)
{
    Console.WriteLine(deys + "!");

}

//5 variant 
string[] books = { "mantek", "karmalogic", "ono" };
string target = "mantek";
bool found = false;
foreach (string book in books)
{
    if ( book == target)
    {
        found = true;
        break;
    }
}
if (found)
    Console.WriteLine("найдено");
else
    Console.WriteLine("не найдено");

//6
int[] ohci = { 3, 5, 7, 10, 15 };
int min = ohci[0];
int max = ohci[0];

foreach (int ohcis in ohci)
{
    if (ohcis > max)
    {
        max = ohcis;
    }
    if (ohcis < min)
    {
        min = ohcis;
    }
}
Console.WriteLine($"минимум:{min}");
Console.WriteLine($"максимум:{max}");