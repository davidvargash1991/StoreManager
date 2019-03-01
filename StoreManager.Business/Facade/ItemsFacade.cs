using StoreManager.Data;
using StoreManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.Business.Facade
{
    public class ItemsFacade
    {
        public ItemsFacade()
        {
        }

        public List<Item> GetItems()
        {
            DataContext db = new DataContext();
            return db.Items.OrderBy(x => x.Name).ToList();
        }

        public Item GetItemById(int id)
        {
            DataContext db = new DataContext();
            return db.Items.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Packing> GetPackingsById(int id)
        {
            DataContext db = new DataContext();
            return db.Packings.Where(x => x.ItemId == id).OrderBy(x => x.Label).ToList();
        }

        public Item AddItem(Item newItem)
        {
            DataContext db = new DataContext();
            db.Items.Add(newItem);
            db.SaveChanges();
            return newItem;
        }
    }
}
