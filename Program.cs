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
          Blogs();               
break;

  case "2":   
  AddingBlog();               
break;
  case "3": 
    CPost();                 
break;
  case "4":  
   DPost();                
break;
    default:
    Console.WriteLine("Please try again");
break;


}




      
      } 
      
      
      
       }
       static void Blogs(){
var db = new DataContext();
var query = db.Blogs.OrderBy(b =>  b.Name);
foreach (var item in query)
 {
      Console.WriteLine(item.Name); }
}
static void AddingBlog(){
 Console.Write("Enter a name for a new Blog: ");
 var name = Console.ReadLine();
 if (string.IsNullOrWhiteSpace(name))
{
 Console.WriteLine("Write something .");
 return; }
 var db = new DataContext();
var blog = new Blog { Name = name };
 db.Blogs.Add(blog);
db.SaveChanges();
 Console.WriteLine("Blog added - {0}", name);

}
  static void CPost()
 {
 using(var context = new DataContext())
 {
var blogs = context.Blogs.ToList();
if (!blogs.Any())
 {
 return;
  }
 blogs.ForEach(b => Console.WriteLine($"Blog ID: {b.BlogId}, Name: {b.Name}"));
 Console.Write("Select Id blog: ");
 if (!int.TryParse(Console.ReadLine(), out int blogId) || !context.Blogs.Any(b => b.BlogId == blogId))
 {
 Console.WriteLine("Invalid.");   
              return;
}

Console.Write("Enter post title: ");
var title = Console.ReadLine();
if (string.IsNullOrWhiteSpace(title))
 {
 Console.WriteLine("it nees a titile.");
return;}
Console.Write("Enter post content : ");
var content = Console.ReadLine();
context.Posts.Add(new Post { BlogId = blogId, Title = title, Content = content });
context.SaveChanges();
Console.WriteLine("Post save.");
 }
 }
 static void DPost()
{
using var context = new DataContext();
     Console.Write("Enter Blog ID to see posts: ");if (!int.TryParse(Console.ReadLine(), out int blogId))
{
Console.WriteLine("Invalid Blog ID. Please enter a valid number.");
  return; }
 var posts = context.Posts.Where(p => p.BlogId == blogId).ToList();
if (posts.Count == 0)
 {Console.WriteLine("No posts found.");
   return;
    }
foreach (var post in posts)
{
Console.WriteLine($"Post ID: {post.PostId}, Title: {post.Title}");
Console.WriteLine($"Content: {post.Content}");
}
 
 }
     
      
          
    }