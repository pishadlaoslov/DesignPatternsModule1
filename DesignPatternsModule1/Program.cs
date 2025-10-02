using DesignPatternsModule1;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManagment system = new EmployeeManagment();

        // Добавляем работников
        Worker worker1 = new Worker("Ivan Ivanov", 1, 500, 160);
        Worker worker2 = new Worker("Petr Petrovich", 2, 600, 120);

        // Добавляем менеджеров
        Manager manager1 = new Manager("Anna Carenina", 3, 80000, 15000);
        Manager manager2 = new Manager("Oleg Baginov", 4, 90000, 20000);

        // Добавляем сотрудников в систему
        system.AddEmployee(worker1);
        system.AddEmployee(worker2);
        system.AddEmployee(manager1);
        system.AddEmployee(manager2);

        // Отображаем зарплаты
        system.DisplayAllSalaries();

        Console.ReadLine();
    }
}
