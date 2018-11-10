using System;

public enum SingletonThreadSafe3Enum {
    INSTANCE
}

public static class SingletonThreadSafe3
{
    private static int state = 0;
    public static void DoSomething(this SingletonThreadSafe3Enum s1) {
        Console.WriteLine("I did something for the {0} time", ++state);
    }
}
