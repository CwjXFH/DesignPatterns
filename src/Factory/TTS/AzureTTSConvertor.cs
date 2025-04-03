using Microsoft.Extensions.Logging;

namespace Factory.TTS;

internal class AzureTTSConvertor(ILogger<AzureTTSConvertor> logger) : ITTSConvertor
{
    public string Name => "AzureConvertor";

    public Task<TTSConvertResult> ConvertTextToSpeechAsync()
    {
        logger.LogInformation("call Azure tts service");
        return Task.FromResult(new TTSConvertResult { Success = true });
    }
}
