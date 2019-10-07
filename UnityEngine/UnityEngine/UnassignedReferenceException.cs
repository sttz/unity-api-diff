using System;
using UnityEngine;

namespace UnityEngine
{

public class UnassignedReferenceException : SystemException
{
    public UnassignedReferenceException();
    public UnassignedReferenceException(string message);
    public UnassignedReferenceException(string message, Exception innerException);
    protected UnassignedReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
