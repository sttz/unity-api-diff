using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IBindable
{
    public UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }

}

}
