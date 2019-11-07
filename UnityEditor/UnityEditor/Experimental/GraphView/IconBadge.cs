using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class IconBadge : UIElements.VisualElement
{
    static public UnityEditor.Experimental.GraphView.IconBadge CreateComment(string message);
    static public UnityEditor.Experimental.GraphView.IconBadge CreateError(string message);

    protected SpriteAlignment alignment { get; set; }
    public string badgeText { get; set; }
    public int distance { get; set; }
    public string styleType { get; set; }
    protected UIElements.VisualElement target { get; set; }

    public IconBadge();
    public IconBadge(UIElements.VisualTreeAsset template);

    public void AttachTo(UIElements.VisualElement target, SpriteAlignment align);
    public void Detach();

}

}
