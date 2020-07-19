/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Vector2WithInfo : CachedEntityObject
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
        
        public decimal buttonIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "buttonIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "buttonIndex",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Vector2WithInfo() : base() { } 

        public Vector2WithInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Vector2WithInfo(
            Vector2 source, System.Nullable<decimal> buttonIndex = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Vector2WithInfo" },
                source, buttonIndex
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}