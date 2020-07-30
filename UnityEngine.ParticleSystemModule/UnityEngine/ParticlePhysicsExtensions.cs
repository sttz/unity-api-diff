using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class ParticlePhysicsExtensions
{
    static public int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents);
    static public int GetCollisionEvents(ParticleSystem ps, GameObject go, ParticleCollisionEvent[] collisionEvents);
    static public int GetSafeCollisionEventSize(ParticleSystem ps);
    static public int GetSafeTriggerParticlesSize(ParticleSystem ps, ParticleSystemTriggerEventType type);
    static public int GetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<Particle> particles);
    static public int GetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<Particle> particles, out ColliderData colliderData);
    static public void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<Particle> particles);
    static public void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<Particle> particles, int offset, int count);

}

}
