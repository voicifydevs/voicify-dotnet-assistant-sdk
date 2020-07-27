# Introduction 

This project includes models and APIs for communicating with the Voicify Assistant APIs at https://assistant.voicify.com

# Getting Started

You can install this package from NuGet:

```
Install-Package Voicify.Sdk.Assistant
```

Then you can pull in the namespace:

```csharp
using Voicify.Sdk.Assistant.Api
```

Each service has its own API class to use in order to make requests against it. These are also typed against `interfaces` so you can optionally inject them or mock them during testing.


This SDK has the ability to create and handle requests against:
- Alexa Skills
- Google Actions (with Dialogflow)
- Dialogflow Agents
- Bixby Capsules
- Cortana Skills
- Azure bots
- Custom assistants and bots

So whether you are using a custom Alexa Skill that makes requests to your Voicify app after processing existing requests or building your own assistant from scratch, this SDK has all the details you need as long as you have a Voicify app to make requests against and the `ApplicationId` and `ApplicationSecret` required to make requests.


## Making Requests

To make requests, create an instance of the API you need, then call the appropriate method (Usually `HandleRequest`, although Bixby has many other endpoints to use.)

For example, we can make a request to the Voicify Custom Assistant API with just the text from the user:


```csharp

var customAssistantApi = new CustomAssistantApi(new Configuration
{
    BasePath = $"https://assistant.voicify.com"
});

var device = new CustomAssistantDevice(
    id: Guid.NewGuid().ToString(),
    name: "Voicify Sample App",
    supportsDisplayText: true,
    supportsTextInput: true
);
var user = new CustomAssistantUser(
    id: Guid.NewGuid().ToString(),
    name: "Sample User"
);

var input = Console.ReadLine(); // or wherever else you get the input from
var appId = "your-voicify-app-id";
var appSecret = "your-voicify-app-secret";

response = await customAssistantApi.HandleRequestAsync(appId, appSecret, new CustomAssistantRequestBody(
    requestId: Guid.NewGuid().ToString(),
    device: device,
    user: user,
    context: CreateContext(input)));

Console.WriteLine(response.OutputSpeech); // you can pull out all the different properties from the response and use how you'd like.

```

For the other APIs like Alexa, Dialogflow, and Bot Service, you can also use their native SDKs since the endpoints for those methods take the direct fulfillment calls.

For example, sending requests to the `AlexaApi` could also use the `Alexa.NET` sdk.


Voicify Partners and Customers can also check out the extended documentation and details at https://support.voicify.com

# Contributing

The Voicify core development team owns this repo and NuGet package, but all Voicify developers are welcome to contribute changes. Before contributing, please create an issue that you can track your PRs against and be sure there is not already a PR open for it.

# Build and Test

There are some steps to autogenerate the C# Clients and APIs from the swagger API models that Voicify outputs.

## Generate Api Clients from Swagger

First, make sure you get the latest version of `Voicify.Sdk.Core.Models` NuGet.

Then, get the latest APIs by generating from the latest models and https://assistant.voicify.com:

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://assistant.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dapis -DsupportingFiles -DmodelTests=false -o ../../src/Voicify.Sdk.Assistant/Voicify.Sdk.Assistant/Generated
```


## Generate Tests from Swagger


```
java -jar swagger-codegen-cli.jar generate -i http://assistant.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -DapiTests=true -o ../../src/Voicify.Sdk.Assistant/Voicify.Sdk.Assistant.Tests/Generated
```

Delete any duplicated stuff that is created in the test project

Then find and replace the expected models namespace everywhere.

Find: using Voicify.Sdk.Assistant.Model;
Replace with: using Voicify.Sdk.Core.Models.Model;

Then do any other replacements or fixes required in order to fix the build

Also be wary of generated tests overriding any that are explicitly setup. You may need to pull the accepted tests that are enabled out of the `Generated` folder.

Also, the generator will generate extra .csproj and .sln files. Be sure to delete those before pushing changes.