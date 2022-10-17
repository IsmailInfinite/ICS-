using System;

public class Class1
{
    public static void Main()
    {
        string[] s;
        Console.WriteLine("ENter the string");
        Console.ReadLine(s);
        string ans = "";
        for (int i = s.Length - 1;
                 i >= 0; i--)
        {
            ans += s[i] + " ";
        }
        Console.Write(
        "Reversed String:");
        Console.Write(ans.Substring(0,
                      ans.Length - 1));
    }
}
