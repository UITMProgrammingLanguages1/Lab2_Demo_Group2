//var s1 = new Student("James", "Bond", 30);

//var (first, last, age) = s1;
//Console.WriteLine(first);
//Console.WriteLine(last);
//Console.WriteLine(age);

//public class Student
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }

//    public Student(string firstName, string lastName, int age)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//    }

//    //With this method you will be able to assign an object of Student class directly to a tuple
//    public void Deconstruct(out string firstName, out string lastName, out int age)
//    {
//        firstName = FirstName;
//        lastName = LastName;
//        age = Age;
//    }
//}


// int a = 12;
// int b = 18;
//
// var result = GcdAndLcm(a, b);
// Console.WriteLine(result.Gcd);
// Console.WriteLine(result.Lcm);
//
// static (int Gcd, int Lcm) GcdAndLcm(int a, int b)
// {
//     //don't look too much at the shitty implementation of the algorithm (Copilot did it)
//     var originalA = a;
//     var originalB = b;
//
//     while (b != 0)
//     {
//         var temp = b;
//         b = a % b;
//         a = temp;
//     }
//
//     var gcd = a;
//     var lcm = originalA * originalB / gcd;
//     return (gcd,lcm);
// }
//
