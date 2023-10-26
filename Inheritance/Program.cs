

Customer customer = new Customer();

Person[] persons = new Person[3]
{
    //Burada Person nesnesi de oluşturabiliriz. Çünkü classlar tek başına bir anlam ifade eder. İnterface gibi değil.
    new Customer
    {
        FirstName="Ali"
    },
    new Student
    {
        FirstName="Veli"
    },
    new Person
    {
        FirstName="Kadir"
    }
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastDescription { get; set; }
}

class Person2
{
    
}

// Aşağıda olduğu gibi yazdığımız da Customer classı Person classından kalıtım yoluyla miras almış olur. Böylelikle Person classındaki her şey Customer classı için de geçerlidir
class Customer : Person
{
    public string City { get; set; }
}

// Bir class sadece bir tane class dan inherite edilir. Yani aşağıdaki Student classı hem Person hem de Person2 den miras alamaz.
class Student : Person
{
    public string City { get; set; }
}