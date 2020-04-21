using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class Message
{
    public string message { get; }
    public Severity severity { get; }

    public void Dispose();
    public void Show();

    public enum Severity
    {
        Data = 0,
        Verbose = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
    }

}

}
