using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchDocument
{
    public string id { get; private set; }
    public string metadata { get; set; }

    public SearchDocument(string id, string metadata = null);

    public string ToString();

}

}
