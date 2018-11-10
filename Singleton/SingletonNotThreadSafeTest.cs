using System;

public class SingletonNotThreadSafeTest {

    public static void SubMain(String[] args) {
        SingletonNotThreadSafe instance = SingletonNotThreadSafe.GetInstance();
        Console.WriteLine(instance);

        SingletonNotThreadSafe anotherInstance = SingletonNotThreadSafe.GetInstance();
        Console.WriteLine(anotherInstance);

        if (instance == anotherInstance) {
            Console.WriteLine("They are the same instance");
        }
    }
}
