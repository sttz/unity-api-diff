using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorUserSettings : Object
{
    static public bool allowAsyncStatusUpdate { get; set; }
    static public bool AutomaticAdd { get; set; }
    static public bool overwriteFailedCheckoutAssets { get; set; }
    static public UnityEditor.SemanticMergeMode semanticMergeMode { get; set; }
    static public bool showFailedCheckout { get; set; }
    static public bool WorkOffline { get; set; }

    static public string GetConfigValue(string name);
    static public void SetConfigValue(string name, string value);

}

}
