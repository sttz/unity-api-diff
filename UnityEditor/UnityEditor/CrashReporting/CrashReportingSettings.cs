using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.CrashReporting
{

public static class CrashReportingSettings
{
    static public bool captureEditorExceptions { get; set; }
    static public bool enabled { get; set; }
    static public uint logBufferSize { get; set; }

}

}
