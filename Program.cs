using Garage;
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



Zero fxs = new Zero
{
    MainColor = "Black"
};
Tesla modelS = new Tesla
{
    MainColor = "Blue"
};
Cessna mx410 = new Cessna
{
    MainColor = "Purple"
};
Ram tradesman = new Ram
{
    MainColor = "Burgundy"
};

fxs.Drive();
fxs.Turn("right");
fxs.Stop();

modelS.Drive();
modelS.Turn("left");
modelS.Stop();

mx410.Drive();
mx410.Turn("right");
mx410.Stop();

tradesman.Drive();
tradesman.Turn("left");
tradesman.Stop();



app.Run();