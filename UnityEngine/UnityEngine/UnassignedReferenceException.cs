using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class UnassignedReferenceException : SystemException
{
    public UnassignedReferenceException();
    public UnassignedReferenceException(string message);
    protected UnassignedReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    public UnassignedReferenceException(string message, Exception innerException);

}

}
