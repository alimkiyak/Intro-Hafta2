using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message = "krediler";
int term = 12;
double amount = 10000.5;


// dogru - yanlis secimler true ya da false degerlerini alacak
// isAuthenticated kisi sisteme girdi mi 

//variable - degisken isimleri camelCase yazılır


Console.WriteLine(message);
Console.WriteLine(term);


bool isAuthenticated = true;
//if (isAuthenticated==true)
if (isAuthenticated)
{
    Console.WriteLine("sisteme giriş yapıldı.");
}
else
{
    Console.WriteLine("sisteme giriş yapılmadı");
}

//string kredi1 = "kredi1";
//string kredi2 = "kredi2";
//string kredi3 = "kredi3";
//string kredi4 = "kredi4";
//string kredi5 = "kredi5";

string[] loans = { "kredi1", "kredi2", "kredi3" }; //veritabanından gelecek veri
                                                   //string[] loans2 = new string[5];
                                                   //loans2[0] = "kredi1";


//start     condition     increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)

{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti.");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1234567890";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "87654321";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123";


CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "425";
customer3.TaxNumber = "45163463642";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "16464261";
customer4.TaxNumber = "7875958454";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "ankara", "izmir", "istanbul" };
string[] cities2 = { "bursa", "bolu", "erzurum" };

cities2 = cities1;
cities1[0] = "adana";
Console.WriteLine(cities2[0]);
