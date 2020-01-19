using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AnimatorOverrideController : RuntimeAnimatorController
{
    public AnimationClipPair[] clips { get; set; }
    public AnimationClip this[string name] { get; set; }
    public AnimationClip this[AnimationClip clip] { get; set; }
    public int overridesCount { get; }
    public RuntimeAnimatorController runtimeAnimatorController { get; set; }

    public AnimatorOverrideController();
    public AnimatorOverrideController(RuntimeAnimatorController controller);

    public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides);
    public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides);

}

}
