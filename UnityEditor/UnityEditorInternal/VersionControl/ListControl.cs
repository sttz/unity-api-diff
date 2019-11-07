using System;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{

public class ListControl
{
    static public UnityEditorInternal.VersionControl.ListControl FromID(int id);

    public ActionDelegate ActionEvent { get; set; }
    public bool DragAcceptOnly { get; set; }
    public DragDelegate DragEvent { get; set; }
    public UnityEditor.VersionControl.ChangeSets EmptyChangeSets { get; }
    public ExpandDelegate ExpandEvent { get; set; }
    public ListState listState { get; }
    public string MenuDefault { get; set; }
    public string MenuFolder { get; set; }
    public bool ReadOnly { get; set; }
    public UnityEditorInternal.VersionControl.ListItem Root { get; }
    public UnityEditor.VersionControl.AssetList SelectedAssets { get; }
    public UnityEditor.VersionControl.ChangeSets SelectedChangeSets { get; }
    public int Size { get; }

    public ListControl();

    public UnityEditorInternal.VersionControl.ListItem Add(UnityEditorInternal.VersionControl.ListItem parent, string name, UnityEditor.VersionControl.Asset asset);
    public UnityEditorInternal.VersionControl.ListItem Add(UnityEditorInternal.VersionControl.ListItem parent, string name, UnityEditor.VersionControl.ChangeSet change);
    public void Clear();
    public UnityEditorInternal.VersionControl.ListItem FindItemWithIdentifier(int identifier);
    public bool OnGUI(Rect area, bool focus);
    public void Refresh();
    public void Refresh(bool updateExpanded);
    public void SelectedAdd(UnityEditorInternal.VersionControl.ListItem item);
    public void SelectedAll();
    public void SelectedSet(UnityEditorInternal.VersionControl.ListItem item);
    public void Sync();

    public enum SelectDirection
    {
        Up = 0,
        Down = 1,
        Current = 2,
    }

    public class ListState
    {
        public System.Collections.Generic.List<string> Expanded;
        public float Scroll;

        public ListState();

    }

    public delegate void ExpandDelegate(UnityEditor.VersionControl.ChangeSet expand, UnityEditorInternal.VersionControl.ListItem item);

    public delegate void DragDelegate(UnityEditor.VersionControl.ChangeSet target);

    public delegate void ActionDelegate(UnityEditorInternal.VersionControl.ListItem item, int actionIdx);

}

}
