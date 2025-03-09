namespace Indexers{

    class Program {

        static void Main (string[] args) {
Car car =  new Car();
Console.WriteLine(car[0]);
Console.WriteLine(car[1]);
Console.WriteLine(car[2]);
     car[0] = "Nissan";
Console.WriteLine(car[0]);
for (int i = 0; i<3 ; i ++) {
    Console.WriteLine($"Brand at index{i}: {car[i]}");
}
car[3] = "Mistibush";
Console.WriteLine(car[3]);


Console.WriteLine(" This is Indexer Overriding ");
Console.WriteLine (car[3 , "is a beatifull car"]);

        }


    }
}