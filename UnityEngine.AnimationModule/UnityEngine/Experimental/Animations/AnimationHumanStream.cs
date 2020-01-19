using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct AnimationHumanStream
{
    public Vector3 bodyLocalPosition { get; set; }
    public Quaternion bodyLocalRotation { get; set; }
    public Vector3 bodyPosition { get; set; }
    public Quaternion bodyRotation { get; set; }
    public float humanScale { get; }
    public bool isValid { get; }
    public float leftFootHeight { get; }
    public Vector3 leftFootVelocity { get; }
    public float rightFootHeight { get; }
    public Vector3 rightFootVelocity { get; }

    public Vector3 GetGoalLocalPosition(AvatarIKGoal index);
    public Quaternion GetGoalLocalRotation(AvatarIKGoal index);
    public Vector3 GetGoalPosition(AvatarIKGoal index);
    public Vector3 GetGoalPositionFromPose(AvatarIKGoal index);
    public Quaternion GetGoalRotation(AvatarIKGoal index);
    public Quaternion GetGoalRotationFromPose(AvatarIKGoal index);
    public float GetGoalWeightPosition(AvatarIKGoal index);
    public float GetGoalWeightRotation(AvatarIKGoal index);
    public Vector3 GetHintPosition(AvatarIKHint index);
    public float GetHintWeightPosition(AvatarIKHint index);
    public float GetMuscle(Experimental.Animations.MuscleHandle muscle);
    public void ResetToStancePose();
    public void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos);
    public void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot);
    public void SetGoalPosition(AvatarIKGoal index, Vector3 pos);
    public void SetGoalRotation(AvatarIKGoal index, Quaternion rot);
    public void SetGoalWeightPosition(AvatarIKGoal index, float value);
    public void SetGoalWeightRotation(AvatarIKGoal index, float value);
    public void SetHintPosition(AvatarIKHint index, Vector3 pos);
    public void SetHintWeightPosition(AvatarIKHint index, float value);
    public void SetLookAtBodyWeight(float weight);
    public void SetLookAtClampWeight(float weight);
    public void SetLookAtEyesWeight(float weight);
    public void SetLookAtHeadWeight(float weight);
    public void SetLookAtPosition(Vector3 lookAtPosition);
    public void SetMuscle(Experimental.Animations.MuscleHandle muscle, float value);
    public void SolveIK();

}

}
