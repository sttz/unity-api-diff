using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class HumanTemplate : Object
{
    public HumanTemplate();

    public void ClearTemplate();
    public string Find(string name);
    public void Insert(string name, string templateName);

}

}
