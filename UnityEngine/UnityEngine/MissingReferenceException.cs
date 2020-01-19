using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class MissingReferenceException : SystemException
{
    public MissingReferenceException();
    public MissingReferenceException(string message);
    protected MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    public MissingReferenceException(string message, Exception innerException);

}

}
