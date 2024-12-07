
public class Product
{
    private string _productName;
    private string _productID;
    private float _price;
    private int _quantity;

     public Product(string productName, string productID, float price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return _price*_quantity;
    }

    public string GetName()
    {
        return _productName;
    }
    public string GetID()
    {
        return _productID;
    }

}