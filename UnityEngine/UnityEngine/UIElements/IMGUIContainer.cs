using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class IMGUIContainer : UIElements.VisualElement, IDisposable
{
    static public string ussClassName;

    public bool canGrabFocus { get; }
    public UIElements.ContextType contextType { get; set; }
    public Action onGUIHandler { get; set; }

    public IMGUIContainer();
    public IMGUIContainer(Action onGUIHandler);

    public void Dispose();
    protected void Dispose(bool disposeManaged);
    public void HandleEvent(UIElements.EventBase evt);
    public void MarkDirtyLayout();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.IMGUIContainer, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
