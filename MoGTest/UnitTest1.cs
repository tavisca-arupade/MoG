using System;
using Xunit;
using MoG;
namespace MoGTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_to_check_item_name()
        {
            Item item = new Item();
            item.Name = "Gold";
            Assert.Equal("Gold", item.Name);
        }

        [Fact]
        public void Test_to_check_item_price()
        {
            Item item = new Item();
            item.Price = "340";
            Assert.Equal("340", item.Price);
        }

        [Fact]
        public void Test_to_check_price_list_created()
        {
            Merchant merchant = new Merchant();

            merchant.AddItem("Gold", "340");
            merchant.AddItem("Silver", "140");

            var actualList = merchant.GetPriceList();

            Assert.IsType<PriceList>(actualList);
            
        }
    }
}
