using System;

namespace Prototype {
        public abstract class Item : ICloneable { //  C#

        private String title;
        private double price;
        private String url;

        public Object Clone() {
            return this.MemberwiseClone(); // MemberwiseClone C#
        }

        public string GetTitle() {
            return title;
        }

        public void SetTitle(String title) {
            this.title = title;
        }

        public double GetPrice() {
            return price;
        }

        public void SetPrice(double price) {
            this.price = price;
        }

        public String GetUrl() {
            return url;
        }

        public void SetUrl(String url) {
            this.url = url;
        }
    }
}
