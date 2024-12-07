
using System.Globalization;

public class Order
{
    private List <Product> _products;
    private Customer _customer;

       public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float CalculateTotalCost()
    {
        float cost = 0;
       foreach (Product product in _products)
       {
         cost += product.TotalCost();    
       }

       return cost + GetShippingCost();
    }

    public float GetShippingCost()
    {
        if (_customer.InUSA())
        {
            return 5;
        }

        return 35;
    }

    public string GetPackingLabel()
    {
        string packinglabel = "";
        foreach (Product product in _products)
        {
            packinglabel += $"{product.GetName()} {product.GetID()} {product.GetQuantity()} for ${product.GetPrice()}\n";
        }
        
        return packinglabel;
    }

    public string GetShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.GetAddressString();
        return $"{name}\n{address}";
    }
}

