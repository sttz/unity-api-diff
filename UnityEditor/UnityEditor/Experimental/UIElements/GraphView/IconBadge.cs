using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class IconBadge : Experimental.UIElements.VisualElement
{
    static public UnityEditor.Experimental.UIElements.GraphView.IconBadge CreateComment(string message);
    static public UnityEditor.Experimental.UIElements.GraphView.IconBadge CreateError(string message);

    protected SpriteAlignment alignment { get; set; }
    public string badgeText { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> distance { get; set; }
    protected Experimental.UIElements.VisualElement target { get; set; }

    public IconBadge();
    public IconBadge(Experimental.UIElements.VisualTreeAsset template);

    public void AttachTo(Experimental.UIElements.VisualElement target, SpriteAlignment align);
    public void Detach();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle elementStyle);

}

}
