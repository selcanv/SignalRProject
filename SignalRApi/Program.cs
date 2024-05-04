using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.EntityFramework;
using SignalRApi.Hubs;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt=>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        //hangi kaynaklara izin vericek
        //gelen herhangi bir baþlýða,metoda,kaynaða,kimliðe izin versin
        //Cors politikasý olarak geçiyor
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();


    });
});
builder.Services.AddSignalR();
builder.Services.AddDbContext<SignalRContext>();
//Automapper için kullanýlan registration configürasyonu
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//BURADA DÝYORUM KÝ IAboutService  gördüðünde AboutManager sýnýfýný çaðýr
builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IAboutDal,EfAboutDal>();
//birbirinden kalýtým alan ve birbiriyle iliþkili olan sýnýflarýmý ve interfacelerimi burada çaðýrmýþ oldum
//bunu bütün sýnýflarým için yapýcam
//bunlarý businessa taþýcaz. Businesse servis sýnýfý yazdýðýmda bunlarý program.cs den businesse ekle

//booking için baþla
builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();

//Category için builder geçiyorum
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

//Contact için builder geçiyorum
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

//Discount için builder geçiyorum
builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EfDiscountDal>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");
//endpoint kýsmý

app.Run();
