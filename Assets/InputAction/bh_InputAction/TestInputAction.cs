//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputAction/TestInputAction.inputactions
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

public partial class @TestInputAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestInputAction"",
    ""maps"": [
        {
            ""name"": ""TestPlayer"",
            ""id"": ""62069072-f4f4-4482-8488-0b4ec0599d46"",
            ""actions"": [
                {
                    ""name"": ""Action1"",
                    ""type"": ""Button"",
                    ""id"": ""ca1e7f0d-5376-412c-b182-cb1420a36fc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action2"",
                    ""type"": ""Button"",
                    ""id"": ""10722052-bbf2-4e96-9a23-9634543c3e27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action3"",
                    ""type"": ""Button"",
                    ""id"": ""33ae5d12-6ea4-4f56-98d3-c13043ff1e3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action4"",
                    ""type"": ""Button"",
                    ""id"": ""97fe97c0-6154-4ad5-bbda-8155b9658b8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action5"",
                    ""type"": ""Button"",
                    ""id"": ""2d897bf5-f84f-40f6-9426-64daf3e96845"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29d4e18d-eec9-4433-8345-bccb01ef092d"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""288b560f-6d4f-4c86-b0dd-ebaa20dca7a0"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b474bbb9-0298-4c45-bd35-9850d0dfa9b4"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Action3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2680384-40c3-4526-8f6d-71da294a23c1"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Action4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f49ea858-5573-4e60-80b7-0e54f11c52cd"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Action5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // TestPlayer
        m_TestPlayer = asset.FindActionMap("TestPlayer", throwIfNotFound: true);
        m_TestPlayer_Action1 = m_TestPlayer.FindAction("Action1", throwIfNotFound: true);
        m_TestPlayer_Action2 = m_TestPlayer.FindAction("Action2", throwIfNotFound: true);
        m_TestPlayer_Action3 = m_TestPlayer.FindAction("Action3", throwIfNotFound: true);
        m_TestPlayer_Action4 = m_TestPlayer.FindAction("Action4", throwIfNotFound: true);
        m_TestPlayer_Action5 = m_TestPlayer.FindAction("Action5", throwIfNotFound: true);
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

    // TestPlayer
    private readonly InputActionMap m_TestPlayer;
    private ITestPlayerActions m_TestPlayerActionsCallbackInterface;
    private readonly InputAction m_TestPlayer_Action1;
    private readonly InputAction m_TestPlayer_Action2;
    private readonly InputAction m_TestPlayer_Action3;
    private readonly InputAction m_TestPlayer_Action4;
    private readonly InputAction m_TestPlayer_Action5;
    public struct TestPlayerActions
    {
        private @TestInputAction m_Wrapper;
        public TestPlayerActions(@TestInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action1 => m_Wrapper.m_TestPlayer_Action1;
        public InputAction @Action2 => m_Wrapper.m_TestPlayer_Action2;
        public InputAction @Action3 => m_Wrapper.m_TestPlayer_Action3;
        public InputAction @Action4 => m_Wrapper.m_TestPlayer_Action4;
        public InputAction @Action5 => m_Wrapper.m_TestPlayer_Action5;
        public InputActionMap Get() { return m_Wrapper.m_TestPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestPlayerActions set) { return set.Get(); }
        public void SetCallbacks(ITestPlayerActions instance)
        {
            if (m_Wrapper.m_TestPlayerActionsCallbackInterface != null)
            {
                @Action1.started -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction1;
                @Action1.performed -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction1;
                @Action1.canceled -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction1;
                @Action2.started -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction2;
                @Action2.performed -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction2;
                @Action2.canceled -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction2;
                @Action3.started -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction3;
                @Action3.performed -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction3;
                @Action3.canceled -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction3;
                @Action4.started -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction4;
                @Action4.performed -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction4;
                @Action4.canceled -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction4;
                @Action5.started -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction5;
                @Action5.performed -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction5;
                @Action5.canceled -= m_Wrapper.m_TestPlayerActionsCallbackInterface.OnAction5;
            }
            m_Wrapper.m_TestPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action1.started += instance.OnAction1;
                @Action1.performed += instance.OnAction1;
                @Action1.canceled += instance.OnAction1;
                @Action2.started += instance.OnAction2;
                @Action2.performed += instance.OnAction2;
                @Action2.canceled += instance.OnAction2;
                @Action3.started += instance.OnAction3;
                @Action3.performed += instance.OnAction3;
                @Action3.canceled += instance.OnAction3;
                @Action4.started += instance.OnAction4;
                @Action4.performed += instance.OnAction4;
                @Action4.canceled += instance.OnAction4;
                @Action5.started += instance.OnAction5;
                @Action5.performed += instance.OnAction5;
                @Action5.canceled += instance.OnAction5;
            }
        }
    }
    public TestPlayerActions @TestPlayer => new TestPlayerActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    public interface ITestPlayerActions
    {
        void OnAction1(InputAction.CallbackContext context);
        void OnAction2(InputAction.CallbackContext context);
        void OnAction3(InputAction.CallbackContext context);
        void OnAction4(InputAction.CallbackContext context);
        void OnAction5(InputAction.CallbackContext context);
    }
}
