namespace Idp.Lib.Tools.Handlers;

using Idp.Lib.Tools.Queries;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

public class GetResourceGroupsHandler : IRequestHandler<GetResourceGroupsQuery, List<string>>
{
    public Task<List<string>> Handle(GetResourceGroupsQuery request, CancellationToken cancellationToken)
    {
        // Placeholder: Logic to query Azure resource groups matching the pattern
        // Return a list of resource group names matching the pattern
        // For now, returning a dummy list
        return Task.FromResult(new List<string> { "compute-rg-1", "compute-rg-2" });
    }
}
