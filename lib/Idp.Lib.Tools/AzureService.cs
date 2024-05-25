namespace Idp.Lib.Tools;

using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

public class AzureService
{
    private readonly string _subscriptionId;
    private readonly DefaultAzureCredential _credential;
    private readonly ArmClient _armClient;

    public AzureService(string subscriptionId)
    {
        _subscriptionId = subscriptionId;
        _credential = new DefaultAzureCredential();
        _armClient = new ArmClient(_credential, _subscriptionId);
    }

    public ResourceGroupResource GetResourceGroup(string resourceGroupName)
    {
        // Construct the resource identifier
        var resourceId = MakeResourceGroupResourceIdentifier(resourceGroupName);
        return _armClient.GetResourceGroupResource(resourceId);
    }

    public ResourceIdentifier MakeResourceGroupResourceIdentifier(string resourceGroupName)
    {
        return new ResourceIdentifier($"/subscriptions/{_subscriptionId}/resourceGroups/{resourceGroupName}");
    }
}
