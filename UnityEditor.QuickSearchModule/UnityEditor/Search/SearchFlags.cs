using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public enum SearchFlags
{
    None = 0,
    Synchronous = 1,
    Sorted = 2,
    Default = 2,
    FirstBatchAsync = 4,
    WantsMore = 8,
    Debug = 16,
    NoIndexing = 32,
    SaveFilters = 33554432,
    ReuseExistingWindow = 67108864,
    Multiselect = 134217728,
    Dockable = 268435456,
    OpenDefault = 436207616,
    OpenGlobal = 503316480,
    FocusContext = 536870912,
    OpenContextual = 939524096,
    HidePanels = 1073741824,
    OpenPicker = 1610612744,
}

}
