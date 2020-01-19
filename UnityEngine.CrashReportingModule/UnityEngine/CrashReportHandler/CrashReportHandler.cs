using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.CrashReportHandler
{

public class CrashReportHandler
{
    static public bool enableCaptureExceptions { get; set; }
    static public uint logBufferSize { get; set; }

    static public string GetUserMetadata(string key);
    static public void SetUserMetadata(string key, string value);

}

}
