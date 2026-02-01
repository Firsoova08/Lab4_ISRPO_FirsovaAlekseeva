// See https://aka.ms/new-console-template for more information
Console.WriteLine("   ЛАБОРАТОРНАЯ РАБОТА №4");
string name="Фирсова Алиса и Алексеева Валерия";
string group = "ИСП-232";
 Console.WriteLine($"ФИО: {name}");
  Console.WriteLine($"Группа: {group}");
 Console.WriteLine($"Дата: {DateTime.Now}");

 bool run = true;
        
        while (run)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Показать ФИО");
            Console.WriteLine("2 - Показать группу");
            Console.WriteLine("3 - Показать дату");
            Console.WriteLine("4 - Выход");
        }