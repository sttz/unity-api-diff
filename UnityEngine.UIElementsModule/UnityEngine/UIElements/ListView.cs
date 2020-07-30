using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ListView : UIElements.BindableElement, ISerializationCallbackReceiver
{
    static public string borderUssClassName;
    static public string dragHoverBarUssClassName;
    static public string itemAlternativeBackgroundUssClassName;
    static public string itemDragHoverUssClassName;
    static public string itemSelectedVariantUssClassName;
    static public string itemUssClassName;
    static public string ussClassName;

    public Action<UIElements.VisualElement, int> bindItem { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public int itemHeight { get; set; }
    public IList itemsSource { get; set; }
    public Func<UIElements.VisualElement> makeItem { get; set; }
    public bool reorderable { get; set; }
    public float resolvedItemHeight { get; }
    public int selectedIndex { get; set; }
    public IEnumerable<int> selectedIndices { get; }
    public object selectedItem { get; }
    public IEnumerable<object> selectedItems { get; }
    public UIElements.SelectionType selectionType { get; set; }
    public UIElements.AlternatingRowBackground showAlternatingRowBackgrounds { get; set; }
    public bool showBorder { get; set; }
    public bool showBoundCollectionSize { get; set; }
    public Action<UIElements.VisualElement, int> unbindItem { get; set; }

    public event Action<object> onItemChosen;
    public event Action<IEnumerable<object>> onItemsChosen;
    public event Action<IEnumerable<object>> onSelectionChange;
    public event Action<List<object>> onSelectionChanged;

    public ListView();
    public ListView(IList itemsSource, int itemHeight, Func<UIElements.VisualElement> makeItem, Action<UIElements.VisualElement, int> bindItem);

    public void AddToSelection(int index);
    public void ClearSelection();
    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public void OnKeyDown(UIElements.KeyDownEvent evt);
    public void Refresh();
    public void RemoveFromSelection(int index);
    public void ScrollTo(UIElements.VisualElement visualElement);
    public void ScrollToItem(int index);
    public void SetSelection(int index);
    public void SetSelection(IEnumerable<int> indices);
    public void SetSelectionWithoutNotify(IEnumerable<int> indices);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.ListView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
