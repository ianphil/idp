namespace Idp.Lib.Tools.Tests;

using Idp.Lib.Tools;

public class AzureServiceTests
{
    [Fact]
    public void Test_MakeResourceGroupResourceIdentifier()
    {
        var azSvc = new AzureService("subId");

        var expected = $"/subscriptions/subId/resourceGroups/rg";
        var actual = azSvc.MakeResourceGroupResourceIdentifier("rg");

        Assert.Equal(expected, actual);
    }
}