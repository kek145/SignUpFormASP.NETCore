using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseStaticFiles();
app.Run(async (context) =>
{
    context.Response.ContentType= "text/html; charset=utf-8";
    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        var firstname = form["firstname"];
        var lastname = form["lastname"];
        var fullname = form["fullname"];
        var email = form["email"];
        var password = form["password"];

        using (ApplicationContext db = new ApplicationContext())
        {
            Users? users = new Users { FirstName = firstname, LastName = lastname, FullName = fullname, Email = email, Password = password };
            db?.AddAsync(users);
            db?.SaveChangesAsync();
        }
        await context.Response.SendFileAsync("wwwroot/html/SignIn.html");
    }
    else if (context.Request.Path == "/postuser1")
    {
        var form = context.Request.Form;
        var email = form["email"];
        var password = form["password"];

        using (ApplicationContext db = new ApplicationContext())
        {
            var user1 = db.Users.Where(x => x.Email == email.ToString() && x.Password == password.ToString()).FirstOrDefault();
            if (user1 != null)
                await context.Response.WriteAsync("<div><p>Accessfull</p></div>");
            else await context.Response.WriteAsync("<div><p>Error</p></div>");
        }
    }
    else
    {
        await context.Response.SendFileAsync("wwwroot/html/index.html");
    }
});


app.Run();
