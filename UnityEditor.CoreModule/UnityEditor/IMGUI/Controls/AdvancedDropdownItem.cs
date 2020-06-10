using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class AdvancedDropdownItem : IComparable
{
    public IEnumerable<UnityEditor.IMGUI.Controls.AdvancedDropdownItem> children { get; }
    public bool enabled { get; set; }
    public Texture2D icon { get; set; }
    public int id { get; set; }
    public string name { get; set; }

    public AdvancedDropdownItem(string name);

    public void AddChild(UnityEditor.IMGUI.Controls.AdvancedDropdownItem child);
    public void AddSeparator();
    public int CompareTo(object o);
    public string ToString();

}

}
