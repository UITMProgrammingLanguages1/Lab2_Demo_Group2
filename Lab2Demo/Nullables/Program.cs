//for this demo we'll not discuss a relatively new feature: nullable reference types

//we focus ONLY on nullable value types

// int age = null; //no way to assign null to a struct (value type)
//
// string name = null;

var s = new Student();

s.Age = null;
Console.WriteLine(s.IsAdult());

public class Student
{
    public string Name { get; set; }

    public int? Age { get; set; }

    public bool? IsAdult()
    {
        if (Age.HasValue)
        {
            return Age.Value >= 18;
        }

        return null;
    }
}