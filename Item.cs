namespace Warehouse
{
    class Item
    {
        private string itemName;
        private string ItemName
        {
            get;
            set;
        }
        private decimal itemPrice;
        private decimal ItemPrice
        {
            get;
            set;
        }

        Item(string name, decimal price)
        {
            this.ItemPrice = price;
            this.ItemName = name;
        }

    }

}