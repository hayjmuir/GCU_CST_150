namespace Milestone_1_HF
{

    class Program
    {

        static void Main()
        {
            Inventory inventory = new Inventory();

            inventory.addItem("Coke", 120);
            inventory.addItem("Sprite", 55);
            inventory.addItem("Dr.Pepper", 23);
            inventory.addItem("Big Red", 22);

            



            Console.WriteLine(inventory.ToString());
           
                                            
            Console.WriteLine();

            Item item = (Item)inventory.Search("Coke");
            Console.WriteLine(item);
            
            Console.WriteLine();

            inventory.editItem(item, "Diet Coke");
            Console.WriteLine(inventory.ToString());
            
            Console.WriteLine();

            inventory.editItem(item, 200);
            Console.WriteLine(inventory.ToString());

            Console.WriteLine();

            inventory.removeItem(item);
            
            Console.WriteLine(inventory.ToString());


            













        }
    }
}