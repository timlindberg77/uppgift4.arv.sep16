using uppgift4.arv.sep16.klasser;

namespace uppgift4.arv.sep16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Skapa ett Student-objekt och visa att det ärver både Name och Age.
            Student Elev1 = new Student();
            //objekt information
            Elev1.Name = "John Doe";
            Elev1.Age = "20";
            Elev1.StudentId = "12345";
            //metod
            Elev1.PrintStudentInfo();

        }
    }
}
