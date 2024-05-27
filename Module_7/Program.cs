class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}
class ProjectManager : Employee 
{
    private string ProjectName;
}
class Developer : Employee
{
    private string ProgrammingLanguage;
}