using System;
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
