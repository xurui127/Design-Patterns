using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject mSubject = new Subject();
            Task1 observer1 = new Task1();
            Task2 observer2 = new Task2();
            object changedObject = " Object Changed";
            mSubject.RegisterObserver(observer1);
            mSubject.RegisterObserver(observer2);

            mSubject.NotifyObserver(changedObject);
            Console.WriteLine("===============");
            Console.WriteLine("UnRegistTask2");
            mSubject.UnRegisterObserver(observer2);
            mSubject.NotifyObserver(changedObject);
            
        }
    }
}
