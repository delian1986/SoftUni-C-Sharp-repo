using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private List<Person> members;
    private string name;
    private int age;


    public Family()
    {
        members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.members.OrderByDescending(p => p.Age).First();
    }

    public Person[] GetOlderThanThirty()
    {
       return this.members.OrderBy(m => m.Name).Where(m=>m.Age>30).ToArray();
    }

}