using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class StateMachine : Object
{
    public Vector3 anyStatePosition { get; set; }
    public UnityEditorInternal.State defaultState { get; set; }
    public Vector3 parentStateMachinePosition { get; set; }

    public StateMachine();

    public UnityEditorInternal.Transition AddAnyStateTransition(UnityEditorInternal.State dst);
    public UnityEditorInternal.State AddState(string stateName);
    public UnityEditorInternal.StateMachine AddStateMachine(string stateMachineName);
    public UnityEditorInternal.Transition AddTransition(UnityEditorInternal.State src, UnityEditorInternal.State dst);
    public UnityEditorInternal.State GetState(int index);
    public UnityEditorInternal.StateMachine GetStateMachine(int index);
    public Vector3 GetStateMachinePosition(int i);
    public UnityEditorInternal.Transition[] GetTransitionsFromState(UnityEditorInternal.State srcState);

}

}
