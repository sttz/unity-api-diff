using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Assertions
{

public class AssertionException : Exception
{
    public string Message { get; }

    public AssertionException(string message, string userMessage);

}

}
