using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ListView : Experimental.UIElements.VisualElement
{
    public Action<Experimental.UIElements.VisualElement, int> bindItem { get; set; }
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public int itemHeight { get; set; }
    public System.Collections.IList itemsSource { get; set; }
    public Func<Experimental.UIElements.VisualElement> makeItem { get; set; }
    public int selectedIndex { get; set; }
    public object selectedItem { get; }
    public Experimental.UIElements.SelectionType selectionType { get; set; }

    public event Action<object> onItemChosen;
    public event Action<System.Collections.Generic.List<object>> onSelectionChanged;

    public ListView();
    public ListView(System.Collections.IList itemsSource, int itemHeight, Func<Experimental.UIElements.VisualElement> makeItem, Action<Experimental.UIElements.VisualElement, int> bindItem);

    protected void AddToSelection(int index);
    protected void ClearSelection();
    public void OnKeyDown(Experimental.UIElements.KeyDownEvent evt);
    public void OnPersistentDataReady();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle styles);
    public void Refresh();
    protected void RemoveFromSelection(int index);
    public void ScrollTo(Experimental.UIElements.VisualElement visualElement);
    public void ScrollToItem(int index);
    protected void SetSelection(int index);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.ListView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
