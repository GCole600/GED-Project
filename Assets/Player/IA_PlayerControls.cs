//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Player/IA_PlayerControls.inputactions
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

public partial class @IA_PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IA_PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""IA_PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""018b5687-d6bd-4880-869e-cc6704a84fae"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ce233a5f-21da-428a-986a-e2f9c5ca7216"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""93ea762b-767e-4900-b97d-6c865c668689"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""018a1b0b-03a9-4a40-a7e8-2d2ca872c4a0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1ff664df-b1f3-4f5e-b522-857bd2c09ecc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""16880322-9331-4c1b-9c70-82101b4e5790"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84ee768f-1bdf-43d8-a1e1-b160d5db54ec"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c9381b7-cbde-47c5-afb7-ff90039392d2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cf346964-b151-450e-aa6e-e8570e2e61e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6200629b-2890-498a-93dd-1d1b6c955e4d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ce618bdc-16db-44dd-824d-8c612669992c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35eb2a87-87db-459b-8381-bd08a60f0491"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13f93c03-3dd4-4b72-ad38-f7cc023f8026"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_HorizontalMovement = m_GroundMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private List<IGroundMovementActions> m_GroundMovementActionsCallbackInterfaces = new List<IGroundMovementActions>();
    private readonly InputAction m_GroundMovement_HorizontalMovement;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    public struct GroundMovementActions
    {
        private @IA_PlayerControls m_Wrapper;
        public GroundMovementActions(@IA_PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GroundMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void AddCallbacks(IGroundMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Add(instance);
            @HorizontalMovement.started += instance.OnHorizontalMovement;
            @HorizontalMovement.performed += instance.OnHorizontalMovement;
            @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseX.started += instance.OnMouseX;
            @MouseX.performed += instance.OnMouseX;
            @MouseX.canceled += instance.OnMouseX;
            @MouseY.started += instance.OnMouseY;
            @MouseY.performed += instance.OnMouseY;
            @MouseY.canceled += instance.OnMouseY;
        }

        private void UnregisterCallbacks(IGroundMovementActions instance)
        {
            @HorizontalMovement.started -= instance.OnHorizontalMovement;
            @HorizontalMovement.performed -= instance.OnHorizontalMovement;
            @HorizontalMovement.canceled -= instance.OnHorizontalMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseX.started -= instance.OnMouseX;
            @MouseX.performed -= instance.OnMouseX;
            @MouseX.canceled -= instance.OnMouseX;
            @MouseY.started -= instance.OnMouseY;
            @MouseY.performed -= instance.OnMouseY;
            @MouseY.canceled -= instance.OnMouseY;
        }

        public void RemoveCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGroundMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_GroundMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);
    public interface IGroundMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}
