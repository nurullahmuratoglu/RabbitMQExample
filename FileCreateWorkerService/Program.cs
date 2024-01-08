using FileCreateWorkerService;
using FileCreateWorkerService.Models;
using FileCreateWorkerService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext,services) =>
    {
        services.AddSingleton<RabbitMQClientService>();
        
        services.AddDbContext<AdventureWorks2019Context>(options =>
        {
            options.UseSqlServer(hostContext.Configuration.GetConnectionString("SqlConnection"));

        });
        services.AddSingleton(sp => new ConnectionFactory() { Uri = new Uri(hostContext.Configuration.GetConnectionString("RabbitMQURL")), DispatchConsumersAsync = true });

        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
