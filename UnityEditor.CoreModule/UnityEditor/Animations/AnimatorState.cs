using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public sealed class AnimatorState : Object
{
    public StateMachineBehaviour[] behaviours { get; set; }
    public float cycleOffset { get; set; }
    public string cycleOffsetParameter { get; set; }
    public bool cycleOffsetParameterActive { get; set; }
    public bool iKOnFeet { get; set; }
    public bool mirror { get; set; }
    public string mirrorParameter { get; set; }
    public bool mirrorParameterActive { get; set; }
    public Motion motion { get; set; }
    public int nameHash { get; }
    public float speed { get; set; }
    public string speedParameter { get; set; }
    public bool speedParameterActive { get; set; }
    public string tag { get; set; }
    public string timeParameter { get; set; }
    public bool timeParameterActive { get; set; }
    public UnityEditor.Animations.AnimatorStateTransition[] transitions { get; set; }
    public string uniqueName { get; }
    public int uniqueNameHash { get; }
    public bool writeDefaultValues { get; set; }

    public AnimatorState();

    public UnityEditor.Animations.AnimatorStateTransition AddExitTransition();
    public UnityEditor.Animations.AnimatorStateTransition AddExitTransition(bool defaultExitTime);
    public StateMachineBehaviour AddStateMachineBehaviour(Type stateMachineBehaviourType);
    public T AddStateMachineBehaviour<T>();
    public UnityEditor.Animations.AnimatorStateTransition AddTransition(UnityEditor.Animations.AnimatorState destinationState);
    public UnityEditor.Animations.AnimatorStateTransition AddTransition(UnityEditor.Animations.AnimatorStateMachine destinationStateMachine);
    public void AddTransition(UnityEditor.Animations.AnimatorStateTransition transition);
    public UnityEditor.Animations.AnimatorStateTransition AddTransition(UnityEditor.Animations.AnimatorState destinationState, bool defaultExitTime);
    public UnityEditor.Animations.AnimatorStateTransition AddTransition(UnityEditor.Animations.AnimatorStateMachine destinationStateMachine, bool defaultExitTime);
    public Motion GetMotion();
    public void RemoveTransition(UnityEditor.Animations.AnimatorStateTransition transition);

}

}
