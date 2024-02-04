namespace Task1;

public class Teacher : Person
{
    public Teacher(string _name, string _address) : base(_name, _address){}
    int numCourses = 0;
    List<string> courses;
    public void AddCourse(string course)
    {
        courses.Add(course);
    }
    public void RemoveCourse(string course)
    {
        courses.Remove(course);
    }
    public void PrintCourses()
    {
        foreach (var item in courses)
        {
            Console.WriteLine(item);
        }
    }
    public override string ToString()
    {
        return base.ToString();
 
    }
}
