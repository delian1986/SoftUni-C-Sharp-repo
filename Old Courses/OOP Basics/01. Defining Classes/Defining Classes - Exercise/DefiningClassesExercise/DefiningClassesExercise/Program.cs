using System;


public class Program
{
    static void Main()
    {
        var family = new Family();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();
            int age = int.Parse(args[1]);
            string name = args[0];
            var person = new Person(age, name);
            family.AddMember(person);
        }

        foreach (var person in family.GetOlderThanThirty())
        {
            Console.WriteLine(person.ToString());
        }
    }
}
