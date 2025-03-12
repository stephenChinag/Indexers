namespace Indexers
{

    class Program
    {

        static void Main(string[] args)
        {
            // Car car =  new Car();
            // Console.WriteLine(car[0]);
            // Console.WriteLine(car[1]);
            // Console.WriteLine(car[2]);
            //      car[0] = "Nissan";
            // Console.WriteLine(car[0]);
            // for (int i = 0; i<3 ; i ++) {
            //     Console.WriteLine($"Brand at index{i}: {car[i]}");
            // }
            // car[3] = "Mistibush";
            // Console.WriteLine(car[3]);


            // Console.WriteLine(" This is Indexer Overriding ");
            // Console.WriteLine (car[3 , "is a beatifull car"]);


            //create Object 

            // Employee emp1 = new Employee(101, "Stephen Chinag", "Nigeria");

            // Console.WriteLine("Object of Parent Class (Employee)");
            // Console.WriteLine(emp1.EmpId);
            // Console.WriteLine(emp1.EmpName);
            // Console.WriteLine(emp1.Location);
            // // Create Object Of Manager 

            // Manager mgr1 = new Manager(102, "YA", ":Nigeria", "ICT");

            // Console.WriteLine("Object of Parent Class (Employee)");
            // Console.WriteLine(mgr1.EmpId);
            // Console.WriteLine(mgr1.EmpName);
            // Console.WriteLine(mgr1.Location);
            // Console.WriteLine(mgr1.Department);
            // Console.WriteLine(mgr1.GetFullDepartmentName());


            // // Sales Man
            // SalesMan sMan1 = new SalesMan(103, "dANTE", "USA", "aPPA aUDIT");

            // Console.WriteLine("Object of Parent Class (Employee)");
            // Console.WriteLine(sMan1.EmpId);
            // Console.WriteLine(sMan1.EmpName);
            // Console.WriteLine(sMan1.Location);
            // Console.WriteLine(sMan1.Region);
            // Console.WriteLine(sMan1.GetHealthInsuranceAmout());

            // Console.ReadKey();




            User<int> user = new User<int>();

            user.RegistrationStatus = 100;

            Console.WriteLine(user.RegistrationStatus);


        }


    }
}