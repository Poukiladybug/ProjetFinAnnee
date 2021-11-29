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
            ""name"": ""test"",
            ""id"": ""b88f7f64-1a12-4149-9a27-e51c27f1face"",
            ""actions"": [
                {
                    ""name"": ""pelle"",
                    ""type"": ""Value"",
                    ""id"": ""81814e5c-c7c5-4873-b561-e6b606a46e74"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""002a641e-5d38-4554-90a4-fbec99a0ced8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pelle"",
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
        // test
        m_test = asset.FindActionMap("test", throwIfNotFound: true);
        m_test_pelle = m_test.FindAction("pelle", throwIfNotFound: true);
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

    // test
    private readonly InputActionMap m_test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_test_pelle;
    public struct TestActions
    {
        private @PlayerActions m_Wrapper;
        public TestActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @pelle => m_Wrapper.m_test_pelle;
        public InputActionMap Get() { return m_Wrapper.m_test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @pelle.started -= m_Wrapper.m_TestActionsCallbackInterface.OnPelle;
                @pelle.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnPelle;
                @pelle.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnPelle;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pelle.started += instance.OnPelle;
                @pelle.performed += instance.OnPelle;
                @pelle.canceled += instance.OnPelle;
            }
        }
    }
    public TestActions @test => new TestActions(this);
    public interface IFireGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IArcherGameplayActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnPelle(InputAction.CallbackContext context);
    }
}
