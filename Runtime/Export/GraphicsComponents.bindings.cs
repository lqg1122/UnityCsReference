// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEngine.Scripting;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/OcclusionPortal.h")]
    public sealed partial class OcclusionPortal : Component
    {
        [NativeProperty("IsOpen")] public extern bool open { get; set; }
    }

    [NativeHeader("Runtime/Camera/Flare.h")]
    public sealed partial class Flare : Object
    {
    }

    [NativeHeader("Runtime/Camera/Flare.h")]
    public sealed partial class LensFlare : Behaviour
    {
        extern public float brightness { get; set; }
        extern public float fadeSpeed  { get; set; }
        extern public Color color      { get; set; }
        extern public Flare flare      { get; set; }
    }

    [NativeHeader("Runtime/Camera/Projector.h")]
    public sealed partial class Projector : Behaviour
    {
        extern public float nearClipPlane    { get; set; }
        extern public float farClipPlane     { get; set; }
        extern public float fieldOfView      { get; set; }
        extern public float aspectRatio      { get; set; }
        extern public bool  orthographic     { get; set; }
        extern public float orthographicSize { get; set; }
        extern public int   ignoreLayers     { get; set; }
    }

    [RequireComponent(typeof(Transform))]
    [NativeHeader("Runtime/Camera/Light.h")]
    public sealed partial class Light : Behaviour
    {
        [NativeProperty("LightType")] extern public LightType type { get; set; }

        extern public Color color            { get; set; }
        extern public float colorTemperature { get; set; }
        extern public float intensity        { get; set; }
        extern public float bounceIntensity  { get; set; }

        extern public int   shadowCustomResolution { get; set; }
        extern public float shadowBias             { get; set; }
        extern public float shadowNormalBias       { get; set; }
        extern public float shadowNearPlane        { get; set; }

        extern public float range { get; set; }
        extern public Flare flare { get; set; }

        extern public bool alreadyLightmapped {[NativeName("IsActuallyBaked")] get; [NativeName("SetIsBakedFromScript")] set; }
        extern public bool isBaked            {[NativeName("IsActuallyBaked")] get; }
        [NativeProperty("CullingMask")] extern public int cullingMask { get; set; }
    }
}
