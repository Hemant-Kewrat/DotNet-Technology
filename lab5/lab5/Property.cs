using System;
public class student
{
    private int roll;
    private string name;

    public int Roll
    {
        set { roll = value; }
        get { return roll; }
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

}
public class PropertyTest
{
    public static void Main(String[] args)
    {
        student s1 = new student();
        s1.Roll = 06;
        s1.Name = "Hemant";
        Console.WriteLine("Student Roll: "+s1.Roll);
        Console.WriteLine("Student Name: "+s1.Name);
        Console.ReadKey();
    }
}