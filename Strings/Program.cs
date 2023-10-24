// String metinsel verileri tutmak için tanımlanan veri tipidir. Normalde string türü char tipinde bir dizidir.

//Intro();

string sentence = "My name is Ozan Ahmet Dinçer";

var result = sentence.Length;// Yazdığımız cümlenin karakter sayısını verir.
var result2 = sentence.Clone;// Yazdığımız cümlenin bir clonunu oluşturur.
//sentence = "Hello World";// Burada sonradan "sentence" değişkenine farklı bir değer atamamız result2 içerisini etkilemez

bool result3 = sentence.EndsWith("ğ");// Cümlenin "ğ" harfi ile bitip bitmediğini kontrol eder
bool result4 = sentence.StartsWith("My name");// Cümlenin "My name" ile başlayıp başlamadığını kontrol eder

var result5 = sentence.IndexOf("name");// Bir string değişkeninde belirli bir karakter veya ifadeyi aramak için kullanılır. Geriye o ifadenin başladığı index numarasını verir. Yoksa "-1" döndürür.
var result6 = sentence.IndexOf(" ");// Bulduğu ilk boşluk karakterinin indexini döndürür
var result7 = sentence.LastIndexOf(" ");// Aramaya sondan başlar ve tırnaklar içinde istenilen ifadenin index değerini baştan sayıp verir.

var result8 = sentence.Insert(0,"Hello, ");// Sıfırıncı indexten itibaren girilen ikinci değeri yazdırırız.

var result9 = sentence.Substring(3);// Girilen metni ayırmaya yarar. Burada 3. indexten itibaren yazdırdık
var result10 = sentence.Substring(3,4);// 3. indexten itibaren 4 karakter yazdırdık

var result11 = sentence.ToLower();// Tüm karakterleri küçük yazar
var result12 = sentence.ToUpper();// Tüm karakterleri büyük yazar

var result13 = sentence.Replace(" ", "-");// İfadeleri değiştirmeye yarar. Boşluk karakterlerini "-" ile değiştirdik

var result14 = sentence.Remove(2);// Bir metinde belirli bir indexten sonrasını atmamıza yarar. 2. indexten sonrasını atmış olduk
var result15 = sentence.Remove(2,5);// 2. indexten sonra 5 karaker atmış olduk


Console.WriteLine(result15);


static void Intro()
{
    string city = "Ankara";
    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    //string result = city + city2; Bu şekilde isimleri birleştirebileceğimiz gibi aşağıdaki "Format" metodunu kullanarak da birleştiriri. Böylelikle boşa kod yazmaktan kurtuluruz program daha etkili çalışır.
    Console.WriteLine(String.Format("{0} {1}", city, city2));
}