namespace ApiKeyAuthentication.Authentication;

public class ApiKeyValidator : IApiKeyValidator
{
    public bool IsValid(string apiKey)
    {
        if (apiKey == "facu") return true;
        return false;
    }
}