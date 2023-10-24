

//Console.WriteLine("Hello, World!");


// Value Types
//int: Tam sayı türünde değişkenleri tutan veri tipidir

// Değişkenleri bellekte kaplayacağı yere göre seçip kullanmalıyız. Bu program hızını etkiler. Her değişken tipinin belirli bir sınırı vardır.
byte number1 = 2; // byte veri tipi 0 ile 255 sayıları arasında ki değerlerden alır. 8bit yer kaplar.
short number2 = 5; // short veri tipi -32768 ile 32767 sayıları arasında ki değerlerden alır. 16bit yer kaplar.
int number3 = 10; // int veri tipi -2147483648 ile 2147483647 sayıları arasında ki değerlerden alır. 32bit yer kaplar.
long number4 = 20000000; // long veri tipi -9223372036854775808 ile 9223372036854775807 sayıları arasında ki değerlerden alır. 64bit yer kaplar.
double number5 = 3.5; // double veri tipi ondalıklı sayıları tutmak için kullanılır. 64bit yer kaplar. Virgülde sonra 15 civarı karakter tutabilir.
decimal number6 = 10.9m; // decimal veri tipi ondalıklı sayıları tutmak için kullanılır. Virgülde sonra 25 civarı karakter tutabilir. Sayısal olarak daha hassas içerikler olduğu zaman kullanılır.
var number7 = 1; // "var" bir değişken değildir fakat değişken tutmak için kullanılır. Değişkenin türünü kendi atar.
number7 = 'a';// Bu şekilde bir tanımlama yaptığımızda "a" ifadesinin int değerini getirir ve bu number7 değişkeni içerisine int değer yazılmalıdır.

bool condition = false; // Mantıksal bir veri tipidir. Genellikle koşul-şart yapılarında kullanılır.

char character = 'a'; // Karakter türünde veri tiplerini içinde barındıran değişkendir. Bu karakterleri aski kod tabosunda sayısal bir değerleri vardır

Console.WriteLine("Number1 is {0}", number1); // süslü parantez içerisine yazılan sayı bizim index numaramızdır ve virgülden sonra yazılan ilk değer bizim sıfırıncı index'imizdir. Buna göre süslü parantez içerisinde yazan sayıya göre bu değişken içerisinde ki veriler ekrana bastırılır.
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);

Console.WriteLine("Condition is {0}", condition);

Console.WriteLine("Character is: {0}", character);
Console.WriteLine("Character is: {0}", (int)character);

Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);


enum Days
{
    // Enum içerisinde ki ifadelere değer ataması yapmazsak index olarak sıfırdan itibaren saymaya başlar. Atama yaparsak o sırada saymaya başlar yada her bir ifadeye ayrı ayrı değer atarız.
    Mondey=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}