namespace Factory.TTS;

internal class TTSConvertorProvider(IEnumerable<ITTSConvertor> convertors) : ITTSConvertorProvider
{
    private readonly IReadOnlyList<ITTSConvertor> _convertors = convertors.ToList();

    // Simple factory
    public ITTSConvertor GetConvertor(string convertorName)
    {
        var tts = _convertors.FirstOrDefault(s => s.Name == convertorName);
        if (tts == null)
        {
            throw new TTSConvertorNotFoundException(convertorName, "Cannot find convertor");
        }

        return tts;
    }
}
