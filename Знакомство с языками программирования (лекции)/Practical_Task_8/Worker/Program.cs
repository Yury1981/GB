using System;

namespace Worker
{
    class Program
    {
        static public void Main()
        {
            CreateWorker worker1 = new CreateWorker();
            worker1.SetValues("Ivanov", "Ivan", "Ivanovich", "Slesar", 33);
            worker1.PrintValues();

            CreateWorker worker2 = new CreateWorker();
            worker2.SetValues("Petrov", "Petr", "Petrovich", "Director", 45);
            worker2.PrintValues();
        }
    }
}