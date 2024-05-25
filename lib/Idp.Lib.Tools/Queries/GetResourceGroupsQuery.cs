namespace Idp.Lib.Tools.Queries;

using MediatR;

public class GetResourceGroupsQuery : IRequest<List<string>>
{
    public string Pattern { get; }

    public GetResourceGroupsQuery(string pattern)
    {
        Pattern = pattern;
    }
}
