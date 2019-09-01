namespace FactoryDesignPatternExample
{
    public class LaptopConcreteFactory : ProductAbstractFactory
    {
        // Factory Method
        protected override IProduct FactoryMethodMakeProduct()
        {
            IProduct product = new Laptop(); // Create the iProduct (Laptop)    
            return product;
        }
    }
}
