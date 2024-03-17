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
        DataGeneric<string> dataString = new DataGeneric<string>("1302220105");

        dataString.PrintData();
    }
}