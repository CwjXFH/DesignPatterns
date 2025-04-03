using Microsoft.Extensions.Logging;

namespace Factory.TTS;

internal class HuaWeiTTSConvertor(ILogger<HuaWeiTTSConvertor> logger) : ITTSConvertor
{
    public string Name => "HuaWeiConvertor";

    public Task<TTSConvertResult> ConvertTextToSpeechAsync()
    {
        logger.LogInformation("call HuaWei tts service");
        return Task.FromResult(new TTSConvertResult { Success = true });
    }
}
