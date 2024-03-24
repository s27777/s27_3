using System.Runtime.Serialization;

namespace ConsoleApp1;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
        Console.WriteLine("message");
    }

    protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    /*public OverfillException(string? message) : base(message)
    {
    }*/
}