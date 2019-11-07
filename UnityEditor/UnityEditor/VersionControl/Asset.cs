using System;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class Asset
{
    public string assetPath { get; }
    public string fullName { get; }
    public bool isFolder { get; }
    public bool isInCurrentProject { get; }
    public bool isMeta { get; }
    public bool locked { get; }
    public string metaPath { get; }
    public string name { get; }
    public string path { get; }
    public string prettyPath { get; }
    public bool readOnly { get; }
    public States state { get; }

    public Asset(string clientPath);

    public void Dispose();
    public void Edit();
    public bool IsChildOf(UnityEditor.VersionControl.Asset other);
    public bool IsOneOfStates(States[] states);
    public bool IsState(States state);
    public Object Load();

    public enum States
    {
        None = 0,
        Local = 1,
        Synced = 2,
        OutOfSync = 4,
        Missing = 8,
        CheckedOutLocal = 16,
        CheckedOutRemote = 32,
        DeletedLocal = 64,
        DeletedRemote = 128,
        AddedLocal = 256,
        AddedRemote = 512,
        Conflicted = 1024,
        LockedLocal = 2048,
        LockedRemote = 4096,
        Updating = 8192,
        ReadOnly = 16384,
        MetaFile = 32768,
        MovedLocal = 65536,
        MovedRemote = 131072,
        Unversioned = 262144,
    }

}

}
