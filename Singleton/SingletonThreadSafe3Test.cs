using System;

public class SingletonThreadSafe3Test {

    public static void SubMain(String[] args) {
        SingletonThreadSafe3.DoSomething(SingletonThreadSafe3Enum.INSTANCE);
        SingletonThreadSafe3.DoSomething(SingletonThreadSafe3Enum.INSTANCE);
    }
}
