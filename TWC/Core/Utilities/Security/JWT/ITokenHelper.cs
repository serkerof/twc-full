using Microsoft.Azure.Documents;
using NuGet.Protocol.Plugins;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(
            User user, List<OperationClaim> operationClaims);
    }
}