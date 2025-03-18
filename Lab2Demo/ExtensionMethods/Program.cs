Console.WriteLine("marCin jagIeła".ToSentence());// this is a dream -- now we have it

Console.WriteLine("jamEs BoNd".ToSentence());
Console.WriteLine("jasON Bourne".ToSentence());

Console.WriteLine(5.IsOdd());
Console.WriteLine(6.IsOdd());
Console.WriteLine(7.IsOdd());

public static class IntExtensions
{
    public static bool IsOdd(this int input)
    {
        return input % 2 != 0;
    }
}


//this idea would be good, but it will not work (string is sealed)
//public class BetterString : string
//{
//    public string ToSentence()
//    {
//        //blablablab
//    }
//}