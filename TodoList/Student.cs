public class Student

{
    public string Name { get; set; }
    public double GPA { get; set; }

    public Student() 
    {

    }

        public Student(string name, double gpa)
    {
        Name = name; 
        GPA = gpa;
    }
}