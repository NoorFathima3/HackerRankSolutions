using System;

public class Program
{
    public static List<string> FilterAndSort(List<Student> students)
    {
        var filteredAndSortedStudents = students
            .Where(student => student.GPA > 3.5)
            .OrderByDescending(student => student.GPA)
            .Select(student => student.Name)
            .ToList();

        return filteredAndSortedStudents;
    }

    public static void Main()
    {
        var students = new List<Student>
    
        {
            new Student (  "Alice",  3.6 ),
            new Student (  "Bob",3.2 ),
            new Student (  "Charlie",  3.8 ),
            new Student { Name = "fathima", GPA = 3.7 }
        };

        var filteredAndSortedNames = FilterAndSort(students);

        Console.WriteLine("Filtered and Sorted Student Names:");
        foreach (var name in filteredAndSortedNames)
        {
            Console.WriteLine(name);
        }
    }
}
