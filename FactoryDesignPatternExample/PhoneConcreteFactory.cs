namespace FactoryDesignPatternExample
{
    public class PhoneConcreteFactory : ProductAbstractFactory
    {
        // Factory Method
        protected override IProduct FactoryMethodMakeProduct()
        {
            IProduct product = new Phone(); // Create the iProduct (Phone)     
            return product;
        }
    }
}
