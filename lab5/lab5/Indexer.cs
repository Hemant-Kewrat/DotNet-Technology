using System;
public class Employee
{
    private int id;
    private string name;
    public object this[int index]
    {
        set
        {
            if (index == 0)
                id = (int)value;
            else if (index == 1)
                name = (string)value;
        }
        get
        {
            if (index == 0)
                return id;
            else if (index == 1)
                return name;
            else
                return null;
        }
    }
}

public class IndexerTest
{
    public static void Main(String[] args)
    {
        Employee e1 = new Employee();
        e1[0] = 06;
        e1[1] = "Hemant";
        Console.WriteLine("Roll No: " + e1[0]);
        Console.WriteLine("Name: " + e1[1]);
        Console.ReadKey();
    }
}