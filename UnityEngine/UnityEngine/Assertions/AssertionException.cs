using System;
using UnityEngine;

namespace UnityEngine.Assertions
{

public class AssertionException : Exception
{
    public string Message { get; }

    public AssertionException(string message, string userMessage);

}

}
