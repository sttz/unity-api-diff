using System;
using UnityEngine;

namespace UnityEditor.Animations
{

public class AnimatorTransitionBase : Object
{
    public UnityEditor.Animations.AnimatorCondition[] conditions { get; set; }
    public UnityEditor.Animations.AnimatorState destinationState { get; set; }
    public UnityEditor.Animations.AnimatorStateMachine destinationStateMachine { get; set; }
    public bool isExit { get; set; }
    public bool mute { get; set; }
    public bool solo { get; set; }

    protected AnimatorTransitionBase();

    public void AddCondition(UnityEditor.Animations.AnimatorConditionMode mode, float threshold, string parameter);
    public string GetDisplayName(Object source);
    public void RemoveCondition(UnityEditor.Animations.AnimatorCondition condition);

}

}
