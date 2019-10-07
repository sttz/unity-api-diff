using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AndroidJavaException : Exception
{
    public string StackTrace { get; }

}

}
