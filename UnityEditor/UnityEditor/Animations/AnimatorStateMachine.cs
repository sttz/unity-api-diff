using System;
using UnityEngine;

namespace UnityEditor.Animations
{

public sealed class AnimatorStateMachine : Object
{
    public Vector3 anyStatePosition { get; set; }
    public UnityEditor.Animations.AnimatorStateTransition[] anyStateTransitions { get; set; }
    public StateMachineBehaviour[] behaviours { get; set; }
    public UnityEditor.Animations.AnimatorState defaultState { get; set; }
    public Vector3 entryPosition { get; set; }
    public UnityEditor.Animations.AnimatorTransition[] entryTransitions { get; set; }
    public Vector3 exitPosition { get; set; }
    public Vector3 parentStateMachinePosition { get; set; }
    public UnityEditor.Animations.ChildAnimatorStateMachine[] stateMachines { get; set; }
    public UnityEditor.Animations.ChildAnimatorState[] states { get; set; }

    public AnimatorStateMachine();

    public UnityEditor.Animations.AnimatorStateTransition AddAnyStateTransition(UnityEditor.Animations.AnimatorState destinationState);
    public UnityEditor.Animations.AnimatorStateTransition AddAnyStateTransition(UnityEditor.Animations.AnimatorStateMachine destinationStateMachine);
    public UnityEditor.Animations.AnimatorTransition AddEntryTransition(UnityEditor.Animations.AnimatorState destinationState);
    public UnityEditor.Animations.AnimatorTransition AddEntryTransition(UnityEditor.Animations.AnimatorStateMachine destinationStateMachine);
    public UnityEditor.Animations.AnimatorState AddState(string name);
    public UnityEditor.Animations.AnimatorState AddState(string name, Vector3 position);
    public void AddState(UnityEditor.Animations.AnimatorState state, Vector3 position);
    public UnityEditor.Animations.AnimatorStateMachine AddStateMachine(string name);
    public UnityEditor.Animations.AnimatorStateMachine AddStateMachine(string name, Vector3 position);
    public void AddStateMachine(UnityEditor.Animations.AnimatorStateMachine stateMachine, Vector3 position);
    public StateMachineBehaviour AddStateMachineBehaviour(Type stateMachineBehaviourType);
    public T AddStateMachineBehaviour();
    public UnityEditor.Animations.AnimatorTransition AddStateMachineExitTransition(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine);
    public UnityEditor.Animations.AnimatorTransition AddStateMachineTransition(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine);
    public UnityEditor.Animations.AnimatorTransition AddStateMachineTransition(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine, UnityEditor.Animations.AnimatorStateMachine destinationStateMachine);
    public UnityEditor.Animations.AnimatorTransition AddStateMachineTransition(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine, UnityEditor.Animations.AnimatorState destinationState);
    public UnityEditor.Animations.AnimatorTransition[] GetStateMachineTransitions(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine);
    public string MakeUniqueStateMachineName(string name);
    public string MakeUniqueStateName(string name);
    public bool RemoveAnyStateTransition(UnityEditor.Animations.AnimatorStateTransition transition);
    public bool RemoveEntryTransition(UnityEditor.Animations.AnimatorTransition transition);
    public void RemoveState(UnityEditor.Animations.AnimatorState state);
    public void RemoveStateMachine(UnityEditor.Animations.AnimatorStateMachine stateMachine);
    public bool RemoveStateMachineTransition(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine, UnityEditor.Animations.AnimatorTransition transition);
    public void SetStateMachineTransitions(UnityEditor.Animations.AnimatorStateMachine sourceStateMachine, UnityEditor.Animations.AnimatorTransition[] transitions);

}

}
