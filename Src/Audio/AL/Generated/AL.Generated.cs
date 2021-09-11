//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Dissonance.Framework.Audio
{
    using System.Runtime.InteropServices;
    
    public static partial class AL
    {
        /// <summary>
        /// Doppler scale.
        /// Type:    ALfloat
        /// Range:   [0.0 - ]
        /// Default: 1.0
        /// </summary>
        /// <remarks>
        /// Scale for source and listener velocities.
        /// </remarks>
        [DllImport(Library, EntryPoint = "alDopplerFactor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DopplerFactor(float value);
        
        /// <summary>
        /// Doppler velocity (deprecated).
        /// </summary>
        /// <remarks>
        /// A multiplier applied to the Speed of Sound.
        /// </remarks>
        [DllImport(Library, EntryPoint = "alDopplerVelocity", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DopplerVelocity(float value);
        
        /// <summary>
        /// Speed of Sound, in units per second.
        /// Type:    ALfloat
        /// Range:   [0.0001 - ]
        /// Default: 343.3
        /// </summary>
        /// <remarks>
        /// The speed at which sound waves are assumed to travel, when calculating the
        /// doppler effect.
        /// </remarks>
        [DllImport(Library, EntryPoint = "alSpeedOfSound", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SpeedOfSound(float value);
        
        /// <summary>
        /// Distance attenuation model.
        /// Type:    ALint
        /// Range:   [AL_NONE, AL_INVERSE_DISTANCE, AL_INVERSE_DISTANCE_CLAMPED,
        /// AL_LINEAR_DISTANCE, AL_LINEAR_DISTANCE_CLAMPED,
        /// AL_EXPONENT_DISTANCE, AL_EXPONENT_DISTANCE_CLAMPED]
        /// Default: AL_INVERSE_DISTANCE_CLAMPED
        /// </summary>
        /// <remarks>
        /// The model by which sources attenuate with distance.None     - No distance attenuation.
        /// Inverse  - Doubling the distance halves the source gain.
        /// Linear   - Linear gain scaling between the reference and max distances.
        /// Exponent - Exponential gain dropoff.Clamped variations work like the non-clamped counterparts, except the
        /// distance calculated is clamped between the reference and max distances.
        /// </remarks>
        [DllImport(Library, EntryPoint = "alDistanceModel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DistanceModel(int distanceModel);
        
        /// <summary>
        /// Renderer State management.
        /// </summary>
        [DllImport(Library, EntryPoint = "alEnable", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Enable(int capability);
        
        /// <summary>
        /// Renderer State management.
        /// </summary>
        [DllImport(Library, EntryPoint = "alDisable", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Disable(int capability);
        
        /// <summary>
        /// Renderer State management.
        /// </summary>
        [DllImport(Library, EntryPoint = "alIsEnabled", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool IsEnabled(int capability);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetString", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.LPStr)]
        public static extern string GetString(StateString param);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBooleanv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBoolean(int param, [MarshalAs(UnmanagedType.I1)]
        bool[] values);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetIntegerv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetInteger(int param, int[] values);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetFloatv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetFloat(int param, float[] values);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetDoublev", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetDouble(int param, double[] values);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBoolean", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool GetBoolean(int param);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetInteger", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetInteger(StateInt param);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetFloat", CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetFloat(StateFloat param);
        
        /// <summary>
        /// State retrieval.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetDouble", CallingConvention = CallingConvention.Cdecl)]
        public static extern double GetDouble(StateDouble param);
        
        /// <summary>
        /// Obtain the first error generated in the AL context since the last check.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetError", CallingConvention = CallingConvention.Cdecl)]
        public static extern AudioError GetError();
        
        /// <summary>
        /// Query for the presence of an extension on the AL context.
        /// </summary>
        [DllImport(Library, EntryPoint = "alIsExtensionPresent", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool IsExtensionPresent([MarshalAs(UnmanagedType.LPStr)]
        string extname);
        
        /// <summary>
        /// Retrieve the address of a function. The returned function may be context-
        /// specific.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetProcAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)]
        string fname);
        
        /// <summary>
        /// Retrieve the value of an enum. The returned value may be context-specific.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetEnumValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetEnumValue([MarshalAs(UnmanagedType.LPStr)]
        string ename);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListenerf", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(ListenerFloat param, float value);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListener3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(ListenerFloat3 param, float value1, float value2, float value3);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListenerfv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(ListenerFloatArray param, float[] values);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListeneri", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(int param, int value);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListener3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(int param, int value1, int value2, int value3);
        
        /// <summary>
        /// Set Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alListeneriv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Listener(int param, int[] values);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListenerf", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(ListenerFloat param, out float value);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListener3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(ListenerFloat3 param, ref float value1, ref float value2, ref float value3);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListenerfv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(ListenerFloatArray param, float[] values);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListeneri", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(int param, out int value);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListener3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(int param, ref int value1, ref int value2, ref int value3);
        
        /// <summary>
        /// Get Listener parameters
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetListeneriv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetListener(int param, int[] values);
        
        /// <summary>
        /// Create Source objects.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGenSources", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GenSources(int n, ref uint sources);
        
        /// <summary>
        /// Delete Source objects.
        /// </summary>
        [DllImport(Library, EntryPoint = "alDeleteSources", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteSources(int n, ref uint sources);
        
        /// <summary>
        /// Verify a handle is a valid Source.
        /// </summary>
        [DllImport(Library, EntryPoint = "alIsSource", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool IsSource(uint source);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcef", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, SourceFloat param, float value);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSource3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, int param, float value1, float value2, float value3);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcefv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, int param, float[] values);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcei", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, SourceInt param, int value);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSource3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, int param, int value1, int value2, int value3);
        
        /// <summary>
        /// Set Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Source(uint source, int param, int[] values);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSourcef", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, SourceFloat param, out float value);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSource3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, int param, ref float value1, ref float value2, ref float value3);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSourcefv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, int param, float[] values);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSourcei", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, GetSourceInt param, out int value);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSource3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, int param, ref int value1, ref int value2, ref int value3);
        
        /// <summary>
        /// Get Source parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetSourceiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSource(uint source, int param, int[] values);
        
        /// <summary>
        /// Play, replay, or resume (if paused) a list of Sources
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcePlayv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourcePlay(int n, uint[] sources);
        
        /// <summary>
        /// Stop a list of Sources
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceStopv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceStop(int n, uint[] sources);
        
        /// <summary>
        /// Rewind a list of Sources
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceRewindv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceRewind(int n, uint[] sources);
        
        /// <summary>
        /// Pause a list of Sources
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcePausev", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourcePause(int n, uint[] sources);
        
        /// <summary>
        /// Play, replay, or resume a Source
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcePlay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourcePlay(uint source);
        
        /// <summary>
        /// Stop a Source
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceStop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceStop(uint source);
        
        /// <summary>
        /// Rewind a Source (set playback postiton to beginning)
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceRewind", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceRewind(uint source);
        
        /// <summary>
        /// Pause a Source
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourcePause", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourcePause(uint source);
        
        /// <summary>
        /// Queue buffers onto a source
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceQueueBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceQueueBuffers(uint source, int nb, ref uint buffers);
        
        /// <summary>
        /// Unqueue processed buffers from a source
        /// </summary>
        [DllImport(Library, EntryPoint = "alSourceUnqueueBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SourceUnqueueBuffers(uint source, int nb, ref uint buffers);
        
        /// <summary>
        /// Create Buffer objects
        /// </summary>
        [DllImport(Library, EntryPoint = "alGenBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GenBuffers(int n, ref uint buffers);
        
        /// <summary>
        /// Delete Buffer objects
        /// </summary>
        [DllImport(Library, EntryPoint = "alDeleteBuffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteBuffers(int n, ref uint buffers);
        
        /// <summary>
        /// Verify a handle is a valid Buffer
        /// </summary>
        [DllImport(Library, EntryPoint = "alIsBuffer", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool IsBuffer(uint buffer);
        
        /// <summary>
        /// Specifies the data to be copied into a buffer
        /// </summary>
        [DllImport(Library, EntryPoint = "alBufferData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void BufferData(uint buffer, BufferFormat format, IntPtr data, int size, int freq);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBufferf", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, float value);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBuffer3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, float value1, float value2, float value3);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBufferfv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, float[] values);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBufferi", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, int value);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBuffer3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, int value1, int value2, int value3);
        
        /// <summary>
        /// Set Buffer parameters,
        /// </summary>
        [DllImport(Library, EntryPoint = "alBufferiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Buffer(uint buffer, int param, int[] values);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBufferf", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, int param, out float value);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBuffer3f", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, int param, ref float value1, ref float value2, ref float value3);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBufferfv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, int param, float[] values);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBufferi", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, GetBufferInt param, out int value);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBuffer3i", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, int param, ref int value1, ref int value2, ref int value3);
        
        /// <summary>
        /// Get Buffer parameters.
        /// </summary>
        [DllImport(Library, EntryPoint = "alGetBufferiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBuffer(uint buffer, int param, int[] values);
    }
}
