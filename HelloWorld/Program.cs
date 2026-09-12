// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Ivan";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
// var sity = "Moscow";
// var year = 2026;
// var pi = 3.14;
// var isActive = true;
// string myName = "Ivan";
// int myAge = 20;
// string myGroup = "isp-243";
// System.Console.WriteLine($"меня зовут {myName}, мне {myAge} let, я учусь в группе {myGroup}.");
// System.Console.Write("введите ваше имя: ");
// string name2 = Console.ReadLine();
// System.Console.WriteLine($"hello, {name2}");
// System.Console.Write("введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// System.Console.WriteLine($"через 10 лет вам будет {age2 + 10} лет");



// string firstName = "ivan";
// string lastName = "ivanov";
// string group = "isp-243";
// int birthYear = 2007;
// double gpa = 4.5;
// bool hasScholarship = true;
// int currentYear = 2026;
// int age = currentYear - birthYear;
// System.Console.WriteLine("студ удостоверение");
// System.Console.WriteLine($"name: {firstName} {lastName}");
// System.Console.WriteLine($"group: {group}");
// System.Console.WriteLine($"age: {age}");
// System.Console.WriteLine($"ср балл: {gpa}");
// System.Console.WriteLine($"степуха: {hasScholarship}");
// System.Console.Write("\n введите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// System.Console.WriteLine($"Отлично! {firstName} loved {subject}");



// int a = 15;
// int b = 4;
// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");
// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");
// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));
// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно!");
// System.Console.WriteLine(int.MaxValue);
// System.Console.WriteLine(int.MinValue);
// System.Console.WriteLine(double.MaxValue);
// System.Console.WriteLine(double.MinValue);


Console.WriteLine("Добро пожаловать в анкету!");

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine());
int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status;
if (isExcellent == true) status = "Отличник";
else status = "Хорошист";
Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя:           {name} {surname}");
Console.WriteLine($"Группа:        {group}");
Console.WriteLine($"Возраст:       {age} лет");
Console.WriteLine($"Средний балл:  {gpa}");
Console.WriteLine($"Статус:        {status}");
Console.WriteLine($"Лет до 30:     {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();
