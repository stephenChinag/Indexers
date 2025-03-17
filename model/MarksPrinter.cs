// Generic Constrains 


public abstract class Student
{
    public abstract int Mark { get; set; }
}


public class GraduateStudent : Student
{
    public override int Mark { get; set; }

}

public class PostGraduateStudent : Student
{

    public override int Mark { get; set; }
}

// generic  class with constrains (want to accept student only )
public class MarksPrinter <T1 , T2 >where T1: Student
{

    public T1 stu;
    public T2 stud;

    public void PrintMarks()
    {
         Student temp = (Student)stu;

        Console.WriteLine (temp);

    }
}