using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PartyLifeCycleSample;

[ApiController]
[Route("api/[controller]")]
public class PartyLifeCycleController : Controller
{
    
    private readonly ILogger<PartyLifeCycleController> _logger;
    private string _baseUrl = "https://virtserver.swaggerhub.com/BIAN-3/PartyLifecycleManagement/10.0.0/";
    private readonly IHttpClientFactory _httpClientFactory;

    public PartyLifeCycleController(ILogger<PartyLifeCycleController> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        }
    
    public string BaseUrl
    {
        get { return _baseUrl; }
        set { _baseUrl = value; }
    }

    [HttpGet]
    public async Task<string> Get(string partylifecyclemanagementId)
    {
        if (partylifecyclemanagementId == null)
            throw new System.ArgumentNullException("partylifecyclemanagementId");

        var urlBuilder = new System.Text.StringBuilder();
        urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/PartyLifecycleManagement/{partylifecyclemanagementId}/Retrieve");
        urlBuilder.Replace("{partylifecyclemanagementId}", System.Uri.EscapeDataString(ConvertToString(partylifecyclemanagementId, System.Globalization.CultureInfo.InvariantCulture)));
        var url = urlBuilder.ToString();
        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }

    [HttpPost]
    public async Task<InitiatePartyRelationshipProcedureResponse> Post(PartyRelationshipProcedure body,  System.Threading.CancellationToken cancellationToken)
    {
        Console.WriteLine("Inside Post Method");
        /*try
        {*/
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/PartyLifecycleManagement/Initiate");
            var url = urlBuilder.ToString();
            
            var request = new System.Net.Http.HttpRequestMessage();
            request.Method = new System.Net.Http.HttpMethod("POST");
            request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
            request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
            
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            
            //var objectResponse_ = await Read<InitiatePartyRelationshipProcedureResponse>(response_, headers_, cancellationToken).ConfigureAwait(false);
            //var responseText = response.Content.ReadAsStringAsync().ConfigureAwait(false);

            /*if (response.Content is object && response.Content.Headers.ContentType.MediaType == "application/json")
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                using var streamReader = new StreamReader(contentStream);
                using var jsonReader = new JsonTextReader(streamReader);

                JsonSerializerSettings s = new JsonSerializerSettings();
                s

            }*/

           
        /*}
        catch (Exception)
        {
            _logger.LogError("error in fetching response");
        }*/
        return await response.Content.ReadFromJsonAsync<InitiatePartyRelationshipProcedureResponse>();
    }
    
   // protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }
        
            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
        
                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool) 
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
    }