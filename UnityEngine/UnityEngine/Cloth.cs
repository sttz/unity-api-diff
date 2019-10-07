using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Cloth : Component
{
    public float bendingStiffness { get; set; }
    public CapsuleCollider[] capsuleColliders { get; set; }
    public float clothSolverFrequency { get; set; }
    public ClothSkinningCoefficient[] coefficients { get; set; }
    public float collisionMassScale { get; set; }
    public float damping { get; set; }
    public bool enableContinuousCollision { get; set; }
    public bool enabled { get; set; }
    public Vector3 externalAcceleration { get; set; }
    public float friction { get; set; }
    public Vector3[] normals { get; }
    public Vector3 randomAcceleration { get; set; }
    public bool selfCollision { get; set; }
    public float selfCollisionDistance { get; set; }
    public float selfCollisionStiffness { get; set; }
    public float sleepThreshold { get; set; }
    public bool solverFrequency { get; set; }
    public ClothSphereColliderPair[] sphereColliders { get; set; }
    public float stiffnessFrequency { get; set; }
    public float stretchingStiffness { get; set; }
    public float useContinuousCollision { get; set; }
    public bool useGravity { get; set; }
    public bool useTethers { get; set; }
    public float useVirtualParticles { get; set; }
    public Vector3[] vertices { get; }
    public float worldAccelerationScale { get; set; }
    public float worldVelocityScale { get; set; }

    public Cloth();

    public void ClearTransformMotion();
    public void GetSelfAndInterCollisionIndices(System.Collections.Generic.List<uint> indices);
    public void GetVirtualParticleIndices(System.Collections.Generic.List<uint> indices);
    public void GetVirtualParticleWeights(System.Collections.Generic.List<Vector3> weights);
    public void SetEnabledFading(bool enabled, float interpolationTime);
    public void SetEnabledFading(bool enabled);
    public void SetSelfAndInterCollisionIndices(System.Collections.Generic.List<uint> indices);
    public void SetVirtualParticleIndices(System.Collections.Generic.List<uint> indices);
    public void SetVirtualParticleWeights(System.Collections.Generic.List<Vector3> weights);

}

}
