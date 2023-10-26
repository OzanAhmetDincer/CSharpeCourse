using Interfaces;

//InterfacesIntro();

// Bir interface hiç bir zaman new lenemez. Çünkü tek başına bir anlamı yoktur. Yani IPerson person = new IPerson(); şeklinde yazamayız. Bu interfacenin bir instance sini oluşturamayız. "IPerson person = new Student();" bu şekilde tanımlama yapabiliriz. Student classı IPerson interfacesinden implament ediliyor çünkü.

//Demo();


// Gerçek hayat da her hangi bir projede müşteriler farklı veri tabanlarında çalışmak isteyebilirler. Bu durumda burada ICustomerDal interface türünde bir dizi tanımlayıp bu dizi içerisine ICustomeDal dan implament etmiş olan tüm class ları ekleyip. Bu classlar üzerinden işlem yapabiliriz. 
ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}


static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}
static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "FirstNameTest",
        LastName = "LastNameTest",
        Address = "İstanbul"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Ali",
        LastName = "Veli",
        Departmant = "Computer Sciences"
    };

    manager.Add(customer);
    manager.Add(student);

    //yada
    /*manager.Add(new Customer
    {
        Id = 1,
        FirstName = "Ozan",
        LastName = "Veli",
        Address = "İstanbul"
    });*/
}
interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    //public void Add(Customer customer)
    //{
    //    Console.WriteLine(customer.FirstName);
    //}
    public void Add(IPerson person)
    {
        // Bu şekilde direkt interface i bir değer olarak tanımlarsak bu interface nesnesi üzerinden diğer classlara(Person, student) ulaşabiliriz. Fakat interface içerisinde olan özellikler üzerinde çalışabiliriz.
        Console.WriteLine(person.FirstName);
    }
}

