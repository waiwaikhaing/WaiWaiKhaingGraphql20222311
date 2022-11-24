using LatHtaukBayDin20221120GraphQL.Api.Controllers;
using WaiWaiKhaingGraphql20222311.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient();
//builder.Services.AddGraphQLServer().AddQueryType<MinTheinKhaQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<BlogQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<CategoryQuery>();
builder.Services.AddGraphQLServer().AddQueryType<BlogConstantQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
