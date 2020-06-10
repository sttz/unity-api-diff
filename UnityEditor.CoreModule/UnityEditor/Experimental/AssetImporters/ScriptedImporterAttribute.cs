using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class ScriptedImporterAttribute : Attribute
{
    public bool AllowCaching;
    public bool AutoSelect;

    public string[] fileExtensions { get; private set; }
    public int importQueuePriority { get; private set; }
    public string[] overrideFileExtensions { get; private set; }
    public int version { get; private set; }

    public ScriptedImporterAttribute(int version, string ext);
    public ScriptedImporterAttribute(int version, string[] exts);
    public ScriptedImporterAttribute(int version, string ext, int importQueueOffset);
    public ScriptedImporterAttribute(int version, string[] exts, int importQueueOffset);
    public ScriptedImporterAttribute(int version, string[] exts, string[] overrideExts);
    public ScriptedImporterAttribute(int version, string[] exts, string[] overrideExts, int importQueueOffset);

}

}
