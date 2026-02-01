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
            string choice = Console.ReadLine();
            
            if (choice == "1")
                Console.WriteLine("Фирсова и Алексеева");
            else if (choice == "2")
                Console.WriteLine("ИСРПО-01-22");
            else if (choice == "3")
                Console.WriteLine(DateTime.Now);
            else if (choice == "4")
                run = false;
            else
                Console.WriteLine("Ошибка: выберите 1-4");
                
            Console.WriteLine();
        }
        