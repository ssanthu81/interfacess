
interface test
{
    void add(int a, int b);
}
interface test2: test
{
    void sub(int a, int b);
}
class imp : test
{
    public void add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void sub(int a , int b)
    {
        Console.WriteLine(a - b);
    }
    static void Main()
    {
        imp ob = new imp();
        ob.add(11, 33);
        ob.sub(22, 33);
        Console.ReadLine();
    }

}