//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/Input/DroneInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DroneInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DroneInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DroneInputs"",
    ""maps"": [
        {
            ""name"": ""Drone"",
            ""id"": ""3df79d73-f887-4d3e-aa43-e247525aeebe"",
            ""actions"": [
                {
                    ""name"": ""Cyclic"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df962ffd-6447-441c-bc71-dce6847bf9f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pedals"",
                    ""type"": ""PassThrough"",
                    ""id"": ""62ccce58-b766-431e-84d9-04096f2415c4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""dcd8e936-708f-4bd0-a569-8bfeb4c5f016"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""8e2c4c0b-7133-4172-bdad-9498e3ab30b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f7f07cfb-c409-4803-912b-cea19d728e46"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""31278480-5474-4269-8183-92eb2616708a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""02fca960-2c46-43a0-b161-5398358ea042"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6828af39-122d-4e97-b9b7-dc1f4da3c8e2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b0d088b8-f468-4fa6-963e-5e6a8d7f14b7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LStick"",
                    ""id"": ""54a1ea7c-f2cb-47ac-a02d-201196e253c7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe6e1a15-a1b9-4276-8a65-f2cf95830a3d"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fca38b1f-4190-4874-a8a6-1c273ce967f2"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""011e6e4e-fd3a-4402-8550-2cb4af0e27e5"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d89e0459-e7e7-4f74-80d1-1ef2a912f3a3"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""ca947cc2-4a58-48bc-a726-c022a9f9ad20"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7b35a8d0-c5c3-4a58-9794-f5382e64e14b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""38484c0e-82df-4262-82fa-e38ad603f586"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RStick"",
                    ""id"": ""aff66617-5397-479f-a821-e68a00132201"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""65655409-c36c-4d9c-ba24-a6fccc32d1ea"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c0f85056-fac4-45d8-9abc-de63ce138ba9"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""b5633b01-68f5-4610-8642-79f295c76a21"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""de158ec3-e29f-4fb6-9c75-716f82ecdbf2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95afe859-f0e9-4dd7-ba84-db53ccd5fa85"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RStick"",
                    ""id"": ""c5e5141e-89e2-4dd5-9aed-a8de7ad7db33"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b9878c7d-031d-40ef-b3dd-0e6fdf1b4fb8"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b6ca38e8-bcc0-4496-9351-03b81aa404f4"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e823c2c8-b955-46c4-90e4-7542294d38f8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""486510c9-8580-4538-a5cf-76329badc293"",
            ""actions"": [
                {
                    ""name"": ""RightLeftRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a620fb08-11b8-435f-8afe-d8e32148c591"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UpDownRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a961a7eb-4014-45f0-9667-13c629e4f0e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9580bd3e-ad19-4ffd-884d-cb237b7bc33f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""b5f1b0bf-8b85-4dd2-b733-05d9488a5429"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""067df0a1-c428-4dd1-b50b-cde9a577c02b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeftRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d5e0155d-0ab0-4610-b762-57025abf775d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeftRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""57c58236-eb82-4600-89f7-72b4d21b7774"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeftRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""cf48c228-fad9-42a7-baa6-4e594e12d453"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDownRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b6367450-79dd-4fa5-adba-ae90301a350a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDownRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fa0b1899-1eea-4001-b07e-da9743eba9b8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDownRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""30b26274-41b9-47ad-a6c9-09c9e2614a88"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""532ae49e-8c35-49e9-b1aa-cefcf8d01046"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""83b371ba-ab1e-4c2c-8941-c92d902b04e3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8a94fda-9b28-4845-83a6-bf5ee4f6a106"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Cyclic = m_Drone.FindAction("Cyclic", throwIfNotFound: true);
        m_Drone_Pedals = m_Drone.FindAction("Pedals", throwIfNotFound: true);
        m_Drone_Throttle = m_Drone.FindAction("Throttle", throwIfNotFound: true);
        m_Drone_Switch = m_Drone.FindAction("Switch", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_RightLeftRotation = m_Camera.FindAction("RightLeftRotation", throwIfNotFound: true);
        m_Camera_UpDownRotation = m_Camera.FindAction("UpDownRotation", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        m_Camera_Switch = m_Camera.FindAction("Switch", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Drone
    private readonly InputActionMap m_Drone;
    private List<IDroneActions> m_DroneActionsCallbackInterfaces = new List<IDroneActions>();
    private readonly InputAction m_Drone_Cyclic;
    private readonly InputAction m_Drone_Pedals;
    private readonly InputAction m_Drone_Throttle;
    private readonly InputAction m_Drone_Switch;
    public struct DroneActions
    {
        private @DroneInputs m_Wrapper;
        public DroneActions(@DroneInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cyclic => m_Wrapper.m_Drone_Cyclic;
        public InputAction @Pedals => m_Wrapper.m_Drone_Pedals;
        public InputAction @Throttle => m_Wrapper.m_Drone_Throttle;
        public InputAction @Switch => m_Wrapper.m_Drone_Switch;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void AddCallbacks(IDroneActions instance)
        {
            if (instance == null || m_Wrapper.m_DroneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DroneActionsCallbackInterfaces.Add(instance);
            @Cyclic.started += instance.OnCyclic;
            @Cyclic.performed += instance.OnCyclic;
            @Cyclic.canceled += instance.OnCyclic;
            @Pedals.started += instance.OnPedals;
            @Pedals.performed += instance.OnPedals;
            @Pedals.canceled += instance.OnPedals;
            @Throttle.started += instance.OnThrottle;
            @Throttle.performed += instance.OnThrottle;
            @Throttle.canceled += instance.OnThrottle;
            @Switch.started += instance.OnSwitch;
            @Switch.performed += instance.OnSwitch;
            @Switch.canceled += instance.OnSwitch;
        }

        private void UnregisterCallbacks(IDroneActions instance)
        {
            @Cyclic.started -= instance.OnCyclic;
            @Cyclic.performed -= instance.OnCyclic;
            @Cyclic.canceled -= instance.OnCyclic;
            @Pedals.started -= instance.OnPedals;
            @Pedals.performed -= instance.OnPedals;
            @Pedals.canceled -= instance.OnPedals;
            @Throttle.started -= instance.OnThrottle;
            @Throttle.performed -= instance.OnThrottle;
            @Throttle.canceled -= instance.OnThrottle;
            @Switch.started -= instance.OnSwitch;
            @Switch.performed -= instance.OnSwitch;
            @Switch.canceled -= instance.OnSwitch;
        }

        public void RemoveCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDroneActions instance)
        {
            foreach (var item in m_Wrapper.m_DroneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DroneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
    private readonly InputAction m_Camera_RightLeftRotation;
    private readonly InputAction m_Camera_UpDownRotation;
    private readonly InputAction m_Camera_Zoom;
    private readonly InputAction m_Camera_Switch;
    public struct CameraActions
    {
        private @DroneInputs m_Wrapper;
        public CameraActions(@DroneInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightLeftRotation => m_Wrapper.m_Camera_RightLeftRotation;
        public InputAction @UpDownRotation => m_Wrapper.m_Camera_UpDownRotation;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputAction @Switch => m_Wrapper.m_Camera_Switch;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void AddCallbacks(ICameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
            @RightLeftRotation.started += instance.OnRightLeftRotation;
            @RightLeftRotation.performed += instance.OnRightLeftRotation;
            @RightLeftRotation.canceled += instance.OnRightLeftRotation;
            @UpDownRotation.started += instance.OnUpDownRotation;
            @UpDownRotation.performed += instance.OnUpDownRotation;
            @UpDownRotation.canceled += instance.OnUpDownRotation;
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
            @Switch.started += instance.OnSwitch;
            @Switch.performed += instance.OnSwitch;
            @Switch.canceled += instance.OnSwitch;
        }

        private void UnregisterCallbacks(ICameraActions instance)
        {
            @RightLeftRotation.started -= instance.OnRightLeftRotation;
            @RightLeftRotation.performed -= instance.OnRightLeftRotation;
            @RightLeftRotation.canceled -= instance.OnRightLeftRotation;
            @UpDownRotation.started -= instance.OnUpDownRotation;
            @UpDownRotation.performed -= instance.OnUpDownRotation;
            @UpDownRotation.canceled -= instance.OnUpDownRotation;
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
            @Switch.started -= instance.OnSwitch;
            @Switch.performed -= instance.OnSwitch;
            @Switch.canceled -= instance.OnSwitch;
        }

        public void RemoveCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IDroneActions
    {
        void OnCyclic(InputAction.CallbackContext context);
        void OnPedals(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnSwitch(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnRightLeftRotation(InputAction.CallbackContext context);
        void OnUpDownRotation(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnSwitch(InputAction.CallbackContext context);
    }
}