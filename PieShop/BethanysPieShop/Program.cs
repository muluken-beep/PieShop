var builder = WebApplication.CreateBuilder(args);
//makes sure that the application takes a look at the appsettings.json
//loads the default log settings
//set up iis integration
//www for static files
//access to collection services

builder.Services.AddControllersWithViews(); 
//makes sure that the application knows about MVC


var app = builder.Build();

app.UseStaticFiles();
//configured to look for static files
// in the www root and short circuits requests

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//diagnostic middleware component
//might contain sensitive info

app.MapDefaultControllerRoute();
//end point middleware
//set defaults used in mvc to the views
//to make sure we see our views

app.Run();
