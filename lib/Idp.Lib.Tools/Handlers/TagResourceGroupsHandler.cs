namespace Idp.Lib.Tools.Handlers;

using System.Threading;
using System.Threading.Tasks;
using Idp.Lib.Tools.Commands;
using MediatR;

public class TagResourceGroupsHandler : IRequestHandler<TagResourceGroupsCommand>
{
    public Task Handle(TagResourceGroupsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
