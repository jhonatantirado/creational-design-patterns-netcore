using AbstractFactory.Windows;

namespace AbstractFactory{
    public class WindowsHostingPlanFactory: HostingPlanAbstractFactory {

        public override EconomyHostingPlan createEconomyHosting() {
            return new WindowsEconomyHostingPlan();
        }

        public override DeluxeHostingPlan createDeluxeHosting() {
            return new WindowsDeluxeHostingPlan();
        }

        public override UltimateHostingPlan createUltimateHosting() {
            return new WindowsUltimateHostingPlan();
        }
    }
}