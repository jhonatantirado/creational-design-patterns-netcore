using System;

public class SingletonThreadSafe2Test {

    public static void SubMain(String[] args) {
        SingletonThreadSafe2 instance = SingletonThreadSafe2.GetInstance();
        Console.WriteLine(instance);

        SingletonThreadSafe2 anotherInstance = SingletonThreadSafe2.GetInstance();
        Console.WriteLine(anotherInstance);

        if (instance == anotherInstance) {
            Console.WriteLine("They are the same instance");
        }
    }
}
