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
    public class TargetCamera : Camera
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
        private Vector3 __cameraDirection;
        public Vector3 cameraDirection
        {
            get
            {
            if(__cameraDirection == null)
            {
                __cameraDirection = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "cameraDirection",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __cameraDirection;
            }
            set
            {
__cameraDirection = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraDirection",
                    value
                );
            }
        }

        private Vector2 __cameraRotation;
        public Vector2 cameraRotation
        {
            get
            {
            if(__cameraRotation == null)
            {
                __cameraRotation = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "cameraRotation",
                    (entity) =>
                    {
                        return new Vector2(entity);
                    }
                );
            }
            return __cameraRotation;
            }
            set
            {
__cameraRotation = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cameraRotation",
                    value
                );
            }
        }

        
        public bool updateUpVectorFromRotation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "updateUpVectorFromRotation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "updateUpVectorFromRotation",
                    value
                );
            }
        }

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __rotation;
            }
            set
            {
__rotation = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        private Quaternion __rotationQuaternion;
        public Quaternion rotationQuaternion
        {
            get
            {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "rotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __rotationQuaternion;
            }
            set
            {
__rotationQuaternion = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
            }
        }

        
        public decimal speed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "speed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "speed",
                    value
                );
            }
        }

        
        public bool noRotationConstraint
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "noRotationConstraint"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "noRotationConstraint",
                    value
                );
            }
        }

        
        public CachedEntity lockedTarget
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "lockedTarget"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lockedTarget",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TargetCamera() : base() { }

        public TargetCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TargetCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "TargetCamera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Vector3 getFrontPosition(decimal distance)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getFrontPosition" }, distance
                }
            );
        }

        public Camera storeState()
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public void setTarget(Vector3 target)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTarget" }, target
                }
            );
        }

        public Vector3 getTarget()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTarget" }
                }
            );
        }

        public Camera createRigCamera(string name, decimal cameraIndex)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}