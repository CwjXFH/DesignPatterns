using Factory.TTS;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var services = new ServiceCollection();
services
    .AddLogging(builder => builder.AddConsole())
    .AddSingleton<ITTSConvertorProvider, TTSConvertorProvider>()
    .AddSingleton<ITTSConvertor, AzureTTSConvertor>()
    .AddSingleton<ITTSConvertor, HuaWeiTTSConvertor>();
await using var provider = services.BuildServiceProvider();
var ttsConvertorProvider = provider.GetRequiredService<ITTSConvertorProvider>();

// TTS: Text to Speech
const string convertorName = "HuaWeiConvertor"; // "AzureConvertor"
var convertor = ttsConvertorProvider.GetConvertor(convertorName);
var convertResult = await convertor.ConvertTextToSpeechAsync();
Console.WriteLine(convertResult);
