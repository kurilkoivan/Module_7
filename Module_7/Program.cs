class A
{
    public virtual void Display() 
    {
        Console.WriteLine("A");
    }
    
}
class B : A
{
    internal virtual void Display()
    {
        Console.WriteLine("B");
    }

}
class C : A
{
    public override void Display()
    {
        Console.WriteLine("D");
    }

}
class D : B
{
    public new void Display()
    {
        Console.WriteLine("E");
    }

}
class E : C
{
    public new void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }

}
