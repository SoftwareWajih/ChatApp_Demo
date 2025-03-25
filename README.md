# AI Chat with Custom Data

This project is an AI chat application that demonstrates how to chat with custom data using an AI language model. Please note that this template is currently in an early preview stage. If you have feedback, please take a [brief survey](https://aka.ms/dotnet-chat-template-survey).

>[!NOTE]
> Before running this project you need to configure the API keys or endpoints for the providers you have chosen. See below for details specific to your choices.

# Configure the AI Model Provider
To use models hosted by GitHub Models, you will need to create a GitHub personal access token. The token should not have any scopes or permissions. See [Managing your personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens).

Configure your token for this project using .NET User Secrets:

1. In Visual Studio, right-click on your project in the Solution Explorer and select "Manage User Secrets".
2. This opens a `secrets.json` file where you can store your API keys without them being tracked in source control. Add the following key and value:

```json
{
   "GitHubModels:Token": "YOUR-TOKEN"
}
```

Learn more about [prototyping with AI models using GitHub Models](https://docs.github.com/github-models/prototyping-with-ai-models).

# [Consume Third Party APIs](./ChatApp_Demo/wwwroot/Documentation/readme.md)
- JSON Placeholder API
- Exchange Rate API