using beauty_shop.DAL;

namespace beauty_shop
{
    public class test
    {
        public static void show()
        {
            BaoCaoThongKeDAL dal = new BaoCaoThongKeDAL();
            Console.WriteLine(dal.GrossRevenueList);
        }
    }
}
