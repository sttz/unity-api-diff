using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimatorControllerPlayable : Playables.IPlayable, IEquatable<Animations.AnimatorControllerPlayable>
{
    static public Animations.AnimatorControllerPlayable Null { get; }

    static public Animations.AnimatorControllerPlayable Create(Playables.PlayableGraph graph, RuntimeAnimatorController controller);

    public void CrossFade(string stateName, float transitionDuration);
    public void CrossFade(int stateNameHash, float transitionDuration);
    public void CrossFade(string stateName, float transitionDuration, int layer);
    public void CrossFade(int stateNameHash, float transitionDuration, int layer);
    public void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime);
    public void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime);
    public void CrossFadeInFixedTime(string stateName, float transitionDuration);
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration);
    public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer);
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer);
    public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime);
    public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime);
    public bool Equals(Animations.AnimatorControllerPlayable other);
    public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
    public bool GetBool(int id);
    public bool GetBool(string name);
    public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
    public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    public int GetCurrentAnimatorClipInfoCount(int layerIndex);
    public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
    public float GetFloat(int id);
    public float GetFloat(string name);
    public Playables.PlayableHandle GetHandle();
    public int GetInteger(int id);
    public int GetInteger(string name);
    public int GetLayerCount();
    public int GetLayerIndex(string layerName);
    public string GetLayerName(int layerIndex);
    public float GetLayerWeight(int layerIndex);
    public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
    public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    public int GetNextAnimatorClipInfoCount(int layerIndex);
    public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
    public AnimatorControllerParameter GetParameter(int index);
    public int GetParameterCount();
    public bool HasState(int layerIndex, int stateID);
    public bool IsInTransition(int layerIndex);
    public bool IsParameterControlledByCurve(int id);
    public bool IsParameterControlledByCurve(string name);
    public void Play(string stateName);
    public void Play(int stateNameHash);
    public void Play(string stateName, int layer);
    public void Play(int stateNameHash, int layer);
    public void Play(string stateName, int layer, float normalizedTime);
    public void Play(int stateNameHash, int layer, float normalizedTime);
    public void PlayInFixedTime(string stateName);
    public void PlayInFixedTime(int stateNameHash);
    public void PlayInFixedTime(string stateName, int layer);
    public void PlayInFixedTime(int stateNameHash, int layer);
    public void PlayInFixedTime(string stateName, int layer, float fixedTime);
    public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
    public void ResetTrigger(int id);
    public void ResetTrigger(string name);
    public void SetBool(int id, bool value);
    public void SetBool(string name, bool value);
    public void SetFloat(int id, float value);
    public void SetFloat(string name, float value);
    public void SetHandle(Playables.PlayableHandle handle);
    public void SetInteger(int id, int value);
    public void SetInteger(string name, int value);
    public void SetLayerWeight(int layerIndex, float weight);
    public void SetTrigger(int id);
    public void SetTrigger(string name);

}

}
