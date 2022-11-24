using LatHtaukBayDin20221120GraphQL.Api.Controllers;
using WaiWaiKhaingGraphql20222311.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient();
//builder.Services.AddGraphQLServer().AddQueryType<MinTheinKhaQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<BlogQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<CategoryQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<BlogConstantQuery>();
//builder.Services.AddGraphQLServer().AddQueryType<>();
builder.Services.AddGraphQLServer().AddQueryType(q => q.Name("Query"))
    .AddType<CategoryQuery>()
    .AddType<MinTheinKhaQuery>()
    .AddType<BlogQuery>()
    .AddType<BlogConstantQuery>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting();
app.UseWebSockets();
//app.MapGraphQL();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});
//app.MapGraphQL("/graphql");
app.Run();
