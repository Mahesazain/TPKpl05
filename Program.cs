public class haloGeneric
{

    public void sapaUser(string x)
    {
        Console.WriteLine("Halo User " + x);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: {0}", data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string input;
        haloGeneric userInput = new haloGeneric();

        Console.WriteLine("Inputkan nama: ");
        input = Console.ReadLine();
        userInput.sapaUser(input);

        DataGeneric<string> dataString = new DataGeneric<string>("1302220105");

        dataString.PrintData();
    }
}