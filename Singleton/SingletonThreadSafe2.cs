using System;

public class SingletonThreadSafe2 {
    private static SingletonThreadSafe2 instance = null;

    private SingletonThreadSafe2() {
    }

    public void DoSomething() {
        Console.WriteLine(this.GetHashCode());
    }

    public static SingletonThreadSafe2 GetInstance() {
        if (instance != null) {
            return instance;
        }
        lock (instance) {
            if (instance == null) {
                instance = new SingletonThreadSafe2();
            }
        }
        return instance;
    }
}
