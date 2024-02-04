namespace Task1;
public class Student : Person
{
    int numCourses = 0;
    List<string> courses;
    List<int> grades;
    


    public Student(string name, string address) : base(name, address){}

    public void addCourseGrade(string _course, int _grade)
    {
        courses.Add(_course);
        grades.Add(_grade);
    }

    public void PrintGrades()
    {
        foreach (var item in grades)
        {
            Console.WriteLine(item);
        }
    }

    public double getAverageGrade()
    {
        return grades.Average();
        
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
