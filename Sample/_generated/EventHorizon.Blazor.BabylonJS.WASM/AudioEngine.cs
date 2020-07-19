/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class AudioEngine : CachedEntityObject, IAudioEngine
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private AudioContext __audioContext;
        public AudioContext audioContext
        {
            get
            {
            if(__audioContext == null)
            {
                __audioContext = EventHorizonBlazorInteropt.GetClass<AudioContext>(
                    this.___guid,
                    "audioContext",
                    (entity) =>
                    {
                        return new AudioContext() { ___guid = entity.___guid };
                    }
                );
            }
            return __audioContext;
            }
        }
        #endregion

        #region Properties
        
        public bool canUseWebAudio
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "canUseWebAudio"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "canUseWebAudio",
                    value
                );
            }
        }

        private GainNode __masterGain;
        public GainNode masterGain
        {
            get
            {
            if(__masterGain == null)
            {
                __masterGain = EventHorizonBlazorInteropt.GetClass<GainNode>(
                    this.___guid,
                    "masterGain",
                    (entity) =>
                    {
                        return new GainNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __masterGain;
            }
            set
            {
__masterGain = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "masterGain",
                    value
                );
            }
        }

        
        public bool WarnedWebAudioUnsupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "WarnedWebAudioUnsupported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "WarnedWebAudioUnsupported",
                    value
                );
            }
        }

        
        public bool isMP3supported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isMP3supported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isMP3supported",
                    value
                );
            }
        }

        
        public bool isOGGsupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isOGGsupported"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isOGGsupported",
                    value
                );
            }
        }

        
        public bool unlocked
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "unlocked"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "unlocked",
                    value
                );
            }
        }

        
        public bool useCustomUnlockedButton
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useCustomUnlockedButton"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useCustomUnlockedButton",
                    value
                );
            }
        }

        private Observable<AudioEngine> __onAudioUnlockedObservable;
        public Observable<AudioEngine> onAudioUnlockedObservable
        {
            get
            {
            if(__onAudioUnlockedObservable == null)
            {
                __onAudioUnlockedObservable = EventHorizonBlazorInteropt.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioUnlockedObservable;
            }
            set
            {
__onAudioUnlockedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAudioUnlockedObservable",
                    value
                );
            }
        }

        private Observable<AudioEngine> __onAudioLockedObservable;
        public Observable<AudioEngine> onAudioLockedObservable
        {
            get
            {
            if(__onAudioLockedObservable == null)
            {
                __onAudioLockedObservable = EventHorizonBlazorInteropt.GetClass<Observable<AudioEngine>>(
                    this.___guid,
                    "onAudioLockedObservable",
                    (entity) =>
                    {
                        return new Observable<AudioEngine>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAudioLockedObservable;
            }
            set
            {
__onAudioLockedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAudioLockedObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AudioEngine() : base() { }

        public AudioEngine(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AudioEngine(
            CachedEntity hostElement = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "AudioEngine" },
                hostElement
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void @lock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@lock" }
                }
            );
        }

        public void @unlock()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "@unlock" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public decimal getGlobalVolume()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getGlobalVolume" }
                }
            );
        }

        public void setGlobalVolume(decimal newVolume)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setGlobalVolume" }, newVolume
                }
            );
        }

        public void connectToAnalyser(Analyser analyser)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectToAnalyser" }, analyser
                }
            );
        }
        #endregion
    }
}