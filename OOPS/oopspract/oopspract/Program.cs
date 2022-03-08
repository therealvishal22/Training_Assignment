public class clsobj
{
    public int a;
}
class objclspract
{
    static void Main(string[] args)
    {
        clsobj p = new clsobj();
        p.a =20;
        Console.WriteLine("Value of a is "+p.a);
    }
}
}