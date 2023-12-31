﻿using AutoMapper;
using AVRO_CONSTRUKTİON_MMC.DAL;
using AVRO_CONSTRUKTİON_MMC.Helpers;
using AVRO_CONSTRUKTİON_MMC.Helpers.Implementations;
using AVRO_CONSTRUKTİON_MMC.Helpers.Interfaces;
using AVRO_CONSTRUKTİON_MMC.Models;
using AVRO_CONSTRUKTİON_MMC.Profiles;
using AVRO_CONSTRUKTİON_MMC.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//       CONTENT
// ---------------------
// 1 Database
// 2 Mapper
// 3 Custom Services
// 4 Identity
// 5 Redirect Admin login
// 6 Email Configuration

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
builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddSingleton<IPaginator, Paginator>();
builder.Services.AddScoped<ILayoutService, LayoutService>();
//=========================
// 4 Identity
//=========================
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequiredLength = 8;
    opt.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AvroConstructionDbContext>();

//=========================
// 5 Redirect Admin login
//=========================

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Events.OnRedirectToLogin = options.Events.OnRedirectToAccessDenied = context =>
    {
        if (context.HttpContext.Request.Path.Value.StartsWith("/admin") || context.HttpContext.Request.Path.Value.StartsWith("/Admin"))
        {
            var redirectPath = new Uri(context.RedirectUri);
            context.Response.Redirect("/admin/account/login" + redirectPath.Query);
        }
        else
        {
            var redirectPath = new Uri(context.RedirectUri);
            context.Response.Redirect("/account/login" + redirectPath.Query);
        }
        return Task.CompletedTask;
    };


});

//=========================
// 6 Email Configuration
//=========================

var configuration = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton<EmailConfiguration>(configuration);





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

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
