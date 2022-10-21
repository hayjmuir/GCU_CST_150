using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_HF
{
    internal class Item
    {
        public static int idcounter;
        public int id;
        public string name;
        public int quantity;
        public override string ToString() 
        
        { return id + "\t" + name + " | " + quantity; }

        public Item(string name, int quantity)
        {
            this.id = idcounter++;
            this.name = name;
            this.quantity = quantity;
        }
    }




    internal class Inventory
    {
        List<Item> items;
      
        
            
        public Inventory()
        {

            items = new List<Item>();

        }



        //search by name 
        public Item? Search(string name)
        {
            foreach (Item item in items)
            {
                if (item.name == name)
                    return item;

            }
            return null;


        }


        //search by quantity
        public Item? Search(int quantity)
        {
            foreach (Item item in items)
            {
                if (item.quantity == quantity)
                    return item;

            }
            return null;


        }


        //adds item to inventory
        public void addItem(string name, int quantity)
        {
            
            items.Add(new Item(name, quantity));


        }


        //removes item from inventory
        public void removeItem(Item item)
        {
            items.Remove(item);


        }



        //edits name 

        public void editItem(Item item, string new_name)
        {
            item.name = new_name;
        }

        //edits quantity
        public void editItem(Item item, int new_quantity)
        {
            item.quantity = new_quantity;
        }


        public string ToString()
        {

            return String.Join("\n" , items);


        }


    }
}