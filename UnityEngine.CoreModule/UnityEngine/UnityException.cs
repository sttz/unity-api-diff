using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class UnityException : SystemException
{
    public UnityException();
    public UnityException(string message);
    protected UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    public UnityException(string message, Exception innerException);

}

}
