using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public class AnimatorControllerLayer
{
    public AvatarMask avatarMask { get; set; }
    public UnityEditor.Animations.AnimatorLayerBlendingMode blendingMode { get; set; }
    public float defaultWeight { get; set; }
    public bool iKPass { get; set; }
    public string name { get; set; }
    public UnityEditor.Animations.AnimatorStateMachine stateMachine { get; set; }
    public bool syncedLayerAffectsTiming { get; set; }
    public int syncedLayerIndex { get; set; }

    public AnimatorControllerLayer();

    public StateMachineBehaviour[] GetOverrideBehaviours(UnityEditor.Animations.AnimatorState state);
    public Motion GetOverrideMotion(UnityEditor.Animations.AnimatorState state);
    public void SetOverrideBehaviours(UnityEditor.Animations.AnimatorState state, StateMachineBehaviour[] behaviours);
    public void SetOverrideMotion(UnityEditor.Animations.AnimatorState state, Motion motion);

}

}
