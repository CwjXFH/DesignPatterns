namespace Factory.TTS;

public class TTSException : Exception
{
    public TTSException(string message) : base(message) { }
    public TTSException(string message, Exception innerException) : base(message, innerException) { }
}

public class TTSConvertorNotFoundException : TTSException
{
    private readonly string _convertName;

    public TTSConvertorNotFoundException(string convertorName, string message) : base(message)
    {
        _convertName = convertorName;
    }

    public override string Message => $"{base.Message} {_convertName}";
}
