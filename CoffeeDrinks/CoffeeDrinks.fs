namespace CoffeeDrinks

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module CoffeeDrinks =

    type coffeeDrink = 
        {
            name : string
        }

    let result = 
        [{
            name = "French Press"
        }]


    [<FunctionName("CoffeeDrinks")>]
    let Run([<HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)>]  
        req: HttpRequest, log: ILogger) =

            new JsonResult(result)