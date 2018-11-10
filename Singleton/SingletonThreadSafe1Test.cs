using System;

public class SingletonThreadSafe1Test {

    public static void SubMain(String[] args) {
        SingletonThreadSafe1 instance = SingletonThreadSafe1.GetInstance();
        Console.WriteLine(instance);

        SingletonThreadSafe1 anotherInstance = SingletonThreadSafe1.GetInstance();
        Console.WriteLine(anotherInstance);

        if (instance == anotherInstance) {
            Console.WriteLine("They are the same instance");
        }
    }
}
