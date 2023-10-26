using Classes;
// Büyük projelerde her kodu tek bir yerde yazmak kalabalıklığa ve karmaşaya yol açar. Biz kullanacağımız her bir özellik yada yapı için bunları gruplayıp bu gruplanan yapılar üzerinden çağırırız. Bu yapı class yapısıdır.

// Kullanacağımız class'dan bir nesne oluşturduk yani bir örneğini referansını oluşturduk. Bu nesne üzerinden class içerisinde tanımladığımız her şeye ulaşırıp kullanırız.
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "İstanbul";
customer.Id = 1;
customer.FirstName = "Ozan";
customer.LastName= "Veli";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Ahmet",
    LastName = "Ozan",
    City = "İstanbul"
};

Console.WriteLine(customer2.FirstName);

// Class'ı bu şekilde aynı namespace içerisinde tanımlayabileceğimiz gibi farklı bir class olarak tanımlayıp oradan çağırabiliriz.
class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added");
    }
    public void Update()
    {
        Console.WriteLine("Product Updated");
    }
}