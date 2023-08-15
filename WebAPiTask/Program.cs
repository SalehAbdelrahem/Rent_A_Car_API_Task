using Application.Contracts;
using Application.Contracts.Cars;
using Application.Contracts.Nationalities;
using Application.Features.Brands.Queries.GetBrandDetails;
using DBContext;
using Domain;
using InfraStructure;
using InfraStructure.BookingDetails;
using InfraStructure.BookingMasters;
using InfraStructure.Cars;
using InfraStructure.Nationalities;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddIdentity<AppUser, Role>(options =>
{
    //options.SignIn.RequireConfirmedEmail = true;
}).AddEntityFrameworkStores<AppDBContext>()
  .AddDefaultTokenProviders();

builder.Services.AddMediatR(config =>
{ config.RegisterServicesFromAssembly(typeof(GetBrandDetailsQuery).Assembly); }
);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





///////inject objects
///
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<INationalitiyRepository, NationalitiyRepository>();
builder.Services.AddScoped<IBookingDetailRepository, BookingDetailRepository>();
builder.Services.AddScoped<IBookingMasterRepository, BookingMasterRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
//builder.Services.AddScoped<IMasterDetailRepository, MasterDetailRepository>();

builder.Services.AddCors();


var app = builder.Build();

app.UseExceptionHandler(options =>
{
    options.Run(
        async context =>
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var ex = context.Features.Get<IExceptionHandlerFeature>();
            if (ex != null)
            {

                await context.Response.WriteAsync(ex.Error.Message);
            }

        }
        );
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options =>
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
    //.AllowCredentials();

});
app.UseAuthorization();

app.MapControllers();

app.Run();
