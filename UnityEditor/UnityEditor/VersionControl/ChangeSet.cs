using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class ChangeSet
{
    static public string defaultID;

    public string description { get; }
    public string id { get; }

    public ChangeSet();
    public ChangeSet(string description);
    public ChangeSet(UnityEditor.VersionControl.ChangeSet other);
    public ChangeSet(string description, string revision);

    public void Dispose();

}

}
