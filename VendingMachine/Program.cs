
class VendingMachine
{
    private List<String> products = new List<String>();
    private int insertedMoney = 0;
    private int totalSales = 0;

    public VendingMachine() {

        products.Add("ファンタ");
        products.Add("お茶");
        products.Add("コーヒー");
    }


    public InsertedMoney(int money)
    {
        insertedMoney += money;
        Console.WriteLine($"{money}円を投入しました。現在の投入額: {insertedMoney}円");


    }

    public void ShowProducts()
    {


    }
}