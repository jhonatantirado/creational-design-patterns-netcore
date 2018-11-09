using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AbstractFactoryMethod World!");

            String hostingPlan = "Windows";
            HostingPlanAbstractFactory hostingFactory = HostingPlanAbstractFactory.getHostingFactory(hostingPlan);

            EconomyHostingPlan economyHostingPlan = hostingFactory.createEconomyHosting();
            Console.WriteLine(economyHostingPlan.getFeatures());

            DeluxeHostingPlan deluxeHostingPlan = hostingFactory.createDeluxeHosting();
            Console.WriteLine(deluxeHostingPlan.getFeatures());

            UltimateHostingPlan ultimateHostingPlan = hostingFactory.createUltimateHosting();
            Console.WriteLine(ultimateHostingPlan.getFeatures());
        }
    }
}
