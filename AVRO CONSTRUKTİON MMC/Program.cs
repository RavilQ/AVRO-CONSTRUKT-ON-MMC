using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.Profiles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//       CONTENT
// ---------------------
// 1 Database
// 2 Mapper
// 3 Custom Services
// 4 Identity

builder.Services.AddControllersWithViews();




//=========================
// 1 Database
//=========================

//builder.Services.AddDbContext<AvroConstructionDbContext>(opt => { opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")); });
builder.Services.AddDbContext<AvroConstructionDbContext>(opt => { opt.UseSqlServer(builder.Configuration.GetConnectionString("Tahir")); });


//=========================
// 2 Mapper
//=========================
builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AdminMapper());
}).CreateMapper());


//========================= 
// 3 Custom Services
//=========================

builder.Services.AddSingleton<IFileManager, FileManager>();

//=========================
// 4 Identity
//=========================
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequiredLength = 8;
    opt.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AvroConstructionDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
