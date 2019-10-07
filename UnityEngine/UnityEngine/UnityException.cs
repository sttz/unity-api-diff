using System;
using UnityEngine;

namespace UnityEngine
{

public class UnityException : SystemException
{
    public UnityException();
    public UnityException(string message);
    public UnityException(string message, Exception innerException);
    protected UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
