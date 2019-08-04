namespace MoG
{
    public class Merchant
    {
        private PriceList _priceList = new PriceList();

        public void AddItem(string Name, string Price)
        {
            Item item = new Item();
            item.Name = Name;
            item.Price = Price;

            _priceList._itemList.Add(item);
        }

        public PriceList GetPriceList()
        {
            return _priceList;
        }


    }
}
