namespace Milestone_1_HF
{
    public partial class Form1 : Form
    {
        Inventory inventory = new Inventory();


        public Form1()
        {
            InitializeComponent();

        }

        private  ListViewItem CreateListViewItem(Item item)
        {
            ListViewItem listViewItem = new ListViewItem(item.id.ToString());
            listViewItem.Tag = item;
            listViewItem.SubItems.Add(item.name.ToString());
            listViewItem.SubItems.Add(item.quantity.ToString());
            return listViewItem;


        }

        private void refreshList()
        {
            listView1.Items.Clear();
            foreach (Item item in inventory.items) 
               
            listView1.Items.Add(CreateListViewItem(item));
                ;

        }



        private void searchButton_Click(object sender, EventArgs e)
        {

            string query = searchBox.Text;
            int searchId;
            Item? item; 
            if (int.TryParse(query, out searchId))
            {
                
                item = inventory.Search(searchId);
            }
            else
            {
               item =  inventory.Search(query);
            }

            if (item == null)
            {
                MessageBox.Show("No Result Found");
            }
            else
            {
                MessageBox.Show(item.ToString());
            }




        }

       

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = addTextBox.Text;
            int quantity = (int) quantityBox.Value;

            inventory.addItem(name,quantity);

            refreshList();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string name = addTextBox.Text;
                int quantity = (int)quantityBox.Value;
                Item item = (Item)listView1.SelectedItems[0].Tag;

                inventory.editItem(item, name);
                inventory.editItem(item, quantity);

                refreshList();
            }
            else
                MessageBox.Show("Nothing is selected");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Item item = (Item)listView1.SelectedItems[0].Tag;


                inventory.removeItem(item);

                refreshList();

            }

            else
            {
                MessageBox.Show("Nothing is selected");
            }
        }


    }
}