// Koşul-şart ifadelerinde if - else if - else parantezleri içerisinde ki şart sağlarsa o blok içerisinde ki komutlar çalıştırılır. "=" atama yapar. "==" karşılaştırma yapar. 
var number = 92;
/*if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}*/

//Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); Üstte yazdığımız şart bloklarını tek satırda da yazabiliriz.

// if-else yapısı ile yaptığımız işlemleri switch-case yapısı ile de yapabiliriz. İstenilen durum hangi case içeriğini sağlarsa o case altındaki kodları çalıştırır.

/*switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}*/

if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

// Aşağıda olduğu gibi iç içe(nested) koşul-şart ifadeleri kullanılabilir
if (number < 100)
{
    if (number >= 90 && number <=95)
    {
        Console.WriteLine("Hello World!");
    }
}