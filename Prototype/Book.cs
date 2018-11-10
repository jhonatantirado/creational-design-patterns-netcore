namespace Prototype { 
    public class Book : Item {
        private int numberOfPages;

        public int GetNumberOfPages() {
            return numberOfPages;
        }

        public void SetNumberOfPages(int numberOfPages) {
            this.numberOfPages = numberOfPages;
        }
    }
}
