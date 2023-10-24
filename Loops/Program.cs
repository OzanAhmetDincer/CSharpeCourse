

//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForeachLoop();

if (IsPrimeNumber(1))
{
    Console.WriteLine("This is a prime number.");
}
else
{
    Console.WriteLine("This is not a prime number.");
}

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number % i ==0)
        {
            result = false;
            i = number;// Bu kodu yazmamızın sebebi programımızı daha efektif yapmak. Şöyle ki  çok büyük bir sayı girdiğimizde ilk başlarda asal olup olmadığını program bulur fakat o girilen sayıya kadar döngü devam eder. Bunu istemeyiz. Program boşa çalışmasın.Bu yüzden break yada continue gibi ifadelerin yanında bu tarz bir kod ile döngüden çıkıp işlemi kesebiliriz.
        }
    }
    return result;
} 


static void ForLoop()
{
    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;
    // Belirli bir şart sağlanana kadar çalışır
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void DoWhileLoop()
{
    // İlk başta çalışıp sonradan döngüye girmesini istediğimiz durumlarda kullanılır.
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
}

static void ForeachLoop()
{
    // Diziler için özelleştirilmiş bir yapıdır. Bunu diğer döngü türleri ile de yapabiliriz.   
    string[] students = new string[3] {"Ozan","Ahmet","Veli" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}