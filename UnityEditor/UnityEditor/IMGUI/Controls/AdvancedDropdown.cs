using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public abstract class AdvancedDropdown
{
    protected Vector2 minimumSize { get; set; }

    public AdvancedDropdown(UnityEditor.IMGUI.Controls.AdvancedDropdownState state);

    protected UnityEditor.IMGUI.Controls.AdvancedDropdownItem BuildRoot();
    protected void ItemSelected(UnityEditor.IMGUI.Controls.AdvancedDropdownItem item);
    public void Show(Rect rect);

}

}
