using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Animator : Behaviour
{
    static public int StringToHash(string name);

    public Vector3 angularVelocity { get; }
    public bool animatePhysics { get; set; }
    public bool applyRootMotion { get; set; }
    public Avatar avatar { get; set; }
    public Vector3 bodyPosition { get; set; }
    public Quaternion bodyRotation { get; set; }
    public AnimatorCullingMode cullingMode { get; set; }
    public Vector3 deltaPosition { get; }
    public Quaternion deltaRotation { get; }
    public float feetPivotActive { get; set; }
    public bool fireEvents { get; set; }
    public float gravityWeight { get; }
    public bool hasBoundPlayables { get; }
    public bool hasRootMotion { get; }
    public bool hasTransformHierarchy { get; }
    public float humanScale { get; }
    public bool isHuman { get; }
    public bool isInitialized { get; }
    public bool isMatchingTarget { get; }
    public bool isOptimizable { get; }
    public bool keepAnimatorControllerStateOnDisable { get; set; }
    public int layerCount { get; }
    public bool layersAffectMassCenter { get; set; }
    public float leftFeetBottomHeight { get; }
    public bool linearVelocityBlending { get; set; }
    public bool logWarnings { get; set; }
    public int parameterCount { get; }
    public AnimatorControllerParameter[] parameters { get; }
    public Vector3 pivotPosition { get; }
    public float pivotWeight { get; }
    public Playables.PlayableGraph playableGraph { get; }
    public float playbackTime { get; set; }
    public AnimatorRecorderMode recorderMode { get; }
    public float recorderStartTime { get; set; }
    public float recorderStopTime { get; set; }
    public float rightFeetBottomHeight { get; }
    public Vector3 rootPosition { get; set; }
    public Quaternion rootRotation { get; set; }
    public RuntimeAnimatorController runtimeAnimatorController { get; set; }
    public float speed { get; set; }
    public bool stabilizeFeet { get; set; }
    public Vector3 targetPosition { get; }
    public Quaternion targetRotation { get; }
    public AnimatorUpdateMode updateMode { get; set; }
    public Vector3 velocity { get; }

    public Animator();

    public void ApplyBuiltinRootMotion();
    public void CrossFade(int stateHashName, float normalizedTransitionDuration);
    public void CrossFade(string stateName, float normalizedTransitionDuration);
    public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
    public void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
    public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
    public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
    public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
    public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
    public void ForceStateNormalizedTime(float normalizedTime);
    public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
    public T GetBehaviour<T>();
    public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
    public T[] GetBehaviours<T>();
    public Transform GetBoneTransform(HumanBodyBones humanBoneId);
    public bool GetBool(int id);
    public bool GetBool(string name);
    public AnimationInfo[] GetCurrentAnimationClipState(int layerIndex);
    public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
    public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    public int GetCurrentAnimatorClipInfoCount(int layerIndex);
    public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
    public float GetFloat(int id);
    public float GetFloat(string name);
    public Vector3 GetIKHintPosition(AvatarIKHint hint);
    public float GetIKHintPositionWeight(AvatarIKHint hint);
    public Vector3 GetIKPosition(AvatarIKGoal goal);
    public float GetIKPositionWeight(AvatarIKGoal goal);
    public Quaternion GetIKRotation(AvatarIKGoal goal);
    public float GetIKRotationWeight(AvatarIKGoal goal);
    public int GetInteger(int id);
    public int GetInteger(string name);
    public int GetLayerIndex(string layerName);
    public string GetLayerName(int layerIndex);
    public float GetLayerWeight(int layerIndex);
    public AnimationInfo[] GetNextAnimationClipState(int layerIndex);
    public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
    public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    public int GetNextAnimatorClipInfoCount(int layerIndex);
    public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
    public AnimatorControllerParameter GetParameter(int index);
    public Quaternion GetQuaternion(int id);
    public Quaternion GetQuaternion(string name);
    public Vector3 GetVector(int id);
    public Vector3 GetVector(string name);
    public bool HasState(int layerIndex, int stateID);
    public void InterruptMatchTarget();
    public void InterruptMatchTarget(bool completeMatch);
    public bool IsControlled(Transform transform);
    public bool IsInTransition(int layerIndex);
    public bool IsParameterControlledByCurve(int id);
    public bool IsParameterControlledByCurve(string name);
    public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime);
    public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
    public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
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
    public void Rebind();
    public void ResetTrigger(int id);
    public void ResetTrigger(string name);
    public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation);
    public void SetBool(int id, bool value);
    public void SetBool(string name, bool value);
    public void SetFloat(int id, float value);
    public void SetFloat(string name, float value);
    public void SetFloat(int id, float value, float dampTime, float deltaTime);
    public void SetFloat(string name, float value, float dampTime, float deltaTime);
    public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition);
    public void SetIKHintPositionWeight(AvatarIKHint hint, float value);
    public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition);
    public void SetIKPositionWeight(AvatarIKGoal goal, float value);
    public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation);
    public void SetIKRotationWeight(AvatarIKGoal goal, float value);
    public void SetInteger(int id, int value);
    public void SetInteger(string name, int value);
    public void SetLayerWeight(int layerIndex, float weight);
    public void SetLookAtPosition(Vector3 lookAtPosition);
    public void SetLookAtWeight(float weight);
    public void SetLookAtWeight(float weight, float bodyWeight);
    public void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
    public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
    public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
    public void SetQuaternion(int id, Quaternion value);
    public void SetQuaternion(string name, Quaternion value);
    public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);
    public void SetTrigger(int id);
    public void SetTrigger(string name);
    public void SetVector(int id, Vector3 value);
    public void SetVector(string name, Vector3 value);
    public void StartPlayback();
    public void StartRecording(int frameCount);
    public void Stop();
    public void StopPlayback();
    public void StopRecording();
    public void Update(float deltaTime);
    public void WriteDefaultValues();

}

}
