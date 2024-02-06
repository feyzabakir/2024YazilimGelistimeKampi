
// variables --> camelCase
using Intro.Business;
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
CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}