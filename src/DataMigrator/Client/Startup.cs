using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SaaSDatabase.Models;
using Serilog;
using StandaloneDatabase.Models;

namespace Client
{
    public class Startup
    {
        private static IConfigurationRoot _configuration;


        public static IConfigurationRoot ConfigureServices(IServiceCollection services)
        {

            // Build configuration
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Add dbContext
            services.AddDbContext<TilesCornerDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("SourceConnection")));
            services.AddDbContext<TilesPadDBContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DestinationConnection")));


            // Add logging
            services.AddSingleton(new LoggerFactory().AddSerilog());
            services.AddLogging();

            // Initialize serilog logger
            Log.Logger = new LoggerConfiguration()
                //.WriteTo.MSSqlServer(configuration.GetConnectionString("LoggingSQLServer"), "logs")
                //.WriteTo.Email(emailConnection, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error, mailSubject: "Tiles Pad Data Migrator Error")
                .WriteTo.Console(Serilog.Events.LogEventLevel.Information)
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .CreateLogger();

            // Add access to generic IConfigurationRoot
            services.AddSingleton<IConfigurationRoot>(_configuration);


            return _configuration;
        }
    }
}