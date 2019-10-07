using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ListView : UIElements.VisualElement
{
    static public string itemSelectedVariantUssClassName;
    static public string itemUssClassName;
    static public string ussClassName;

    public Action<UIElements.VisualElement, int> bindItem { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public int itemHeight { get; set; }
    public System.Collections.IList itemsSource { get; set; }
    public Func<UIElements.VisualElement> makeItem { get; set; }
    public int selectedIndex { get; set; }
    public object selectedItem { get; }
    public UIElements.SelectionType selectionType { get; set; }

    public event Action<object> onItemChosen;
    public event Action<System.Collections.Generic.List<object>> onSelectionChanged;

    public ListView();
    public ListView(System.Collections.IList itemsSource, int itemHeight, Func<UIElements.VisualElement> makeItem, Action<UIElements.VisualElement, int> bindItem);

    protected void AddToSelection(int index);
    protected void ClearSelection();
    public void OnKeyDown(UIElements.KeyDownEvent evt);
    public void Refresh();
    protected void RemoveFromSelection(int index);
    public void ScrollTo(UIElements.VisualElement visualElement);
    public void ScrollToItem(int index);
    protected void SetSelection(int index);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.ListView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
