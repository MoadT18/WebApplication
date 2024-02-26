namespace WebApplication
{
    using Microsoft.AspNetCore.Builder; // Add this import

    public class Program
    {
        public static void Main(string[] args)
        {

                var builder = WebApplication.CreateBuilder(args);
                var startup = new Startup(builder.Configuration); 
                startup.ConfigureServices(builder.Services); 

                builder.Services.AddControllers();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
                builder.Services.AddControllers();

                var app = builder.Build();

                app.UseCors("MyPolicy");
                app.UseHttpsRedirection();

                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseAuthorization();

                app.MapControllers();

                app.Run();
            }
        

      
    }
}
