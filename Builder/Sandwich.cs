using System.Collections.Generic;
using System;
namespace Builder{
    public class Sandwich {
        private BreadType breadType;
        private bool _isToasted;
        private CheeseType cheeseType;
        private MeatType meatType;
        private bool hasMustard;
        private bool hasMayo;
        private List<String> vegetables;

        public BreadType getBreadType() {
            return breadType;
        }

        public void setBreadType(BreadType breadType) {
            this.breadType = breadType;
        }

        public bool isToasted() {
            return _isToasted;
        }

        public void setToasted(bool isToasted) {
            this._isToasted = isToasted;
        }

        public CheeseType getCheeseType() {
            return cheeseType;
        }

        public void setCheeseType(CheeseType cheeseType) {
            this.cheeseType = cheeseType;
        }

        public MeatType getMeatType() {
            return meatType;
        }

        public void setMeatType(MeatType meatType) {
            this.meatType = meatType;
        }

        public bool isHasMustard() {
            return hasMustard;
        }

        public void setHasMustard(bool hasMustard) {
            this.hasMustard = hasMustard;
        }

        public bool isHasMayo() {
            return hasMayo;
        }

        public void setHasMayo(bool hasMayo) {
            this.hasMayo = hasMayo;
        }

        public List<String> getVegetables() {
            return vegetables;
        }

        public void setVegetables(List<String> vegetables) {
            this.vegetables = vegetables;
        }

        public void display() {
            
            Console.WriteLine("Sandwich on {0}", breadType);
            if (_isToasted) {
                Console.WriteLine("Toasted");
            }
            if (hasMayo) {
                Console.WriteLine("With Mayo");
            }
            if (hasMustard) {
                Console.WriteLine("With Mustard");
            }
            Console.WriteLine("Meat: {0}", meatType);
            Console.WriteLine("Cheese: {0}", cheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in vegetables) {
                Console.WriteLine("   {0}", vegetable);
            }
            Console.WriteLine("******************************");
        }
    }
}