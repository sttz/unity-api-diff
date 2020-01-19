using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class MissingComponentException : SystemException
{
    public MissingComponentException();
    public MissingComponentException(string message);
    protected MissingComponentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    public MissingComponentException(string message, Exception innerException);

}

}
