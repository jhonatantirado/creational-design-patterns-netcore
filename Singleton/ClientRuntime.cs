using System;

public class ClientRuntime {

	public static void Main(string[] args) {
        Environment singletonRuntime = Environment;
        GC.Collect();
        GC.WaitForPendingFinalizers();
		Console.WriteLine(singletonRuntime);

        Environment anotherInstance = Environment;
        Console.WriteLine(anotherInstance);		
		
		if (singletonRuntime == anotherInstance) {
            Console.WriteLine("They are the same instance");
		}
	}
}