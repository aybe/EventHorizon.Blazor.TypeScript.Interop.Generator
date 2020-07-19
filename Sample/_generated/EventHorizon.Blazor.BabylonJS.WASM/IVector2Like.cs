/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IVector2Like : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IVector2LikeCachedEntity : CachedEntityObject, IVector2Like
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
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IVector2LikeCachedEntity() : base() { }

        public IVector2LikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}