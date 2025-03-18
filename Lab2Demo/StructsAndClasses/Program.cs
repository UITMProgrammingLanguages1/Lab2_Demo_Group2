//there is no inheritance in structs

//public struct A
//{

//}

//public struct B : A  // this will not compile
//{

//}

//Example 3 with Student

//var s1 = new Student();
//s1.Name = "John";
//s1.Age = 20;

//var s2 = new Student();
//s2.Name = "john";
//s2.Age = 20;

//Console.WriteLine(s1.Equals(s2)); //true or false  -- it will be false if Student is class, and true if Student is struct
////if you want the class to work like a struct you need to override Equals

//public class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public override bool Equals(object? obj)
//    {
//        //The most naive way to implement it
//        Student other = (Student)obj;
//        return Name.ToLower() == other.Name.ToLower() && Age == other.Age;
//    }
//}

//allow me for this simplification (in fact strings work more like structs than like classes (although they live in the heap))


//In c# you have two types of types: value types and reference types

//Structs are value types
//Classes are reference types

// int a = 10;  //Value type -> value directly in the variable
// string b = ""; //Reference type -> object created in the heap, and variable only holds reference to it
// DateTime c = new DateTime(2000, 12, 1);  //Value type -> value directly in the variable
// List<string> d = new List<string>(); //Reference type -> object created in the heap, and variable only holds reference to it

//Example 2 - with int[]

// int[] a = new[] { 1, 2, 3 };
//
// Console.WriteLine(a[2]); //3
// IncrementBy2(a);
// Console.WriteLine(a[2]); //now the right answer is 5
//
//
// static void IncrementBy2(int[] a)
// {
//     a[2] += 2;
//     Console.WriteLine(a[2]); //5
// }


//Example 1 - with int

//int a = 10;
//Console.WriteLine(a); // 10
//IncrementBy2(a);
//Console.WriteLine(a); // some expect to see 12 the right answer is 10


//static void IncrementBy2(int a)
//{
//    a += 2;
//    Console.WriteLine(a); //12
//}
