public class Employee2
{
    public int Salary;
}

public class Student 
{
   public int Marks; 
}

// A class with generic Method 
public class Sample 
{
    public void PrintData<T>(T obj) 
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        if (obj.GetType() == typeof(Student))
        {
            Student? temp = obj as Student;
            if (temp != null) // Add null check
            {
                Console.WriteLine(temp.Marks);
            } 
        }
        else if(obj.GetType() == typeof(Employee2))
        {
            Employee2? temp2 = obj as Employee2;
            if (temp2 != null) // Add null check
            {
                Console.WriteLine(temp2.Salary);
            }
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}