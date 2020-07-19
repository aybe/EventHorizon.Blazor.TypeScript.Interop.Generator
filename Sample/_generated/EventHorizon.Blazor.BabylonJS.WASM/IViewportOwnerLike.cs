/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IViewportOwnerLike : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IViewportOwnerLikeCachedEntity : CachedEntityObject, IViewportOwnerLike
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
        private IViewportLikeCachedEntity __viewport;
        public IViewportLikeCachedEntity viewport
        {
            get
            {
            if(__viewport == null)
            {
                __viewport = EventHorizonBlazorInteropt.GetClass<IViewportLikeCachedEntity>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new IViewportLikeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewport;
            }
            set
            {
__viewport = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "viewport",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IViewportOwnerLikeCachedEntity() : base() { }

        public IViewportOwnerLikeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}