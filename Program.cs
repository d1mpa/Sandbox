using ChatGPT.Net;
using ChatGPT.Net.DTO;
using ChatGPT.Net.Enums;

var chatGpt = new ChatGpt(new ChatGptConfig  
{  
    UseCache = true  
});
await chatGpt.WaitForReady();
var chatGptClient = await chatGpt.CreateClient(new ChatGptClientConfig
{
    SessionToken = "",  
    AccountType = AccountType.Free
});
var conversationId = "4d3016ad-8b53-4492-b24b-138bb45cb3cd";
var response = await chatGptClient.Ask("What is the weather like today?", conversationId);
Console.WriteLine(response);

await chatGptClient.ResetConversation(conversationId);

Console.WriteLine("Hello, World!");