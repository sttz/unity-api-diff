using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class TreeViewItem : IComparable<UnityEditor.IMGUI.Controls.TreeViewItem>
{
    public System.Collections.Generic.List<UnityEditor.IMGUI.Controls.TreeViewItem> children { get; set; }
    public int depth { get; set; }
    public string displayName { get; set; }
    public bool hasChildren { get; }
    public Texture2D icon { get; set; }
    public int id { get; set; }
    public UnityEditor.IMGUI.Controls.TreeViewItem parent { get; set; }

    public TreeViewItem();
    public TreeViewItem(int id);
    public TreeViewItem(int id, int depth);
    public TreeViewItem(int id, int depth, string displayName);

    public void AddChild(UnityEditor.IMGUI.Controls.TreeViewItem child);
    public int CompareTo(UnityEditor.IMGUI.Controls.TreeViewItem other);
    public string ToString();

}

}
