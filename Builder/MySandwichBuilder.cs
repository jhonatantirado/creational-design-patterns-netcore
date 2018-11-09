using System;
using System.Collections.Generic;
namespace Builder{
    public class MySandwichBuilder: SandwichBuilder {

        public override void prepareBread() {

            sandwich.setBreadType(BreadType.White);
            sandwich.setToasted(true);
        }
        
        public override void applyMeatAndCheese() {
            sandwich.setCheeseType(CheeseType.Cheddar);
            sandwich.setMeatType(MeatType.Chicken);
        }
        
        public override void applyVegetables() {
            sandwich.setVegetables(new List<String>(new string[] { "Tomato", "Onion"}));           
        }
        
        public override void addCondiments() {
            sandwich.setHasMayo(false);
            sandwich.setHasMustard(true);
        }
    }
}