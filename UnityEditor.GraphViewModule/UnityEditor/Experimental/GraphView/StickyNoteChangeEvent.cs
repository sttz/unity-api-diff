using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class StickyNoteChangeEvent : UIElements.EventBase<UnityEditor.Experimental.GraphView.StickyNoteChangeEvent>
{
    static public UnityEditor.Experimental.GraphView.StickyNoteChangeEvent GetPooled(UnityEditor.Experimental.GraphView.StickyNote target, UnityEditor.Experimental.GraphView.StickyNoteChange change);

    public UnityEditor.Experimental.GraphView.StickyNoteChange change { get; protected set; }

    public StickyNoteChangeEvent();

}

}
