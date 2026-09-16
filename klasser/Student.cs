using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift4.arv.sep16.klasser
{
    public class Student : Person
    {
        //Skapa en subklass Student med ett extra fält StudentId och en metod PrintStudentInfo().
        //attributes
        public string StudentId { get; set; }
        //metod
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, StudentId: {StudentId}");
        }
}
}
