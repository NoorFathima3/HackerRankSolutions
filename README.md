"# HackerRankSolutions" 
1. Using LINQ for Filtering and Sorting Data
This question tests your understanding and application of LINQ (Language Integrated Query), a powerful feature in C# that is used for working with data.

Task: Write a C# method called FilterAndSort that takes a list of students (objects) and returns a sorted list of student names who have a GPA greater than 3.5. The list should be sorted in descending order.

Input Format: The input will be a List<Student>, where the Student class is defined as follows:
public class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }
}

Constraints:

The list will contain at least one Student object.
Student names will be non-empty strings.
GPA will be a double between 0.0 and 4.0.
Output Format: The output will be a List<string> containing the names of students who have a GPA greater than 3.5, sorted in descending order.

Sample Input:

var students = new List<Student>
{
    new Student { Name = "Alice", GPA = 3.6 },
    new Student { Name = "Bob", GPA = 3.2 },
    new Student { Name = "Charlie", GPA = 3.8 }
};
Sample Output: [“Charlie”, “Alice”]

Sample Code:

public static List<string> FilterAndSort(List<Student> students)
{
    return students
        .Where(student => student.GPA > 3.5)
        .OrderByDescending(student => student.GPA)
        .Select(student => student.Name)
        .ToList();
}

Explanation:

The FilterAndSort method utilizes several LINQ operators to filter and sort the list of students. 
First, the Where operator is used to filter out students who have a GPA greater than 3.5. 
Then, the OrderByDescending operator is used to sort the remaining students in descending order based on their GPA.
The Select operator is then used to project each student into a new form — in this case, just their name.
Finally, ToList is called to convert the resulting IEnumerable to a list.
This question is excellent for testing your understanding of how to use LINQ to manipulate data in C#. In an interview setting, it can also lead to further discussions about performance considerations and alternative approaches. 
