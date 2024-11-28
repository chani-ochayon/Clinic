using ClinicProject;
using ClinicProject.Data;
using ClinicProject.Service;
using ClinicProject.Core.Services;
using ClinicProject.Core.Repositories;
using ClinicProject.Data.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddScoped<IDoctorService, DoctorServise>();
builder.Services.AddScoped<IDoctorRepositories, DoctorRepositories>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientRepositories, PatientRepositories>();

builder.Services.AddScoped<IRoutesRepositories, RoutesRepositories>();
builder.Services.AddScoped<IRoutesService, RoutesService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(policy);

app.MapControllers();

app.Run();
