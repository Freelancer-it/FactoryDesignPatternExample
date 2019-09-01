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
namespace FactoryDesignPatternExample
{   
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
