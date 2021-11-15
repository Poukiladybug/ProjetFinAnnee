// GENERATED AUTOMATICALLY FROM 'Assets/playerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerActions"",
    ""maps"": [
        {
            ""name"": ""FireGameplay"",
            ""id"": ""d9019007-08fe-438e-9b05-a7c06a5bf1e3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d6c18c8b-92aa-4260-8a23-b5fec57d18c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c5a914f3-8b70-4944-809e-281b337474a9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5017d883-bfe8-4b2b-ac96-c68bba6f09d7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42dd3b68-0e14-44c0-be3f-041a26ea6f20"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ArcherGameplay"",
            ""id"": ""29ce9d6c-7890-4189-9252-5fe4485913e5"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""42c543fc-4669-49b0-9dd5-bf3f166d055f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5aba0871-16d2-4e30-a7ba-dd1fdbeac9a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1090b9c9-c3e1-4bca-a07c-14783d43e4cd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3ca869d-e890-46dc-bfca-e4b6cc67920c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BoulangerGameplay"",
            ""id"": ""3a0b21b9-0a2b-4752-bbb5-9b43a8ac7195"",
            ""actions"": [
                {
                    ""name"": ""Fill"",
                    ""type"": ""Button"",
                    ""id"": ""f1d82cc9-0515-4b8f-ba5c-84f9e187928a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseFire"",
                    ""type"": ""Button"",
                    ""id"": ""40d60b80-a06b-49fb-bcea-49a12d2286fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47ca4e3c-3d2e-406d-8382-e88de213e121"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb5b23c0-ab24-49c9-89d4-13657fd6ffe6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FireGameplay
        m_FireGameplay = asset.FindActionMap("FireGameplay", throwIfNotFound: true);
        m_FireGameplay_Movement = m_FireGameplay.FindAction("Movement", throwIfNotFound: true);
        // ArcherGameplay
        m_ArcherGameplay = asset.FindActionMap("ArcherGameplay", throwIfNotFound: true);
        m_ArcherGameplay_Shoot = m_ArcherGameplay.FindAction("Shoot", throwIfNotFound: true);
        m_ArcherGameplay_Movement = m_ArcherGameplay.FindAction("Movement", throwIfNotFound: true);
        // BoulangerGameplay
        m_BoulangerGameplay = asset.FindActionMap("BoulangerGameplay", throwIfNotFound: true);
        m_BoulangerGameplay_Fill = m_BoulangerGameplay.FindAction("Fill", throwIfNotFound: true);
        m_BoulangerGameplay_IncreaseFire = m_BoulangerGameplay.FindAction("IncreaseFire", throwIfNotFound: true);
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

    // FireGameplay
    private readonly InputActionMap m_FireGameplay;
    private IFireGameplayActions m_FireGameplayActionsCallbackInterface;
    private readonly InputAction m_FireGameplay_Movement;
    public struct FireGameplayActions
    {
        private @PlayerActions m_Wrapper;
        public FireGameplayActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_FireGameplay_Movement;
        public InputActionMap Get() { return m_Wrapper.m_FireGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FireGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IFireGameplayActions instance)
        {
            if (m_Wrapper.m_FireGameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_FireGameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_FireGameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_FireGameplayActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_FireGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public FireGameplayActions @FireGameplay => new FireGameplayActions(this);

    // ArcherGameplay
    private readonly InputActionMap m_ArcherGameplay;
    private IArcherGameplayActions m_ArcherGameplayActionsCallbackInterface;
    private readonly InputAction m_ArcherGameplay_Shoot;
    private readonly InputAction m_ArcherGameplay_Movement;
    public struct ArcherGameplayActions
    {
        private @PlayerActions m_Wrapper;
        public ArcherGameplayActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_ArcherGameplay_Shoot;
        public InputAction @Movement => m_Wrapper.m_ArcherGameplay_Movement;
        public InputActionMap Get() { return m_Wrapper.m_ArcherGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArcherGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IArcherGameplayActions instance)
        {
            if (m_Wrapper.m_ArcherGameplayActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnShoot;
                @Movement.started -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ArcherGameplayActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_ArcherGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public ArcherGameplayActions @ArcherGameplay => new ArcherGameplayActions(this);

    // BoulangerGameplay
    private readonly InputActionMap m_BoulangerGameplay;
    private IBoulangerGameplayActions m_BoulangerGameplayActionsCallbackInterface;
    private readonly InputAction m_BoulangerGameplay_Fill;
    private readonly InputAction m_BoulangerGameplay_IncreaseFire;
    public struct BoulangerGameplayActions
    {
        private @PlayerActions m_Wrapper;
        public BoulangerGameplayActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fill => m_Wrapper.m_BoulangerGameplay_Fill;
        public InputAction @IncreaseFire => m_Wrapper.m_BoulangerGameplay_IncreaseFire;
        public InputActionMap Get() { return m_Wrapper.m_BoulangerGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoulangerGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IBoulangerGameplayActions instance)
        {
            if (m_Wrapper.m_BoulangerGameplayActionsCallbackInterface != null)
            {
                @Fill.started -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnFill;
                @Fill.performed -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnFill;
                @Fill.canceled -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnFill;
                @IncreaseFire.started -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnIncreaseFire;
                @IncreaseFire.performed -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnIncreaseFire;
                @IncreaseFire.canceled -= m_Wrapper.m_BoulangerGameplayActionsCallbackInterface.OnIncreaseFire;
            }
            m_Wrapper.m_BoulangerGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fill.started += instance.OnFill;
                @Fill.performed += instance.OnFill;
                @Fill.canceled += instance.OnFill;
                @IncreaseFire.started += instance.OnIncreaseFire;
                @IncreaseFire.performed += instance.OnIncreaseFire;
                @IncreaseFire.canceled += instance.OnIncreaseFire;
            }
        }
    }
    public BoulangerGameplayActions @BoulangerGameplay => new BoulangerGameplayActions(this);
    public interface IFireGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IArcherGameplayActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IBoulangerGameplayActions
    {
        void OnFill(InputAction.CallbackContext context);
        void OnIncreaseFire(InputAction.CallbackContext context);
    }
}
