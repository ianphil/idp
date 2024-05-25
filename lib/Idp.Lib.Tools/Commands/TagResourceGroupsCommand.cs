namespace Idp.Lib.Tools.Commands;

using MediatR;

public class TagResourceGroupsCommand : IRequest
{
    public string ResourceGroupName { get; }
    public string TagName { get; }
    public string TagValue { get; }

    public TagResourceGroupsCommand(string resourceGroupName, string tagName, string tagValue)
    {
        ResourceGroupName = resourceGroupName;
        TagName = tagName;
        TagValue = tagValue;
    }
}
