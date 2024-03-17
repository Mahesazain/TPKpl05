public class haloGeneric
{
    public void sapaUser(string x)
    {
        Console.WriteLine("Halo User " + x);
    }
}

class Program()
{
    static void Main(string[] args)
    {
        String input;
        haloGeneric inputUser = new haloGeneric();
        Console.WriteLine("Inputkan nama: ");
        input = Console.ReadLine();
        inputUser.sapaUser(input);
    }
}