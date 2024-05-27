using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using practicaaws.Repositories;
using practicaaws.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace practicaaws;

public class Functions
{
    private PelisRepository repo;
    public Functions(PelisRepository repo)
    {
        this.repo = repo;
    }



    [LambdaFunction]

    [RestApi(LambdaHttpMethod.Get, "/")]

    public async Task<IHttpResult> Get(ILambdaContext context)

    {

        context.Logger.LogInformation("Handling the 'Get' Request");

        List<Peli> pelis =

            await this.repo.GetPelisAsync();

        return HttpResults.Ok(pelis);

    }


    [LambdaFunction]

    [RestApi(LambdaHttpMethod.Get, "/find/{actor}")]

    public async Task<IHttpResult> Find(string actor, ILambdaContext context)

    {

        context.Logger.LogInformation("Handling the 'Find' Request");

        List<Peli> pelis =

           await this.repo.GetPelisActoresAsync(actor);

        return HttpResults.Ok(pelis);




    }
}
