// --------------- 1. GÜN ------------------------------

// variables --> camelCase
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

string message1 = "Krediler";
int term = 12;
double amount = 100000;
bool isAuthenticated = false;

// condition
if(isAuthenticated) // true ise 
{
    Console.WriteLine("Hoşgeldin Feyza");
}
else  // false ise
{
    Console.WriteLine("Sisteme Giriş Yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8";
//course1.Price = 0;

//Course course2 = new Course();
//course2.Id = 1;
//course2.Name = "Java";
//course2.Description = "Java 17";
//course2.Price = 10.5;

//Course course3 = new Course();
//course3.Id = 1;
//course3.Name = "Python";
//course3.Description = "Ptyhon xxx";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3};
//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

// veri kaynağından geldi
CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

// --------------- 2. GÜN ------------------------------

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678901";
customer1.FirstName = "Feyza Nur";
customer1.LastName = "Bakır";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";


// Value Types => Stack Memory'de tutulur : int, decimal, float, double, bool, char, byte, short, long
int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 100;
Console.WriteLine(number1);


// Reference Types  => Heap Memory'de tutulur : array, class, interface, string 
string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
cities1 = cities2;
cities2[0] = "Niğde";
Console.WriteLine(cities1[0]);

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}