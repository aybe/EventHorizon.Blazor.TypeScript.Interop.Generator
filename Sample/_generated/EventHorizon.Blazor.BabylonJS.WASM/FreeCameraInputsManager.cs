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
    public class FreeCameraInputsManager : CameraInputsManager<FreeCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public FreeCameraInputsManager() : base() { }

        public FreeCameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FreeCameraInputsManager(
            FreeCamera camera
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "FreeCameraInputsManager" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FreeCameraInputsManager addKeyboard()
        {
            return EventHorizonBlazorInteropt.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }

        public FreeCameraInputsManager addMouse(System.Nullable<bool> touchEnabled = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addMouse" }, touchEnabled
                }
            );
        }

        public FreeCameraInputsManager removeMouse()
        {
            return EventHorizonBlazorInteropt.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeMouse" }
                }
            );
        }

        public FreeCameraInputsManager addTouch()
        {
            return EventHorizonBlazorInteropt.FuncClass<FreeCameraInputsManager>(
                entity => new FreeCameraInputsManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addTouch" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }
        #endregion
    }
}