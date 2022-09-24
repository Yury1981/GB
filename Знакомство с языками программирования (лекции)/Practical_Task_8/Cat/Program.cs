using System;

namespace Cats
{
    class Program
    {
        static public void Main()
        {
            Cat cat1 = new Cat();
            cat1.SetValues("Barsik", "Siam", 3.3f, 3);
            cat1.PrintValues();

            Cat cat2 = new Cat();
            cat2.SetValues("Vasya", "Mein-kun", 5.2f, 2);
            cat2.PrintValues();
        }
    }
}