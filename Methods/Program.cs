// Metot kullanmamızın sebebi: Eğer programımız da kod tekrarı varsa yani aynı kod kalıpları tekrar tekrar kullanılıyorsa kullanılır. Böylelikle hem kod tekrarını ortadan kaldırırız hem de bu kodlar içerisinde bir değişikliğe gidileceği zaman tek bir yerden yaptığımız değişiklik ile tüm her yerde bunları değiştiririz.


//Add();
//var result = Add2(200, 10);
int number1 = 20;
int number2 = 100;

var result2 = Add3(ref number1, number2); // Bu metotda "ref" keyword kullanmamızın sebebi normalde değer tipli tanımladığımız "number1" değişkeni hiç bir şekilde değişikliğe uğramaz metot içerisinde farklı bir değer atansa bile o değer metot içerisinde kullanılır ve biter ve ilk tanımladığımız değer geçerli olur, "ref" ile bu değişkenin referans tipli bir değişken olarak davranmasını isteriz ve metot içerisinde yazdığımız değer ilk tanımladığımız değer üzerine yazılır. 
// "ref" yerine "out" keywordu de kullanılabilir. Bu ikisi arasında ki fark ref de ilk başta değişkene değer ataması yapmamız gerek, out da değer ataması yapmasakta olur fakat out da metot içerisinde bir değer ataması yapmamız lazım yoksa hata verir.


Console.WriteLine(Multiply(2, 4));
Console.WriteLine(Multiply1(2, 4, 5));

Console.WriteLine(result2);
Console.WriteLine(number1);

Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

// Aşağıda ki metot sadece bir veri ekrana getireceğimiz zaman kullanılır. Geriye her hangi bir değer döndürmez ve parametre olmaz.
static void Add()
{
    Console.WriteLine("Added!");
}

// Aşağıda ki metot parametre alır ve geriye bir değer döndürür. Bu metodu geriye ne türde bir değer döndürecekse(int, string) o şekilde tanımlarız. Eğer her hangi bir değer ataması yapılmazsa aşağıda ki gibi default olarak tanımladığımız değerler parametrelere atanır. Burada ilk parametreye değer atayıp ikinci parametreye değer atamaması yapılmaz. Eğer bir parametre ataması yapılacaksa parantez içerisinde en sonda olacak şekide tanımlanır.
static int Add2(int number1 = 20, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Multiply1(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}

static int Add4(params int[] numbers)
{
    // "params" keywordu ile aynı türde istediğimiz kadar değişkeni göndereceğimizi söylemiş oluruz. Bu metoda istenilen kadar değişken girebilirsin. Tanımlayacağımız "params" parametreleri metodun son parametresi olmak zorunda.
    return numbers.Sum();
}