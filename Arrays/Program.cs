/*string[] students = new string[3];
students[0] = "Ozan";
students[1] = "Ahmet";
students[3] = "Kadir";


string[] students2 = { "Engin", "Ali", "Mehmet" }; // Yada string[] students2 = new []{"Engin","Ali","Mehmet"};

string[] students3 = new string[3] { "Engin", "Ali", "Mehmet" };

foreach (var student in students)
{
    Console.WriteLine(student);
}*/

// Çok boyutlu dizi tanımlama

// Aşağıda 5 satır 3 sütunlu bir çok boyutlu dizi tanımladık.
string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir"," Muğla","Manisa" }
};

// "GetUpperBound" ile bu çok boyutlu dizi içerisinde ki satır ve sütunları seçeriz. "0" ile ilk index yani satırı seçeriz.
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("******************");
}