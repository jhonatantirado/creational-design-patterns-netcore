using System;
using System.Collections.Generic;
namespace Builder{
    public class ClubSandwichBuilder : SandwichBuilder {
    
    public override void prepareBread() {
        sandwich.setBreadType(BreadType.White);
        sandwich.setToasted(true);
    }
    
    public override void applyMeatAndCheese() {
        sandwich.setCheeseType(CheeseType.Swiss);
        sandwich.setMeatType(MeatType.Turkey);
    }
    
    public override void applyVegetables() {
        sandwich.setVegetables(new List<String>(new string[] { "Tomato", "Onion", "Lettuce"}));     
    }
    public override void addCondiments() {
        sandwich.setHasMayo(true);
        sandwich.setHasMustard(true);
    }
}
}