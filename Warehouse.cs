using Checkout;

namespace Warehouse
{
    class WareHouse
    {
        List<Item> items = new List<Item>();
        List<Transaction> transactions = new List<Transaction>();

        // Check transaction is valid
        // validate transaction's ID with the bank
        // add transaction to internal list
        // on confirmation add remove items from warehouse
    }
    
}