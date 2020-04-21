using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IBinding
{
    public void PreUpdate();
    public void Release();
    public void Update();

}

}
