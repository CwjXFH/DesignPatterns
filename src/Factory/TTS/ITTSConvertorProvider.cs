namespace Factory.TTS;

public interface ITTSConvertorProvider
{
    ITTSConvertor GetConvertor(string convertorName);
}
