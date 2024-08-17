public class Employee
{
    private string name;
    private float salary;

    public string Name { get => name; set => name = value; }
    public float Salary { get => salary; set => salary = value; }

    /*public Employee(){
        name = "Default";
        salary = 0f;
    }*/
    public Employee(string name_, float salary_){
        name = name_;
        salary = salary_;
    }
    public Employee(Employee other){
        name = other.name;
        salary = other.salary;
    }
}