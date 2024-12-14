class Person
{
    public int? NoOfChildren;
}
class Program
{
    static void Main()
    {
        Person p1 = new Person { NoOfChildren = 1 };
        Person p2 = new Person { NoOfChildren=null};
        Console.WriteLine(p1.NoOfChildren);
        if(p2.NoOfChildren.HasValue)
        {
            int x = p2.NoOfChildren.Value;
            Console.WriteLine(x);
        }
        Console.WriteLine(p1.NoOfChildren ?? 0); // Null coalescing Operator
        Console.WriteLine(p1?.NoOfChildren); //Null propagation operator
        Console.WriteLine(p2?.NoOfChildren);

    }
 

}
