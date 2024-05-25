using Idp.Lib.Tools.Commands;
using Idp.Lib.Tools.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetResourceGroupsQuery).Assembly));

// Build the service provider
var serviceProvider = services.BuildServiceProvider();

// Resolve IMediator
var mediator = serviceProvider.GetRequiredService<IMediator>();

// Example usage
var resourceGroups = await mediator.Send(new GetResourceGroupsQuery("compute-rg-*"));

foreach (var resourceGroup in resourceGroups)
{
    await mediator.Send(new TagResourceGroupsCommand(resourceGroup, "expiresOn", DateTime.UtcNow.AddDays(7).ToString("yyyy-MM-dd")));
}

Console.WriteLine("Commands issued.");