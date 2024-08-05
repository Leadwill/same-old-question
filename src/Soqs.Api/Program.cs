var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseHttpsRedirection();

app.MapGet("/api/groups", () =>
{
    return new Group("1", "Leadwill Devs", [new GroupMember("1", "Test User", "/avatars/test.jpg")]);
})
.WithName("GetGroups")
.WithOpenApi();

app.Run();

record Group(string Id, string Name, GroupMember[] Members);
record GroupMember(string Id, string Name, string AvatarURL);
