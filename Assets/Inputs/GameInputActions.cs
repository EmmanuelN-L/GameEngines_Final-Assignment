// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""Third Person"",
            ""id"": ""3e943393-834e-4b25-885a-2e2222109041"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""976ba715-1c5c-4fe9-a5c1-8e4b6024ae38"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b4fc071d-1a04-4b5f-86a0-1bc1ea81674e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""6439f132-a7bf-4c89-a989-73c73779c801"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""f4a1f6ac-34ce-4a9f-9dae-b540bb157da1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a6dd9b86-c2e8-4935-a009-19b408feb357"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""50fd76f9-8922-4045-9f43-97c92c0f657b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TakeDamage"",
                    ""type"": ""Button"",
                    ""id"": ""e146554c-4d6b-46be-8edf-a41bb66286f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""GainHealth"",
                    ""type"": ""Button"",
                    ""id"": ""1b25eb74-a203-470b-aa56-98128026b8b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""029f7c69-eeb1-4f9a-afba-312bffc8c123"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""f6d11594-98c2-4014-a798-ab0253e866b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""WeaponSwap1"",
                    ""type"": ""Button"",
                    ""id"": ""979ffbd4-5bf9-4558-b3f8-76375a24156d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""WeaponSwap2"",
                    ""type"": ""Button"",
                    ""id"": ""41de7a73-ad61-4b12-baef-dc819638d75e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""OpenShop"",
                    ""type"": ""Button"",
                    ""id"": ""c47e0df2-3121-47ee-8e2b-3fbab8dc29e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Increment"",
                    ""type"": ""Button"",
                    ""id"": ""9fe836c7-b80e-4ec0-b077-78176d91ad83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Decrement"",
                    ""type"": ""Button"",
                    ""id"": ""98ab1cb8-837d-4d41-82f7-e1219b0edfd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Heal"",
                    ""type"": ""Button"",
                    ""id"": ""bce9e232-d681-47d9-ad64-de65868ef511"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68e43f55-3500-49d3-84b8-05230dcaaec4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7707d65d-1d6d-4e47-99f7-bba564f31a86"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c22958f9-5554-4e6a-a201-82136ea16cac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10e9257c-961f-489a-8348-2d96c6e73704"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b3f5a560-d048-4d3a-8cfc-6ed0b3255c67"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""471a8d61-8782-40ff-bc9a-afa748bf12dc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9d17386-aed8-4879-b23c-05758fe316bc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""430ff6b1-31d0-444b-9b73-8b0bc58a16d4"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1788360a-8e5d-477e-88ea-b1ac6aab16cd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79c7f4bf-8d83-41a9-840a-36e7fc6c51ae"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""792d091a-21f6-4b9a-91a2-c61e9d39dd5f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fabcc77-415a-40b2-869f-91cf45c43d90"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GainHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16387cb8-fee8-4b66-9678-25a7c421eed4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0625485-2a8d-482e-ae91-2eaff864b74a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94fd3f92-f5c3-4dcf-9c66-07a3865ece24"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwap1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0016e28-0867-43c0-89ca-fc5cd49da1f7"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwap2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""273264eb-add1-4bdf-b311-73f53f6845f2"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenShop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5ba3cb5-0d6b-4403-9f07-855446bde03c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Increment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3d355de-28f8-42ab-8257-29665d0b6687"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Decrement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d3461a8-36d5-4697-9cb0-8e8542e96651"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Third Person
        m_ThirdPerson = asset.FindActionMap("Third Person", throwIfNotFound: true);
        m_ThirdPerson_Movement = m_ThirdPerson.FindAction("Movement", throwIfNotFound: true);
        m_ThirdPerson_Jump = m_ThirdPerson.FindAction("Jump", throwIfNotFound: true);
        m_ThirdPerson_Fire = m_ThirdPerson.FindAction("Fire", throwIfNotFound: true);
        m_ThirdPerson_Run = m_ThirdPerson.FindAction("Run", throwIfNotFound: true);
        m_ThirdPerson_Look = m_ThirdPerson.FindAction("Look", throwIfNotFound: true);
        m_ThirdPerson_Reload = m_ThirdPerson.FindAction("Reload", throwIfNotFound: true);
        m_ThirdPerson_TakeDamage = m_ThirdPerson.FindAction("TakeDamage", throwIfNotFound: true);
        m_ThirdPerson_GainHealth = m_ThirdPerson.FindAction("GainHealth", throwIfNotFound: true);
        m_ThirdPerson_Pause = m_ThirdPerson.FindAction("Pause", throwIfNotFound: true);
        m_ThirdPerson_Action = m_ThirdPerson.FindAction("Action", throwIfNotFound: true);
        m_ThirdPerson_WeaponSwap1 = m_ThirdPerson.FindAction("WeaponSwap1", throwIfNotFound: true);
        m_ThirdPerson_WeaponSwap2 = m_ThirdPerson.FindAction("WeaponSwap2", throwIfNotFound: true);
        m_ThirdPerson_OpenShop = m_ThirdPerson.FindAction("OpenShop", throwIfNotFound: true);
        m_ThirdPerson_Increment = m_ThirdPerson.FindAction("Increment", throwIfNotFound: true);
        m_ThirdPerson_Decrement = m_ThirdPerson.FindAction("Decrement", throwIfNotFound: true);
        m_ThirdPerson_Heal = m_ThirdPerson.FindAction("Heal", throwIfNotFound: true);
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

    // Third Person
    private readonly InputActionMap m_ThirdPerson;
    private IThirdPersonActions m_ThirdPersonActionsCallbackInterface;
    private readonly InputAction m_ThirdPerson_Movement;
    private readonly InputAction m_ThirdPerson_Jump;
    private readonly InputAction m_ThirdPerson_Fire;
    private readonly InputAction m_ThirdPerson_Run;
    private readonly InputAction m_ThirdPerson_Look;
    private readonly InputAction m_ThirdPerson_Reload;
    private readonly InputAction m_ThirdPerson_TakeDamage;
    private readonly InputAction m_ThirdPerson_GainHealth;
    private readonly InputAction m_ThirdPerson_Pause;
    private readonly InputAction m_ThirdPerson_Action;
    private readonly InputAction m_ThirdPerson_WeaponSwap1;
    private readonly InputAction m_ThirdPerson_WeaponSwap2;
    private readonly InputAction m_ThirdPerson_OpenShop;
    private readonly InputAction m_ThirdPerson_Increment;
    private readonly InputAction m_ThirdPerson_Decrement;
    private readonly InputAction m_ThirdPerson_Heal;
    public struct ThirdPersonActions
    {
        private @GameInputActions m_Wrapper;
        public ThirdPersonActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ThirdPerson_Movement;
        public InputAction @Jump => m_Wrapper.m_ThirdPerson_Jump;
        public InputAction @Fire => m_Wrapper.m_ThirdPerson_Fire;
        public InputAction @Run => m_Wrapper.m_ThirdPerson_Run;
        public InputAction @Look => m_Wrapper.m_ThirdPerson_Look;
        public InputAction @Reload => m_Wrapper.m_ThirdPerson_Reload;
        public InputAction @TakeDamage => m_Wrapper.m_ThirdPerson_TakeDamage;
        public InputAction @GainHealth => m_Wrapper.m_ThirdPerson_GainHealth;
        public InputAction @Pause => m_Wrapper.m_ThirdPerson_Pause;
        public InputAction @Action => m_Wrapper.m_ThirdPerson_Action;
        public InputAction @WeaponSwap1 => m_Wrapper.m_ThirdPerson_WeaponSwap1;
        public InputAction @WeaponSwap2 => m_Wrapper.m_ThirdPerson_WeaponSwap2;
        public InputAction @OpenShop => m_Wrapper.m_ThirdPerson_OpenShop;
        public InputAction @Increment => m_Wrapper.m_ThirdPerson_Increment;
        public InputAction @Decrement => m_Wrapper.m_ThirdPerson_Decrement;
        public InputAction @Heal => m_Wrapper.m_ThirdPerson_Heal;
        public InputActionMap Get() { return m_Wrapper.m_ThirdPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThirdPersonActions set) { return set.Get(); }
        public void SetCallbacks(IThirdPersonActions instance)
        {
            if (m_Wrapper.m_ThirdPersonActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Fire.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Run.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Look.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Reload.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnReload;
                @TakeDamage.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnTakeDamage;
                @TakeDamage.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnTakeDamage;
                @TakeDamage.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnTakeDamage;
                @GainHealth.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnGainHealth;
                @GainHealth.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnGainHealth;
                @GainHealth.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnGainHealth;
                @Pause.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnPause;
                @Action.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAction;
                @WeaponSwap1.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap1;
                @WeaponSwap1.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap1;
                @WeaponSwap1.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap1;
                @WeaponSwap2.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap2;
                @WeaponSwap2.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap2;
                @WeaponSwap2.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnWeaponSwap2;
                @OpenShop.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnOpenShop;
                @OpenShop.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnOpenShop;
                @OpenShop.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnOpenShop;
                @Increment.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnIncrement;
                @Increment.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnIncrement;
                @Increment.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnIncrement;
                @Decrement.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDecrement;
                @Decrement.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDecrement;
                @Decrement.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDecrement;
                @Heal.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnHeal;
                @Heal.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnHeal;
                @Heal.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnHeal;
            }
            m_Wrapper.m_ThirdPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @TakeDamage.started += instance.OnTakeDamage;
                @TakeDamage.performed += instance.OnTakeDamage;
                @TakeDamage.canceled += instance.OnTakeDamage;
                @GainHealth.started += instance.OnGainHealth;
                @GainHealth.performed += instance.OnGainHealth;
                @GainHealth.canceled += instance.OnGainHealth;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @WeaponSwap1.started += instance.OnWeaponSwap1;
                @WeaponSwap1.performed += instance.OnWeaponSwap1;
                @WeaponSwap1.canceled += instance.OnWeaponSwap1;
                @WeaponSwap2.started += instance.OnWeaponSwap2;
                @WeaponSwap2.performed += instance.OnWeaponSwap2;
                @WeaponSwap2.canceled += instance.OnWeaponSwap2;
                @OpenShop.started += instance.OnOpenShop;
                @OpenShop.performed += instance.OnOpenShop;
                @OpenShop.canceled += instance.OnOpenShop;
                @Increment.started += instance.OnIncrement;
                @Increment.performed += instance.OnIncrement;
                @Increment.canceled += instance.OnIncrement;
                @Decrement.started += instance.OnDecrement;
                @Decrement.performed += instance.OnDecrement;
                @Decrement.canceled += instance.OnDecrement;
                @Heal.started += instance.OnHeal;
                @Heal.performed += instance.OnHeal;
                @Heal.canceled += instance.OnHeal;
            }
        }
    }
    public ThirdPersonActions @ThirdPerson => new ThirdPersonActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IThirdPersonActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnTakeDamage(InputAction.CallbackContext context);
        void OnGainHealth(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnWeaponSwap1(InputAction.CallbackContext context);
        void OnWeaponSwap2(InputAction.CallbackContext context);
        void OnOpenShop(InputAction.CallbackContext context);
        void OnIncrement(InputAction.CallbackContext context);
        void OnDecrement(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
    }
}
