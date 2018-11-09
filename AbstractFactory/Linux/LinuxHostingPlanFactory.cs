using AbstractFactory.Linux;
namespace AbstractFactory{

    public class LinuxHostingPlanFactory : HostingPlanAbstractFactory {
        
        public override EconomyHostingPlan createEconomyHosting() {
            return new LinuxEconomyHostingPlan();
        }
        
        public override DeluxeHostingPlan createDeluxeHosting() {
            return new LinuxDeluxeHostingPlan();
        }
        
        public override UltimateHostingPlan createUltimateHosting() {
            return new LinuxUltimateHostingPlan();
        }

    }
    
}