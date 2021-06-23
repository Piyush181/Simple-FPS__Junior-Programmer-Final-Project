// GENERATED AUTOMATICALLY FROM 'Assets/Input Assets/GunControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GunControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GunControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GunControls"",
    ""maps"": [
        {
            ""name"": ""AK 47"",
            ""id"": ""2ddc0eb1-a750-4809-9de6-9bcb6e7da11d"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a7e4d72c-9d43-4ed6-ace4-1aaee8ee6100"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""418e12a9-3346-4c30-b6a5-93813d8263b5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // AK 47
        m_AK47 = asset.FindActionMap("AK 47", throwIfNotFound: true);
        m_AK47_Shoot = m_AK47.FindAction("Shoot", throwIfNotFound: true);
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

    // AK 47
    private readonly InputActionMap m_AK47;
    private IAK47Actions m_AK47ActionsCallbackInterface;
    private readonly InputAction m_AK47_Shoot;
    public struct AK47Actions
    {
        private @GunControls m_Wrapper;
        public AK47Actions(@GunControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_AK47_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_AK47; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AK47Actions set) { return set.Get(); }
        public void SetCallbacks(IAK47Actions instance)
        {
            if (m_Wrapper.m_AK47ActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_AK47ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_AK47ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_AK47ActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_AK47ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public AK47Actions @AK47 => new AK47Actions(this);
    public interface IAK47Actions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
}
