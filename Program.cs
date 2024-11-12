/*using NLog;
string path = Directory.GetCurrentDirectory() + "//nlog.config";
// create instance of Logger
var logger = LogManager.Setup().LoadConfigurationFromFile(path).GetCurrentClassLogger();
logger.Info("Program started");
// Create and save a new Blog
Console.Write("Enter a name for a new Blog: ");
var name = Console.ReadLine();
var blog = new Blog { Name = name };
var db = new DataContext();
db.AddBlog(blog);
logger.Info("Blog added - {name}", name);
// Display all Blogs from the database
var query = db.Blogs.OrderBy(b => b.Name);
Console.WriteLine("All blogs in the database:");
foreach (var item in query)
{
  Console.WriteLine(item.Name);
}
logger.Info("Program ended");*/

using NLog;
//string path = Directory.GetCurrentDirectory() + "//nlog.config";
class Program {
    static void Main() {
       while(true){
Console.WriteLine("-1Display all blogs: ");
Console.WriteLine("-2add blog");
Console.WriteLine("-3Create Post ");
Console.WriteLine("-4Display posts ");

Console.WriteLine("-4 Display posts ");
switch(Console.ReadLine()){
    case "1":                  
break;
  case "2":                  
break;
  case "3":                  
break;
  case "4":                  
break;
    default:
    Console.WriteLine("Please try again");
break;


}



      }  }    
    }