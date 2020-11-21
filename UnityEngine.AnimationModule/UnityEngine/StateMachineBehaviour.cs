using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class StateMachineBehaviour : ScriptableObject
{
    protected StateMachineBehaviour();

    public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, Animations.AnimatorControllerPlayable controller);
    public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, Animations.AnimatorControllerPlayable controller);
    public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, Animations.AnimatorControllerPlayable controller);
    public void OnStateMachineEnter(Animator animator, int stateMachinePathHash);
    public void OnStateMachineEnter(Animator animator, int stateMachinePathHash, Animations.AnimatorControllerPlayable controller);
    public void OnStateMachineExit(Animator animator, int stateMachinePathHash);
    public void OnStateMachineExit(Animator animator, int stateMachinePathHash, Animations.AnimatorControllerPlayable controller);
    public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, Animations.AnimatorControllerPlayable controller);
    public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, Animations.AnimatorControllerPlayable controller);

}

}
