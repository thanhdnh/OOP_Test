public class Student{
    private string name;
    private float gpa;

    public string Name { 
        get => name; set => name = value; 
    }
    public float Gpa { 
        get => gpa; set => gpa = value; 
    }
    public Student(){
        name = "None";
        gpa = 0f;
    }
    public Student(string name_, float gpa_){
        name = name_;
        gpa = gpa_;
    }
    public Student(Student st){
        name = st.name;
        gpa = st.gpa;
    }
    public string showInfo(){
        return $"Student(name: {name}, gpa: {gpa})";
    }
}