
using System.Diagnostics;
using System.Xml.Linq;

class Product
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }

    public Product(string name, int stock, int price)
    {
        Name = name;
        Stock = stock;
        Price = price;
    }
}
class VendingMachine
{

    private List<Product> products = new List<Product>();
    private int insertedMoney = 0;
    private int totalSales = 0;

    public VendingMachine() {

        products.Add(new Product("ファンタ",5,150));
        products.Add(new Product("お茶", 5, 150));
        products.Add(new Product("コーヒー", 5, 150));
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