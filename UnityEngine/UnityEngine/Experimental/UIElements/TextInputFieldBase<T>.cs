using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class TextInputFieldBase<T> : Experimental.UIElements.BaseField<T>, Experimental.UIElements.ITextInputField, Experimental.UIElements.IEventHandler, Experimental.UIElements.ITextElement
{
    public Color cursorColor { get; }
    public int cursorIndex { get; }
    public bool doubleClickSelectsWord { get; set; }
    public bool isDelayed { get; set; }
    public bool isPasswordField { get; set; }
    public char maskChar { get; set; }
    public int maxLength { get; set; }
    public int selectIndex { get; }
    public Color selectionColor { get; }
    public string text { get; protected set; }
    public bool tripleClickSelectsLine { get; set; }

    public TextInputFieldBase(int maxLength, char maskChar);

    protected void BuildContextualMenu(Experimental.UIElements.ContextualMenuPopulateEvent evt);
    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle style);
    public void SelectAll();

    public class UxmlTraits<T> : UxmlTraits<T>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
