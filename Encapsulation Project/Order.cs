public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();
    
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost(double USACost, double InternationalCost)
    {
        double TotalPrice = 0;
        
        foreach (var product in _products)
        {
            TotalPrice += product.GetTotalPrice();
        }
        
        double ShippingCost = _customer.InUSA() ? USACost : InternationalCost;
        return TotalPrice + ShippingCost;
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
          product.GetPackingLabel();
        }
    }

    public void ShippingLabel(Customer customer, Address address)
    {
        customer.GetShippingLabel();
    }
}