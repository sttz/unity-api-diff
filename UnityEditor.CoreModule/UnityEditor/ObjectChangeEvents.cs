using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class ObjectChangeEvents
{
    static public event ObjectChangeEventsHandler changesPublished;

    public delegate void ObjectChangeEventsHandler(UnityEditor.ObjectChangeEventStream stream);

}

}
