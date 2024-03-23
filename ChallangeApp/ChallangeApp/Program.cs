using ChallangeApp;

Employee employee1 = new Employee("Adam" , "Kowalski" , 30);
Employee employee2 = new Employee("Monika" , "Nowak" , 18);
Employee employee3 = new Employee("Zuzia" , "Wiśniewska" , 19);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2 , employee3
};

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(7);

employee2.AddScore(2);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(1);
employee2.AddScore(5);

employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(10);
employee3.AddScore(6);


int maxScore = -1;
Employee employeeWithMaxScore = null;

foreach(var employee in employees)
{
    if (employee.Score > maxScore)
    {
        employeeWithMaxScore = employee;
    }
}

Console.WriteLine("Employee with the highest score is");
Console.WriteLine($"{employeeWithMaxScore.Name} {employeeWithMaxScore.Surname} {employeeWithMaxScore.Age} years old");
Console.WriteLine($"She get {employeeWithMaxScore.Score} points. ");
Console.WriteLine("Good job.");