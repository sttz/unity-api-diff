using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ParticleSystem : Component
{
    static public void ResetPreMappedBufferMemory();

    public bool automaticCullingEnabled { get; }
    public CollisionModule collision { get; }
    public ColorBySpeedModule colorBySpeed { get; }
    public ColorOverLifetimeModule colorOverLifetime { get; }
    public CustomDataModule customData { get; }
    public float duration { get; }
    public EmissionModule emission { get; }
    public float emissionRate { get; set; }
    public bool enableEmission { get; set; }
    public ExternalForcesModule externalForces { get; }
    public ForceOverLifetimeModule forceOverLifetime { get; }
    public float gravityModifier { get; set; }
    public InheritVelocityModule inheritVelocity { get; }
    public bool isEmitting { get; }
    public bool isPaused { get; }
    public bool isPlaying { get; }
    public bool isStopped { get; }
    public LightsModule lights { get; }
    public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
    public bool loop { get; set; }
    public MainModule main { get; }
    public int maxParticles { get; set; }
    public NoiseModule noise { get; }
    public int particleCount { get; }
    public float playbackSpeed { get; set; }
    public bool playOnAwake { get; set; }
    public bool proceduralSimulationSupported { get; }
    public uint randomSeed { get; set; }
    public RotationBySpeedModule rotationBySpeed { get; }
    public RotationOverLifetimeModule rotationOverLifetime { get; }
    public int safeCollisionEventSize { get; }
    public ParticleSystemScalingMode scalingMode { get; set; }
    public ShapeModule shape { get; }
    public ParticleSystemSimulationSpace simulationSpace { get; set; }
    public SizeBySpeedModule sizeBySpeed { get; }
    public SizeOverLifetimeModule sizeOverLifetime { get; }
    public Color startColor { get; set; }
    public float startDelay { get; set; }
    public float startLifetime { get; set; }
    public float startRotation { get; set; }
    public Vector3 startRotation3D { get; set; }
    public float startSize { get; set; }
    public float startSpeed { get; set; }
    public SubEmittersModule subEmitters { get; }
    public TextureSheetAnimationModule textureSheetAnimation { get; }
    public float time { get; set; }
    public TrailModule trails { get; }
    public TriggerModule trigger { get; }
    public bool useAutoRandomSeed { get; set; }
    public VelocityOverLifetimeModule velocityOverLifetime { get; }

    public ParticleSystem();

    public void Clear();
    public void Clear(bool withChildren);
    public void Emit(int count);
    public void Emit(Particle particle);
    public void Emit(EmitParams emitParams, int count);
    public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color);
    public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex);
    public int GetParticles(out Unity.Collections.NativeArray<Particle> particles);
    public int GetParticles(out Particle[] particles);
    public int GetParticles(out Unity.Collections.NativeArray<Particle> particles, int size);
    public int GetParticles(out Particle[] particles, int size);
    public int GetParticles(out Unity.Collections.NativeArray<Particle> particles, int size, int offset);
    public int GetParticles(out Particle[] particles, int size, int offset);
    public PlaybackState GetPlaybackState();
    public Trails GetTrails();
    public bool IsAlive();
    public bool IsAlive(bool withChildren);
    public void Pause();
    public void Pause(bool withChildren);
    public void Play();
    public void Play(bool withChildren);
    public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex);
    public void SetParticles(out Unity.Collections.NativeArray<Particle> particles);
    public void SetParticles(out Particle[] particles);
    public void SetParticles(out Unity.Collections.NativeArray<Particle> particles, int size);
    public void SetParticles(out Particle[] particles, int size);
    public void SetParticles(out Unity.Collections.NativeArray<Particle> particles, int size, int offset);
    public void SetParticles(out Particle[] particles, int size, int offset);
    public void SetPlaybackState(PlaybackState playbackState);
    public void SetTrails(Trails trailData);
    public void Simulate(float t);
    public void Simulate(float t, bool withChildren);
    public void Simulate(float t, bool withChildren, bool restart);
    public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
    public void Stop();
    public void Stop(bool withChildren);
    public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior);
    public void TriggerSubEmitter(int subEmitterIndex);
    public void TriggerSubEmitter(int subEmitterIndex, Particle particle);
    public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles);

    public struct Burst
    {
        public MinMaxCurve count { get; set; }
        public int cycleCount { get; set; }
        public short maxCount { get; set; }
        public short minCount { get; set; }
        public float probability { get; set; }
        public float repeatInterval { get; set; }
        public float time { get; set; }

        public Burst(float _time, short _count);
        public Burst(float _time, MinMaxCurve _count);
        public Burst(float _time, short _minCount, short _maxCount);
        public Burst(float _time, MinMaxCurve _count, int _cycleCount, float _repeatInterval);
        public Burst(float _time, short _minCount, short _maxCount, int _cycleCount, float _repeatInterval);

    }

    public struct CollisionEvent
    {
        public Component collider { get; }
        public Vector3 intersection { get; }
        public Vector3 normal { get; }
        public Vector3 velocity { get; }

    }

    public struct CollisionModule
    {
        public MinMaxCurve bounce { get; set; }
        public float bounceMultiplier { get; set; }
        public float colliderForce { get; set; }
        public LayerMask collidesWith { get; set; }
        public MinMaxCurve dampen { get; set; }
        public float dampenMultiplier { get; set; }
        public bool enabled { get; set; }
        public bool enableDynamicColliders { get; set; }
        public bool enableInteriorCollisions { get; set; }
        public MinMaxCurve lifetimeLoss { get; set; }
        public float lifetimeLossMultiplier { get; set; }
        public int maxCollisionShapes { get; set; }
        public float maxKillSpeed { get; set; }
        public int maxPlaneCount { get; }
        public float minKillSpeed { get; set; }
        public ParticleSystemCollisionMode mode { get; set; }
        public bool multiplyColliderForceByCollisionAngle { get; set; }
        public bool multiplyColliderForceByParticleSize { get; set; }
        public bool multiplyColliderForceByParticleSpeed { get; set; }
        public ParticleSystemCollisionQuality quality { get; set; }
        public float radiusScale { get; set; }
        public bool sendCollisionMessages { get; set; }
        public ParticleSystemCollisionType type { get; set; }
        public float voxelSize { get; set; }

        public Transform GetPlane(int index);
        public void SetPlane(int index, Transform transform);

    }

    public struct ColorBySpeedModule
    {
        public MinMaxGradient color { get; set; }
        public bool enabled { get; set; }
        public Vector2 range { get; set; }

    }

    public struct ColorOverLifetimeModule
    {
        public MinMaxGradient color { get; set; }
        public bool enabled { get; set; }

    }

    public struct CustomDataModule
    {
        public bool enabled { get; set; }

        public MinMaxGradient GetColor(ParticleSystemCustomData stream);
        public ParticleSystemCustomDataMode GetMode(ParticleSystemCustomData stream);
        public MinMaxCurve GetVector(ParticleSystemCustomData stream, int component);
        public int GetVectorComponentCount(ParticleSystemCustomData stream);
        public void SetColor(ParticleSystemCustomData stream, MinMaxGradient gradient);
        public void SetMode(ParticleSystemCustomData stream, ParticleSystemCustomDataMode mode);
        public void SetVector(ParticleSystemCustomData stream, int component, MinMaxCurve curve);
        public void SetVectorComponentCount(ParticleSystemCustomData stream, int count);

    }

    public struct EmissionModule
    {
        public int burstCount { get; set; }
        public bool enabled { get; set; }
        public MinMaxCurve rate { get; set; }
        public float rateMultiplier { get; set; }
        public MinMaxCurve rateOverDistance { get; set; }
        public float rateOverDistanceMultiplier { get; set; }
        public MinMaxCurve rateOverTime { get; set; }
        public float rateOverTimeMultiplier { get; set; }
        public ParticleSystemEmissionType type { get; set; }

        public Burst GetBurst(int index);
        public int GetBursts(Burst[] bursts);
        public void SetBurst(int index, Burst burst);
        public void SetBursts(Burst[] bursts);
        public void SetBursts(Burst[] bursts, int size);

    }

    public struct EmitParams
    {
        public float angularVelocity { get; set; }
        public Vector3 angularVelocity3D { get; set; }
        public bool applyShapeToPosition { get; set; }
        public Vector3 axisOfRotation { get; set; }
        public int meshIndex { set; }
        public Particle particle { get; set; }
        public Vector3 position { get; set; }
        public uint randomSeed { get; set; }
        public float rotation { get; set; }
        public Vector3 rotation3D { get; set; }
        public Color32 startColor { get; set; }
        public float startLifetime { get; set; }
        public float startSize { get; set; }
        public Vector3 startSize3D { get; set; }
        public Vector3 velocity { get; set; }

        public void ResetAngularVelocity();
        public void ResetAxisOfRotation();
        public void ResetMeshIndex();
        public void ResetPosition();
        public void ResetRandomSeed();
        public void ResetRotation();
        public void ResetStartColor();
        public void ResetStartLifetime();
        public void ResetStartSize();
        public void ResetVelocity();

    }

    public struct ExternalForcesModule
    {
        public bool enabled { get; set; }
        public int influenceCount { get; }
        public ParticleSystemGameObjectFilter influenceFilter { get; set; }
        public LayerMask influenceMask { get; set; }
        public float multiplier { get; set; }
        public MinMaxCurve multiplierCurve { get; set; }

        public void AddInfluence(ParticleSystemForceField field);
        public ParticleSystemForceField GetInfluence(int index);
        public bool IsAffectedBy(ParticleSystemForceField field);
        public void RemoveAllInfluences();
        public void RemoveInfluence(ParticleSystemForceField field);
        public void RemoveInfluence(int index);
        public void SetInfluence(int index, ParticleSystemForceField field);

    }

    public struct ForceOverLifetimeModule
    {
        public bool enabled { get; set; }
        public bool randomized { get; set; }
        public ParticleSystemSimulationSpace space { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

    public struct InheritVelocityModule
    {
        public MinMaxCurve curve { get; set; }
        public float curveMultiplier { get; set; }
        public bool enabled { get; set; }
        public ParticleSystemInheritVelocityMode mode { get; set; }

    }

    public struct LightsModule
    {
        public bool alphaAffectsIntensity { get; set; }
        public bool enabled { get; set; }
        public MinMaxCurve intensity { get; set; }
        public float intensityMultiplier { get; set; }
        public Light light { get; set; }
        public int maxLights { get; set; }
        public MinMaxCurve range { get; set; }
        public float rangeMultiplier { get; set; }
        public float ratio { get; set; }
        public bool sizeAffectsRange { get; set; }
        public bool useParticleColor { get; set; }
        public bool useRandomDistribution { get; set; }

    }

    public struct LimitVelocityOverLifetimeModule
    {
        public float dampen { get; set; }
        public MinMaxCurve drag { get; set; }
        public float dragMultiplier { get; set; }
        public bool enabled { get; set; }
        public MinMaxCurve limit { get; set; }
        public float limitMultiplier { get; set; }
        public MinMaxCurve limitX { get; set; }
        public float limitXMultiplier { get; set; }
        public MinMaxCurve limitY { get; set; }
        public float limitYMultiplier { get; set; }
        public MinMaxCurve limitZ { get; set; }
        public float limitZMultiplier { get; set; }
        public bool multiplyDragByParticleSize { get; set; }
        public bool multiplyDragByParticleVelocity { get; set; }
        public bool separateAxes { get; set; }
        public ParticleSystemSimulationSpace space { get; set; }

    }

    public struct MainModule
    {
        public ParticleSystemCullingMode cullingMode { get; set; }
        public Transform customSimulationSpace { get; set; }
        public float duration { get; set; }
        public ParticleSystemEmitterVelocityMode emitterVelocityMode { get; set; }
        public float flipRotation { get; set; }
        public MinMaxCurve gravityModifier { get; set; }
        public float gravityModifierMultiplier { get; set; }
        public bool loop { get; set; }
        public int maxParticles { get; set; }
        public bool playOnAwake { get; set; }
        public bool prewarm { get; set; }
        public float randomizeRotationDirection { get; set; }
        public Vector2 ringBufferLoopRange { get; set; }
        public ParticleSystemRingBufferMode ringBufferMode { get; set; }
        public ParticleSystemScalingMode scalingMode { get; set; }
        public ParticleSystemSimulationSpace simulationSpace { get; set; }
        public float simulationSpeed { get; set; }
        public MinMaxGradient startColor { get; set; }
        public MinMaxCurve startDelay { get; set; }
        public float startDelayMultiplier { get; set; }
        public MinMaxCurve startLifetime { get; set; }
        public float startLifetimeMultiplier { get; set; }
        public MinMaxCurve startRotation { get; set; }
        public bool startRotation3D { get; set; }
        public float startRotationMultiplier { get; set; }
        public MinMaxCurve startRotationX { get; set; }
        public float startRotationXMultiplier { get; set; }
        public MinMaxCurve startRotationY { get; set; }
        public float startRotationYMultiplier { get; set; }
        public MinMaxCurve startRotationZ { get; set; }
        public float startRotationZMultiplier { get; set; }
        public MinMaxCurve startSize { get; set; }
        public bool startSize3D { get; set; }
        public float startSizeMultiplier { get; set; }
        public MinMaxCurve startSizeX { get; set; }
        public float startSizeXMultiplier { get; set; }
        public MinMaxCurve startSizeY { get; set; }
        public float startSizeYMultiplier { get; set; }
        public MinMaxCurve startSizeZ { get; set; }
        public float startSizeZMultiplier { get; set; }
        public MinMaxCurve startSpeed { get; set; }
        public float startSpeedMultiplier { get; set; }
        public ParticleSystemStopAction stopAction { get; set; }
        public bool useUnscaledTime { get; set; }

    }

    public struct MinMaxCurve
    {
        public float constant { get; set; }
        public float constantMax { get; set; }
        public float constantMin { get; set; }
        public AnimationCurve curve { get; set; }
        public AnimationCurve curveMax { get; set; }
        public AnimationCurve curveMin { get; set; }
        public float curveMultiplier { get; set; }
        public float curveScalar { get; set; }
        public ParticleSystemCurveMode mode { get; set; }

        public MinMaxCurve(float constant);
        public MinMaxCurve(float min, float max);
        public MinMaxCurve(float multiplier, AnimationCurve curve);
        public MinMaxCurve(float multiplier, AnimationCurve min, AnimationCurve max);

        public float Evaluate(float time);
        public float Evaluate(float time, float lerpFactor);

    }

    public struct MinMaxGradient
    {
        public Color color { get; set; }
        public Color colorMax { get; set; }
        public Color colorMin { get; set; }
        public Gradient gradient { get; set; }
        public Gradient gradientMax { get; set; }
        public Gradient gradientMin { get; set; }
        public ParticleSystemGradientMode mode { get; set; }

        public MinMaxGradient(Color color);
        public MinMaxGradient(Gradient gradient);
        public MinMaxGradient(Color min, Color max);
        public MinMaxGradient(Gradient min, Gradient max);

        public Color Evaluate(float time);
        public Color Evaluate(float time, float lerpFactor);

    }

    public struct NoiseModule
    {
        public bool damping { get; set; }
        public bool enabled { get; set; }
        public float frequency { get; set; }
        public int octaveCount { get; set; }
        public float octaveMultiplier { get; set; }
        public float octaveScale { get; set; }
        public MinMaxCurve positionAmount { get; set; }
        public ParticleSystemNoiseQuality quality { get; set; }
        public MinMaxCurve remap { get; set; }
        public bool remapEnabled { get; set; }
        public float remapMultiplier { get; set; }
        public MinMaxCurve remapX { get; set; }
        public float remapXMultiplier { get; set; }
        public MinMaxCurve remapY { get; set; }
        public float remapYMultiplier { get; set; }
        public MinMaxCurve remapZ { get; set; }
        public float remapZMultiplier { get; set; }
        public MinMaxCurve rotationAmount { get; set; }
        public MinMaxCurve scrollSpeed { get; set; }
        public float scrollSpeedMultiplier { get; set; }
        public bool separateAxes { get; set; }
        public MinMaxCurve sizeAmount { get; set; }
        public MinMaxCurve strength { get; set; }
        public float strengthMultiplier { get; set; }
        public MinMaxCurve strengthX { get; set; }
        public float strengthXMultiplier { get; set; }
        public MinMaxCurve strengthY { get; set; }
        public float strengthYMultiplier { get; set; }
        public MinMaxCurve strengthZ { get; set; }
        public float strengthZMultiplier { get; set; }

    }

    public struct Particle
    {
        public float angularVelocity { get; set; }
        public Vector3 angularVelocity3D { get; set; }
        public Vector3 animatedVelocity { get; }
        public Vector3 axisOfRotation { get; set; }
        public Color32 color { get; set; }
        public float lifetime { get; set; }
        public Vector3 position { get; set; }
        public uint randomSeed { get; set; }
        public float randomValue { get; set; }
        public float remainingLifetime { get; set; }
        public float rotation { get; set; }
        public Vector3 rotation3D { get; set; }
        public float size { get; set; }
        public Color32 startColor { get; set; }
        public float startLifetime { get; set; }
        public float startSize { get; set; }
        public Vector3 startSize3D { get; set; }
        public Vector3 totalVelocity { get; }
        public Vector3 velocity { get; set; }

        public Color32 GetCurrentColor(ParticleSystem system);
        public float GetCurrentSize(ParticleSystem system);
        public Vector3 GetCurrentSize3D(ParticleSystem system);
        public int GetMeshIndex(ParticleSystem system);
        public void SetMeshIndex(int index);

    }

    public struct PlaybackState
    {
    }

    public struct RotationBySpeedModule
    {
        public bool enabled { get; set; }
        public Vector2 range { get; set; }
        public bool separateAxes { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

    public struct RotationOverLifetimeModule
    {
        public bool enabled { get; set; }
        public bool separateAxes { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

    public struct ShapeModule
    {
        public bool alignToDirection { get; set; }
        public float angle { get; set; }
        public float arc { get; set; }
        public ParticleSystemShapeMultiModeValue arcMode { get; set; }
        public MinMaxCurve arcSpeed { get; set; }
        public float arcSpeedMultiplier { get; set; }
        public float arcSpread { get; set; }
        public Vector3 box { get; set; }
        public Vector3 boxThickness { get; set; }
        public float donutRadius { get; set; }
        public bool enabled { get; set; }
        public float length { get; set; }
        public Mesh mesh { get; set; }
        public int meshMaterialIndex { get; set; }
        public MeshRenderer meshRenderer { get; set; }
        public float meshScale { get; set; }
        public ParticleSystemMeshShapeType meshShapeType { get; set; }
        public ParticleSystemShapeMultiModeValue meshSpawnMode { get; set; }
        public MinMaxCurve meshSpawnSpeed { get; set; }
        public float meshSpawnSpeedMultiplier { get; set; }
        public float meshSpawnSpread { get; set; }
        public float normalOffset { get; set; }
        public Vector3 position { get; set; }
        public float radius { get; set; }
        public ParticleSystemShapeMultiModeValue radiusMode { get; set; }
        public MinMaxCurve radiusSpeed { get; set; }
        public float radiusSpeedMultiplier { get; set; }
        public float radiusSpread { get; set; }
        public float radiusThickness { get; set; }
        public bool randomDirection { get; set; }
        public float randomDirectionAmount { get; set; }
        public float randomPositionAmount { get; set; }
        public Vector3 rotation { get; set; }
        public Vector3 scale { get; set; }
        public ParticleSystemShapeType shapeType { get; set; }
        public SkinnedMeshRenderer skinnedMeshRenderer { get; set; }
        public float sphericalDirectionAmount { get; set; }
        public Sprite sprite { get; set; }
        public SpriteRenderer spriteRenderer { get; set; }
        public Texture2D texture { get; set; }
        public bool textureAlphaAffectsParticles { get; set; }
        public bool textureBilinearFiltering { get; set; }
        public ParticleSystemShapeTextureChannel textureClipChannel { get; set; }
        public float textureClipThreshold { get; set; }
        public bool textureColorAffectsParticles { get; set; }
        public int textureUVChannel { get; set; }
        public bool useMeshColors { get; set; }
        public bool useMeshMaterialIndex { get; set; }

    }

    public struct SizeBySpeedModule
    {
        public bool enabled { get; set; }
        public Vector2 range { get; set; }
        public bool separateAxes { get; set; }
        public MinMaxCurve size { get; set; }
        public float sizeMultiplier { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

    public struct SizeOverLifetimeModule
    {
        public bool enabled { get; set; }
        public bool separateAxes { get; set; }
        public MinMaxCurve size { get; set; }
        public float sizeMultiplier { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

    public struct SubEmittersModule
    {
        public ParticleSystem birth0 { get; set; }
        public ParticleSystem birth1 { get; set; }
        public ParticleSystem collision0 { get; set; }
        public ParticleSystem collision1 { get; set; }
        public ParticleSystem death0 { get; set; }
        public ParticleSystem death1 { get; set; }
        public bool enabled { get; set; }
        public int subEmittersCount { get; }

        public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties);
        public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties, float emitProbability);
        public float GetSubEmitterEmitProbability(int index);
        public ParticleSystemSubEmitterProperties GetSubEmitterProperties(int index);
        public ParticleSystem GetSubEmitterSystem(int index);
        public ParticleSystemSubEmitterType GetSubEmitterType(int index);
        public void RemoveSubEmitter(int index);
        public void SetSubEmitterEmitProbability(int index, float emitProbability);
        public void SetSubEmitterProperties(int index, ParticleSystemSubEmitterProperties properties);
        public void SetSubEmitterSystem(int index, ParticleSystem subEmitter);
        public void SetSubEmitterType(int index, ParticleSystemSubEmitterType type);

    }

    public struct TextureSheetAnimationModule
    {
        public ParticleSystemAnimationType animation { get; set; }
        public int cycleCount { get; set; }
        public bool enabled { get; set; }
        public float flipU { get; set; }
        public float flipV { get; set; }
        public float fps { get; set; }
        public MinMaxCurve frameOverTime { get; set; }
        public float frameOverTimeMultiplier { get; set; }
        public ParticleSystemAnimationMode mode { get; set; }
        public int numTilesX { get; set; }
        public int numTilesY { get; set; }
        public int rowIndex { get; set; }
        public ParticleSystemAnimationRowMode rowMode { get; set; }
        public Vector2 speedRange { get; set; }
        public int spriteCount { get; }
        public MinMaxCurve startFrame { get; set; }
        public float startFrameMultiplier { get; set; }
        public ParticleSystemAnimationTimeMode timeMode { get; set; }
        public bool useRandomRow { get; set; }
        public Rendering.UVChannelFlags uvChannelMask { get; set; }

        public void AddSprite(Sprite sprite);
        public Sprite GetSprite(int index);
        public void RemoveSprite(int index);
        public void SetSprite(int index, Sprite sprite);

    }

    public struct TrailModule
    {
        public bool attachRibbonsToTransform { get; set; }
        public MinMaxGradient colorOverLifetime { get; set; }
        public MinMaxGradient colorOverTrail { get; set; }
        public bool dieWithParticles { get; set; }
        public bool enabled { get; set; }
        public bool generateLightingData { get; set; }
        public bool inheritParticleColor { get; set; }
        public MinMaxCurve lifetime { get; set; }
        public float lifetimeMultiplier { get; set; }
        public float minVertexDistance { get; set; }
        public ParticleSystemTrailMode mode { get; set; }
        public float ratio { get; set; }
        public int ribbonCount { get; set; }
        public float shadowBias { get; set; }
        public bool sizeAffectsLifetime { get; set; }
        public bool sizeAffectsWidth { get; set; }
        public bool splitSubEmitterRibbons { get; set; }
        public ParticleSystemTrailTextureMode textureMode { get; set; }
        public MinMaxCurve widthOverTrail { get; set; }
        public float widthOverTrailMultiplier { get; set; }
        public bool worldSpace { get; set; }

    }

    public struct Trails
    {
    }

    public struct TriggerModule
    {
        public bool enabled { get; set; }
        public ParticleSystemOverlapAction enter { get; set; }
        public ParticleSystemOverlapAction exit { get; set; }
        public ParticleSystemOverlapAction inside { get; set; }
        public int maxColliderCount { get; }
        public ParticleSystemOverlapAction outside { get; set; }
        public float radiusScale { get; set; }

        public Component GetCollider(int index);
        public void SetCollider(int index, Component collider);

    }

    public struct VelocityOverLifetimeModule
    {
        public bool enabled { get; set; }
        public MinMaxCurve orbitalOffsetX { get; set; }
        public float orbitalOffsetXMultiplier { get; set; }
        public MinMaxCurve orbitalOffsetY { get; set; }
        public float orbitalOffsetYMultiplier { get; set; }
        public MinMaxCurve orbitalOffsetZ { get; set; }
        public float orbitalOffsetZMultiplier { get; set; }
        public MinMaxCurve orbitalX { get; set; }
        public float orbitalXMultiplier { get; set; }
        public MinMaxCurve orbitalY { get; set; }
        public float orbitalYMultiplier { get; set; }
        public MinMaxCurve orbitalZ { get; set; }
        public float orbitalZMultiplier { get; set; }
        public MinMaxCurve radial { get; set; }
        public float radialMultiplier { get; set; }
        public ParticleSystemSimulationSpace space { get; set; }
        public MinMaxCurve speedModifier { get; set; }
        public float speedModifierMultiplier { get; set; }
        public MinMaxCurve x { get; set; }
        public float xMultiplier { get; set; }
        public MinMaxCurve y { get; set; }
        public float yMultiplier { get; set; }
        public MinMaxCurve z { get; set; }
        public float zMultiplier { get; set; }

    }

}

}
