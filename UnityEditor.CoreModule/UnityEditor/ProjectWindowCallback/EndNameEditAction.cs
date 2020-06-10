using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ProjectWindowCallback
{

public abstract class EndNameEditAction : ScriptableObject
{
    protected EndNameEditAction();

    public void Action(int instanceId, string pathName, string resourceFile);
    public void Cancelled(int instanceId, string pathName, string resourceFile);
    public void CleanUp();
    public void OnEnable();

}

}
