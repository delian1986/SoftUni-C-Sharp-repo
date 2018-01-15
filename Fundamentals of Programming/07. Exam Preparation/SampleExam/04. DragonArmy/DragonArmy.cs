//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class DragonArmySolution
//{
//    static void Main()
//    {
//        int numberOfDragons = int.Parse(Console.ReadLine());

//        Army army = new Army();

//        for (int i = 0; i < numberOfDragons; i++)
//        {
//            string[] args = SplitString(Console.ReadLine());

//            string type = args[0];
//            Dragon dragon = ParseDragon(args);

//            army.AddDragon(type, dragon);


//        }

//        Console.Write(army);

//    }
//    private static Dragon ParseDragon(string[] args)
//    {
//        string name = args[1];
//        string health = args[3];
//        string damage = args[2];
//        string armor = args[4];

//        Dragon parsed = new Dragon(name, health, damage, armor);
//        return parsed;
//    }

//    private static string[] SplitString(string toSplit)
//    {
//        return toSplit.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//    }
//}

//public class Dragon
//{
//    private const int DefaultHealth = 250;
//    private const int DefaultDamage = 45;
//    private const int DefaultArmor = 10;
//    private const string Null = "null";
//    private const string ToStringFormat = "{0} -> damage: {1}, health: {2}, armor: {3}";

//    private int health;
//    private int damage;
//    private int armor;
//    private string name;

//    public Dragon(string health, string damage, string armor, string name)
//    {
//        this.Name = name;
//        this.health = this.ParsedHealth(health);
//        this.damage = this.ParsedDamage(damage);
//        this.armor = this.ParsedArmor(armor);
//    }


//    private bool StringIsNull(string value)
//    {
//        return value == "null";
//    }

//    private int ParsedHealth(string health)
//    {
//        if (this.StringIsNull(health))
//        {
//            return DefaultHealth;
//        }

//        return int.Parse(health);
//    }

//    private int ParsedDamage(string damage)
//    {
//        if (this.StringIsNull(damage))
//        {
//            return DefaultDamage;
//        }

//        return int.Parse(damage);
//    }

//    private int ParsedArmor(string armor)
//    {
//        if (this.StringIsNull(armor))
//        {
//            return DefaultArmor;
//        }

//        return int.Parse(armor);
//    }

//    public string Name
//    {
//        get
//        {
//            return this.name;
//        }
//        set
//        {
//            this.name = value;
//        }
//    }

//    public int Damage
//    {
//        get
//        {
//            return this.damage;
//        }
//    }

//    public int Health
//    {
//        get
//        {
//            return this.health;
//        }
//    }

//    public int Armor
//    {
//        get
//        {
//            return this.armor;
//        }
//    }

//    public override string ToString()
//    {
//        string formatted = string.Format(ToStringFormat, this.Name, this.damage, this.health, this.armor);
//        return formatted;
//    }
//}

//public class Army
//{
//    private Dictionary<string, Dictionary<string, Dragon>> dragonArmyByType = new Dictionary<string, Dictionary<string, Dragon>>();

//    public Army()
//    {
//        this.dragonArmyByType = new Dictionary<string, Dictionary<string, Dragon>>();
//    }

//    private const string TypeFormat = "{0}::({1:f2} / {2:f2} / {3:f2})";
//    private const string DragonFormat = "-{0}";


//    public void AddDragon(string type, Dragon dragon)
//    {
//        if (!this.dragonArmyByType.ContainsKey(type))
//        {
//            this.dragonArmyByType.Add(type, new Dictionary<string, Dragon>());
//        }

//        Dictionary<string, Dragon> dragonByName = this.dragonArmyByType[type];

//        dragonByName[dragon.Name] = dragon;
//    }

//    public override string ToString()
//    {
//        StringBuilder result = new StringBuilder();

//        foreach (KeyValuePair<string, Dictionary<string, Dragon>> kvp in this.dragonArmyByType)
//        {
//            string type = kvp.Key;
//            Dictionary<string, Dragon> dragonsByName = kvp.Value;
//            string formatted = GetTypeFormat(type, dragonsByName);

//            result.AppendLine(formatted);
//            AddDragons(result, dragonsByName);
//        }
//        return result.ToString();
//    }

//    private static void AddDragons(StringBuilder result, Dictionary<string, Dragon> dragonsByName)
//    {
//        foreach (KeyValuePair<string, Dragon> dragonAndName in dragonsByName.OrderBy(d => d.Key))
//        {
//            string dragonInfo = dragonAndName.Value.ToString();

//            string formatted = string.Format(DragonFormat, dragonInfo);
//            result.AppendLine(formatted);
//        }

//    }

//    private static string GetTypeFormat(string type, Dictionary<string, Dragon> dragonsByName)
//    {
//        double dragonsCount = dragonsByName.Count;
//        double avgDamage = GetAvgDamage(dragonsByName, d => d.Damage, dragonsCount);
//        double avgHealth = GetAvgDamage(dragonsByName, d => d.Health, dragonsCount);
//        double avgArmor = GetAvgDamage(dragonsByName, d => d.Armor, dragonsCount);

//        string formatted = string.Format(TypeFormat, type, avgDamage, avgHealth, avgArmor);
//        return formatted;
//    }

//    private static double GetAvgDamage(Dictionary<string, Dragon> dragonsByName, Func<Dragon, int> selector, double dragonsCount)
//    {
//        return dragonsByName.Sum(kvp => selector(kvp.Value) / dragonsCount);
//    }
//}


