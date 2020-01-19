using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{

public class ListItem
{
    public string[] Actions { get; set; }
    public UnityEditor.VersionControl.Asset Asset { get; set; }
    public bool CanAccept { get; set; }
    public bool CanExpand { get; }
    public UnityEditor.VersionControl.ChangeSet Change { get; set; }
    public int ChildCount { get; }
    public bool Dummy { get; set; }
    public bool Exclusive { get; set; }
    public bool Expanded { get; set; }
    public UnityEditorInternal.VersionControl.ListItem FirstChild { get; }
    public bool HasActions { get; }
    public bool HasChildren { get; }
    public bool Hidden { get; set; }
    public Texture Icon { get; set; }
    public int Identifier { get; }
    public int Indent { get; set; }
    public object Item { get; set; }
    public UnityEditorInternal.VersionControl.ListItem LastChild { get; }
    public string Name { get; set; }
    public UnityEditorInternal.VersionControl.ListItem Next { get; }
    public UnityEditorInternal.VersionControl.ListItem NextOpen { get; }
    public UnityEditorInternal.VersionControl.ListItem NextOpenSkip { get; }
    public UnityEditorInternal.VersionControl.ListItem NextOpenVisible { get; }
    public int OpenCount { get; }
    public UnityEditorInternal.VersionControl.ListItem Parent { get; }
    public UnityEditorInternal.VersionControl.ListItem Prev { get; }
    public UnityEditorInternal.VersionControl.ListItem PrevOpen { get; }
    public UnityEditorInternal.VersionControl.ListItem PrevOpenSkip { get; }
    public UnityEditorInternal.VersionControl.ListItem PrevOpenVisible { get; }

    public ListItem();

    public void Add(UnityEditorInternal.VersionControl.ListItem listItem);
    public void Clear();
    public UnityEditorInternal.VersionControl.ListItem FindWithIdentifierRecurse(int inIdentifier);
    public bool HasPath();
    public bool IsChildOf(UnityEditorInternal.VersionControl.ListItem listItem);
    public bool Remove(UnityEditorInternal.VersionControl.ListItem listItem);
    public void RemoveAll();

}

}
