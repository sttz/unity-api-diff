using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AndroidJavaException : Exception
{
    public string StackTrace { get; }

}

}