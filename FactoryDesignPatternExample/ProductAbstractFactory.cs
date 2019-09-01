namespace FactoryDesignPatternExample
{
    public abstract class ProductAbstractFactory
    {
        // Factory Method
        protected abstract IProduct FactoryMethodMakeProduct();

        // Call the Factory Method to create the Product.
        public IProduct GetObject() => this.FactoryMethodMakeProduct();
    }
}
