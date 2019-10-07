using System;
using UnityEngine;

namespace UnityEngine
{

public class MissingReferenceException : SystemException
{
    public MissingReferenceException();
    public MissingReferenceException(string message);
    public MissingReferenceException(string message, Exception innerException);
    protected MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
