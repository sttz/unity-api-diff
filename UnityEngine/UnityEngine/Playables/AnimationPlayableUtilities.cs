using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public static class AnimationPlayableUtilities
{
    static public void Play(Animator animator, Playables.Playable playable, Playables.PlayableGraph graph);
    static public Animations.AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out Playables.PlayableGraph graph);
    static public Animations.AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out Playables.PlayableGraph graph);
    static public Animations.AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out Playables.PlayableGraph graph);
    static public Animations.AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out Playables.PlayableGraph graph);

}

}
