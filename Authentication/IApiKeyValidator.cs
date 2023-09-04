namespace ApiKeyAuthentication.Authentication;

public interface IApiKeyValidator
{
    bool IsValid(string apiKey);
}