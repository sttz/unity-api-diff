using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class Task
{
    public UnityEditor.VersionControl.AssetList assetList { get; }
    public UnityEditor.VersionControl.ChangeSets changeSets { get; }
    public string description { get; }
    public UnityEditor.VersionControl.Message[] messages { get; }
    public string progressMessage { get; }
    public int progressPct { get; }
    public int resultCode { get; }
    public int secondsSpent { get; }
    public bool success { get; }
    public string text { get; }
    public int userIdentifier { get; set; }

    public void Dispose();
    public void SetCompletionAction(UnityEditor.VersionControl.CompletionAction action);
    public void Wait();

}

}
