namespace TeamsLektion2;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        // Controller övning 9
        // builder.Services.AddSingleton<CounterService>();

        // Controller övning 10
        // builder.Services.AddSingleton<HistoryService>();

        // Service övning 2 och 3
        builder.Services.AddSingleton<ITodoService, TodoService>();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}
