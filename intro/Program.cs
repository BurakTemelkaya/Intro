// See https://aka.ms/new-console-template for more information

using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

//öylesine yaptım Engin hoca dalga geçmişti bende yapıyım dedim :D
static void AsalSayi()
{
    int sayi = 0;
    bool isInt = false;
    while (!isInt)
    {
        Console.Clear();
        Console.Write("Asal sayı giriniz.");
        isInt = int.TryParse(Console.ReadLine(), out sayi);
        if (isInt)
        {
            break;
        }
        else
        {
            Console.WriteLine("Lütfen sadece tam sayı giriniz.");
            Console.ReadKey();
        }
    }

    bool asalMi = true;
    int bolunenSayi = 0;
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            asalMi = false;
            bolunenSayi = i;
            break;
        }
    }
    if (!asalMi)
        Console.WriteLine("Sayı asal değildir. İlk bölünen sayı {0}", bolunenSayi);
    else
        Console.WriteLine("Sayı asaldır");
}

//Kendim ekledim kamp ile alakası yok.
static void InfiniteNumberTotal()
{
    double total = 0;
    while (true)
    {
        double last = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Toplam:" + total);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Toplanacak sayıyı giriniz: ");
        bool isDouble = double.TryParse(Console.ReadLine(), out last);
        if (isDouble)
        {
            total += last;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lütfen sadece sayı giriniz.");
            Console.ReadKey();
        }
    } 
}

static void Loans()
{
    string[] loans = { "kredi1", "kredi2", "kredi3", "kredi4", "kredi5", "kredi6" };
    //string[] loans2 = new string[6];
    //loans2[2] = "test";

    for (int i = 0; i < loans.Length; i++)
    {
        Console.WriteLine(loans[i]);
    }
}

static void Courses()
{
    InduvidualCustomer customer1 = new();
    customer1.Id = 1;
    customer1.NationalIdentity = "12345678910";
    customer1.FirstName = "Burak";
    customer1.LastName = "Temelkaya";
    customer1.CustomerNumber = "1235653456";

    InduvidualCustomer customer2 = new();
    customer2.Id = 2;
    customer2.NationalIdentity = "12345678911";
    customer2.FirstName = "Özgür";
    customer2.LastName = "Atılgan";
    customer2.CustomerNumber = "1235653457";

    CorporateCustomer customer3 = new();
    customer3.Id = 3;
    customer3.Name = "Kodlamaio";
    customer3.CustomerNumber = "654779";
    customer3.TaxNumber = "9876543210";

    CorporateCustomer customer4 = new();
    customer4.Id = 4;
    customer4.Name = "Abc";
    customer4.CustomerNumber = "654779";
    customer4.TaxNumber = "12345675231";

    BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
    foreach (BaseCustomer customer in customers)
    {
        Console.WriteLine(customer.Id);
    }
}

CourseManager courseManager = new(new DapperCourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

