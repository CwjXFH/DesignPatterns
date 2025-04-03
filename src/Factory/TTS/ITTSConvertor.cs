namespace Factory.TTS;

public interface ITTSConvertor
{
    string Name { get; }

    Task<TTSConvertResult> ConvertTextToSpeechAsync();
}
