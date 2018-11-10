using System;

public class SingletonNotThreadSafe {
    private static SingletonNotThreadSafe instance = null;

    private SingletonNotThreadSafe() {
    }

    public void DoSomething() {
        Console.WriteLine(this.GetHashCode());
    }

    public static SingletonNotThreadSafe GetInstance() {
        if (instance == null) {
            instance = new SingletonNotThreadSafe();
        }
        return instance;
    }
}
