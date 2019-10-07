using System;
using UnityEngine;

namespace UnityEngine
{

public class MissingComponentException : SystemException
{
    public MissingComponentException();
    public MissingComponentException(string message);
    public MissingComponentException(string message, Exception innerException);
    protected MissingComponentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
