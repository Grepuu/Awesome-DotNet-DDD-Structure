using GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Repositories;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Services.DtoServices;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Services.SaveManagers;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Services.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GrepuuTemplates.NetApp.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services
    .AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlite(connectionString);
    });

builder.Services
    .AddDatabaseDeveloperPageExceptionFilter();

builder.Services
    .AddDefaultIdentity<IdentityUser>(options => {
        options.SignIn.RequireConfirmedAccount = true;
    }).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services
    .AddControllersWithViews()
    .AddRazorRuntimeCompilation();

builder.Services.AddTransient<IArticlesPublicProvider, ArticlesPublicProvider>();
builder.Services.AddTransient<IArticlesManagementProvider, ArticlesManagementProvider>();

builder.Services.AddTransient<IArticleService, ArticleService>();

builder.Services.AddTransient<IArticlesPublicValidator, ArticlesPublicValidator>();
builder.Services.AddTransient<IArticlesManagementValidator, ArticlesManagementValidator>();

builder.Services.AddTransient<IArticleSaveManager, ArticleSaveManager>();

builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
builder.Services.AddTransient<IArticleContentRepository, ArticleContentRepository>();
builder.Services.AddTransient<IArticleAuthorRepository, ArticleAuthorRepository>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();