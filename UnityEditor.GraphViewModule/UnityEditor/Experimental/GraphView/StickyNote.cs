using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class StickyNote : UnityEditor.Experimental.GraphView.GraphElement, UnityEditor.Experimental.GraphView.IResizable
{
    static public Vector2 defaultSize;

    public string contents { get; set; }
    public UnityEditor.Experimental.GraphView.StickyNoteFontSize fontSize { get; set; }
    public UnityEditor.Experimental.GraphView.StickyNoteTheme theme { get; set; }
    public string title { get; set; }

    public StickyNote();
    public StickyNote(Vector2 position);
    public StickyNote(string uiFile, Vector2 position);

    public void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    public void FitText(bool onlyIfSmaller);
    public Rect GetPosition();
    public void OnResized();
    public void OnStartResize();
    public void SetPosition(Rect rect);
    public void UpdatePresenterPosition();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.Experimental.GraphView.StickyNote>
    {
        public UxmlFactory();

    }

}

}
