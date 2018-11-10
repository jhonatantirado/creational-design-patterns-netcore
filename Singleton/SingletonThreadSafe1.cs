using System;

public class SingletonThreadSafe1 {
    private static SingletonThreadSafe1 instance = null;

    private SingletonThreadSafe1() {
    }

    public void DoSomething() {
        Console.WriteLine(this.GetHashCode());
    }

    public static SingletonThreadSafe1 GetInstance() {
        if (instance == null) {
            instance = new SingletonThreadSafe1();
        }
        return instance;
    }
}
