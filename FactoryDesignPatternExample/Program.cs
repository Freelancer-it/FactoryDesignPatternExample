using System;

// A Factory Method lets the object (iProduct) class-type
// be determined by derived classes (PhoneConcreteFactory, LaptopConcreteFactory)
// of the Base Factory Class (ProductAbstractFactory).
//
// Zie project folder/UML for UML-structure.
// Bron: https://en.wikipedia.org/wiki/Factory_method_pattern#UML_class_diagram
//
// Usefull for:
// - Creating multiple objects that can be grouped together.
//
// TODO :: ik denk dat dit een Abstract Factory Pattern is..
// Zoek uit het verschill tussen Factory Method en Abstract Factory.
namespace FactoryDesignPatternExample
{
    #region Product(s)
    public interface IProduct
    {
        string GetName();        
    }

    public class Phone : IProduct
    {        
        public string GetName() => "Apple TouchPad";        
    }

    public class Laptop : IProduct
    {
        public string GetName() => "Macbook Air";
    }
    #endregion

    #region Factory Classes
    public abstract class ProductAbstractFactory
    {
        // Factory Method
        protected abstract IProduct FactoryMethodMakeProduct();

        // Call the Factory Method to create the Product.
        public IProduct GetObject() => this.FactoryMethodMakeProduct();
    }

    public class PhoneConcreteFactory : ProductAbstractFactory
    {
        // Factory Method
        protected override IProduct FactoryMethodMakeProduct()
        {
            IProduct product = new Phone(); // Create the iProduct (Phone)     
            return product;
        }
    }

    public class LaptopConcreteFactory : ProductAbstractFactory
    {
        // Factory Method
        protected override IProduct FactoryMethodMakeProduct()
        {
            IProduct product = new Laptop(); // Create the iProduct (Laptop)    
            return product;
        }
    }
    #endregion

    public class MainClass
    {
        private static ProductAbstractFactory _phone  = new PhoneConcreteFactory();
        private static ProductAbstractFactory _laptop = new LaptopConcreteFactory();

        private static IProduct _product;

        public static void Main(string[] args)
        {            
            _product = _phone.GetObject();
            Console.WriteLine("Product name: " + _product.GetName());

            _product = _laptop.GetObject();
            Console.WriteLine("Product name: " + _product.GetName());
        }
    }
}
