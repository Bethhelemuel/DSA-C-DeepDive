namespace DSA_Deep_Dive_C_.Patterns.Singleton;

public sealed class Singleton1
{
   private static readonly Singleton1 instance = new Singleton1();

   private Singleton1() { }

   public static Singleton1 Instance => instance;
}