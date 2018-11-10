using System;
using System.Collections.Generic;

namespace Prototype
{

    public class Registry
    {

        private Dictionary<String, Item> items = new Dictionary<String, Item>();

        public Registry()
        {
            LoadItems();
        }

        public Item CreateItem(String type)
        {
            Item item = null;
            try
            {
                //item = (Item)(items.get(type)).clone();
                item = ((Item)(this.items.GetValueOrDefault(type).Clone()));
            }
            catch (Exception e)
            {
                throw e;
            }
            return item;
        }

        private void LoadItems()
        {
            Movie movie = new Movie();
            movie.SetTitle("Basic Movie");
            movie.SetPrice(24.99);
            movie.SetRuntime("2 hours");
            items.Add("Movie", movie);

            Book book = new Book();
            book.SetNumberOfPages(335);
            book.SetPrice(19.99);
            book.SetTitle("Basic Book");
            items.Add("Book", book);
        }
    }
}