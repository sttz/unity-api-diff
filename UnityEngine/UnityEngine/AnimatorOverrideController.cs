using System;
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

    public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<AnimationClip, AnimationClip>> overrides);
    public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<AnimationClip, AnimationClip>> overrides);

}

}
