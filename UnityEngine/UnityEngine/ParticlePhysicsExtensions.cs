using System;
using UnityEngine;

namespace UnityEngine
{

public static class ParticlePhysicsExtensions
{
    static public int GetCollisionEvents(ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents);
    static public int GetCollisionEvents(ParticleSystem ps, GameObject go, System.Collections.Generic.List<ParticleCollisionEvent> collisionEvents);
    static public int GetSafeCollisionEventSize(ParticleSystem ps);
    static public int GetSafeTriggerParticlesSize(ParticleSystem ps, ParticleSystemTriggerEventType type);
    static public int GetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, System.Collections.Generic.List<Particle> particles);
    static public void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, System.Collections.Generic.List<Particle> particles, int offset, int count);
    static public void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, System.Collections.Generic.List<Particle> particles);

}

}
