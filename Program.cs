internal class Program
{
    // static variable salary
    static double salary;
    static String name = "Aks";

    // Main Method
    public static void Main(String[] args)
    {

        // accessing static variable
        // without object
        Program.salary = 100000;

        Console.WriteLine(Program.name + "'s average salary:"
                                           + Program.salary);
    }




}