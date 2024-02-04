using Task1;
Student student = new Student("John", "123 Main St");
student.addCourseGrade("Math", 90);
student.addCourseGrade("Science", 85);
student.addCourseGrade("English", 95);
student.PrintGrades();
Console.WriteLine("Average is : " + student.getAverageGrade());
Console.WriteLine();


Teacher teacher = new Teacher("Jane", "456 Oak St");
teacher.AddCourse("Math");
teacher.AddCourse("Science");
teacher.AddCourse("English");
teacher.RemoveCourse("Science");
Console.WriteLine("Teacher courses:");
teacher.PrintCourses();