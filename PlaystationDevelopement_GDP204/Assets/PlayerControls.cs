// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""3ec5f09c-a632-4ecd-aa9e-2c2b1aa0a363"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6e8178de-522f-4be5-9d48-b564f231b380"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aiming"",
                    ""type"": ""Button"",
                    ""id"": ""1619bf77-b55d-40f3-be5d-bf5e8517df4e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""dcfd1299-c800-4306-ae0d-f64c84e2e777"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""d84c959d-714d-4ac3-a8c1-c1e0ebfc5c87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a008649e-99e6-4cd8-9ec7-30db0ac0362e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementToggle"",
                    ""type"": ""Button"",
                    ""id"": ""2d32988f-c49b-4eaa-8f9a-9ebb6bf9ce0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponsToggle"",
                    ""type"": ""Button"",
                    ""id"": ""d255e18c-e1a9-45ad-94c1-a319a1b85bf1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""End_PlayAgain"",
                    ""type"": ""Button"",
                    ""id"": ""b03a50ea-257f-480a-a6c5-e3b67bddb729"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""End_Menu"",
                    ""type"": ""Button"",
                    ""id"": ""e7e75e0e-2d46-4016-8ead-c0a921b07e25"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""End_Quit"",
                    ""type"": ""Button"",
                    ""id"": ""9a677ab8-0e0a-4cfe-8d25-630a60326c24"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardUp"",
                    ""type"": ""Button"",
                    ""id"": ""0e831705-1164-482b-8b27-2c11fffa81bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c2399db9-f1ee-4f99-955a-5186b1538296"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardDown"",
                    ""type"": ""Button"",
                    ""id"": ""d8d51004-5b41-4505-8bdc-45882f821a81"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardRight"",
                    ""type"": ""Button"",
                    ""id"": ""2c7dcda4-1e4f-419e-815b-a29f0fe907b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OffensiveAbility1"",
                    ""type"": ""Button"",
                    ""id"": ""1033f94e-5228-4817-a693-af23b97751dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""985ef7c1-c4a0-4612-801b-01928d4c068a"",
                    ""path"": ""<PS4DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07015f60-5c05-400f-b41b-09f9ce505331"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb9786cd-f2d5-4fd9-b2b1-7ad28633bd84"",
                    ""path"": ""<PS4DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b476962a-debe-4676-894d-220015453ea8"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b5415a4-afc5-4062-8497-0a43011f1902"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32cfc903-971b-4077-aeab-9daab1b12833"",
                    ""path"": ""<PS4DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd95b935-ebdb-4382-bccc-bb1252ae3b5d"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c38cfc6f-6db4-481f-8581-48207ab8db56"",
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
                    ""id"": ""ee93ea73-7324-42c7-a2b4-f7cd0485dd91"",
                    ""path"": ""<PS4DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db2ef37d-b4da-4f10-b540-df2fc25ae5eb"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a79bcf57-fee4-4943-90c7-25279af406eb"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f79aa92f-f418-4daf-a173-9d6c3304ad2a"",
                    ""path"": ""<PS4DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c41eb56-3a9a-4943-a4c9-7fa7df04fb24"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a857f9a7-ae60-4ed2-8659-bf9a6b7e83bb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1285e785-e8e0-4cf0-a59d-46ca25098d51"",
                    ""path"": ""<PS4DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f512a039-a95f-452b-8510-ffc64c9b5cd7"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4145b38a-8bee-499e-80c9-0adf5127fba0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be8922e6-bdf4-478d-ae42-366dff7189da"",
                    ""path"": ""<PS4DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponsToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9350424c-45fe-4261-8ab1-6ff8b07aee24"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponsToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8834fab-4f23-42ee-93b0-8728b1cb7435"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponsToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7d6bbc-7cd0-4625-9860-dff3f4964bf7"",
                    ""path"": ""<PS4DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_PlayAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dd1a928-eeb8-477a-a994-7f91184ab8c3"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_PlayAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5640bad5-98d2-408a-830f-1b0a47f853d0"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_PlayAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd21702d-7885-4c85-ab62-243518d230b9"",
                    ""path"": ""<PS4DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1b90f0c-812e-4f94-93c3-0bcad4f445a9"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1af0877-c592-4f69-8419-b4f10b1f8cc2"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37a06416-6ac1-46b9-871f-bb390a6ab5a4"",
                    ""path"": ""<PS4DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c93deab-463e-4b71-b03b-f06328c32eb7"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5c8a7e0-57dd-48fe-b43c-80f6933758c7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6f3aeee-bfe2-41dc-ae69-a2c2796c9b8c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce7573df-988d-4b72-9038-5fd380cafc41"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28fe42d3-ae1d-4496-8354-c274ddbca02d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb7b8b23-de9a-4924-898c-6a7bc16d88bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7de2d859-cbb7-4401-9e3c-46241337b62e"",
                    ""path"": ""<PS4DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OffensiveAbility1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8907f3e7-3795-4fe1-babd-5f19293e7dae"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OffensiveAbility1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f8989c4-d6d1-482f-93d5-a5c9a9c08bd3"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OffensiveAbility1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""deb687ae-310e-48a7-a7e6-97956967a035"",
            ""actions"": [
                {
                    ""name"": ""Play1"",
                    ""type"": ""Button"",
                    ""id"": ""848dcb5e-0b81-4d74-bc86-0a4ed70a5911"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play2"",
                    ""type"": ""Button"",
                    ""id"": ""4c717074-6018-4a8b-8958-524a0d65d610"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play3"",
                    ""type"": ""Button"",
                    ""id"": ""608d4cf7-ea3b-4249-aed4-bbcc121568a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Controls"",
                    ""type"": ""Button"",
                    ""id"": ""07043d1d-359d-440e-b185-8a19c37b2075"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""1d87beb3-9cf6-4b8a-8fb3-ae5dfd676edf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b88307e1-5266-43f4-8ef7-94576c9c9fee"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""758c9b7e-5202-4b3c-a17a-8b7fd7be09f8"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19cd8714-8c56-4f3c-9e36-880951fc6210"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f02dd7e-dbf1-4b21-8d12-3f3287fdb576"",
                    ""path"": ""<PS4DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7dd6e62-838a-4906-9e84-de6bd4bca93d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a318a7be-d2a2-4723-8ccc-0c6854ecdb3f"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""429c6242-edc5-434a-b6a8-fc771afd67c5"",
                    ""path"": ""<PS4DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39ff1815-bdb9-4346-8ed5-fc1605bfe0ee"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27398903-19c1-468d-ac55-90236195c20d"",
                    ""path"": ""<PS4DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2b986ea-08cd-4a12-b886-86dfde4c28ee"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b2834ff-3416-4ab8-bf96-c07169d6e5de"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f75a0474-0d41-4de0-8bd1-4e874585c543"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfd800de-c078-4cbb-9325-1385775285fd"",
                    ""path"": ""<PS4DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGame
        m_InGame = asset.GetActionMap("InGame");
        m_InGame_Movement = m_InGame.GetAction("Movement");
        m_InGame_Aiming = m_InGame.GetAction("Aiming");
        m_InGame_Shoot = m_InGame.GetAction("Shoot");
        m_InGame_Block = m_InGame.GetAction("Block");
        m_InGame_Pause = m_InGame.GetAction("Pause");
        m_InGame_MovementToggle = m_InGame.GetAction("MovementToggle");
        m_InGame_WeaponsToggle = m_InGame.GetAction("WeaponsToggle");
        m_InGame_End_PlayAgain = m_InGame.GetAction("End_PlayAgain");
        m_InGame_End_Menu = m_InGame.GetAction("End_Menu");
        m_InGame_End_Quit = m_InGame.GetAction("End_Quit");
        m_InGame_KeyboardUp = m_InGame.GetAction("KeyboardUp");
        m_InGame_KeyboardLeft = m_InGame.GetAction("KeyboardLeft");
        m_InGame_KeyboardDown = m_InGame.GetAction("KeyboardDown");
        m_InGame_KeyboardRight = m_InGame.GetAction("KeyboardRight");
        m_InGame_OffensiveAbility1 = m_InGame.GetAction("OffensiveAbility1");
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_Play1 = m_Menu.GetAction("Play1");
        m_Menu_Play2 = m_Menu.GetAction("Play2");
        m_Menu_Play3 = m_Menu.GetAction("Play3");
        m_Menu_Controls = m_Menu.GetAction("Controls");
        m_Menu_Quit = m_Menu.GetAction("Quit");
    }

    ~PlayerControls()
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Movement;
    private readonly InputAction m_InGame_Aiming;
    private readonly InputAction m_InGame_Shoot;
    private readonly InputAction m_InGame_Block;
    private readonly InputAction m_InGame_Pause;
    private readonly InputAction m_InGame_MovementToggle;
    private readonly InputAction m_InGame_WeaponsToggle;
    private readonly InputAction m_InGame_End_PlayAgain;
    private readonly InputAction m_InGame_End_Menu;
    private readonly InputAction m_InGame_End_Quit;
    private readonly InputAction m_InGame_KeyboardUp;
    private readonly InputAction m_InGame_KeyboardLeft;
    private readonly InputAction m_InGame_KeyboardDown;
    private readonly InputAction m_InGame_KeyboardRight;
    private readonly InputAction m_InGame_OffensiveAbility1;
    public struct InGameActions
    {
        private PlayerControls m_Wrapper;
        public InGameActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InGame_Movement;
        public InputAction @Aiming => m_Wrapper.m_InGame_Aiming;
        public InputAction @Shoot => m_Wrapper.m_InGame_Shoot;
        public InputAction @Block => m_Wrapper.m_InGame_Block;
        public InputAction @Pause => m_Wrapper.m_InGame_Pause;
        public InputAction @MovementToggle => m_Wrapper.m_InGame_MovementToggle;
        public InputAction @WeaponsToggle => m_Wrapper.m_InGame_WeaponsToggle;
        public InputAction @End_PlayAgain => m_Wrapper.m_InGame_End_PlayAgain;
        public InputAction @End_Menu => m_Wrapper.m_InGame_End_Menu;
        public InputAction @End_Quit => m_Wrapper.m_InGame_End_Quit;
        public InputAction @KeyboardUp => m_Wrapper.m_InGame_KeyboardUp;
        public InputAction @KeyboardLeft => m_Wrapper.m_InGame_KeyboardLeft;
        public InputAction @KeyboardDown => m_Wrapper.m_InGame_KeyboardDown;
        public InputAction @KeyboardRight => m_Wrapper.m_InGame_KeyboardRight;
        public InputAction @OffensiveAbility1 => m_Wrapper.m_InGame_OffensiveAbility1;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                Aiming.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnAiming;
                Aiming.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnAiming;
                Aiming.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnAiming;
                Shoot.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                Block.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnBlock;
                Block.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnBlock;
                Block.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnBlock;
                Pause.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                Pause.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                Pause.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                MovementToggle.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovementToggle;
                MovementToggle.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovementToggle;
                MovementToggle.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovementToggle;
                WeaponsToggle.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeaponsToggle;
                WeaponsToggle.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeaponsToggle;
                WeaponsToggle.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeaponsToggle;
                End_PlayAgain.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_PlayAgain;
                End_PlayAgain.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_PlayAgain;
                End_PlayAgain.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_PlayAgain;
                End_Menu.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Menu;
                End_Menu.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Menu;
                End_Menu.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Menu;
                End_Quit.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Quit;
                End_Quit.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Quit;
                End_Quit.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnEnd_Quit;
                KeyboardUp.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardUp;
                KeyboardUp.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardUp;
                KeyboardUp.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardUp;
                KeyboardLeft.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardLeft;
                KeyboardLeft.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardLeft;
                KeyboardLeft.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardLeft;
                KeyboardDown.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardDown;
                KeyboardDown.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardDown;
                KeyboardDown.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardDown;
                KeyboardRight.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardRight;
                KeyboardRight.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardRight;
                KeyboardRight.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnKeyboardRight;
                OffensiveAbility1.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnOffensiveAbility1;
                OffensiveAbility1.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnOffensiveAbility1;
                OffensiveAbility1.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnOffensiveAbility1;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Aiming.started += instance.OnAiming;
                Aiming.performed += instance.OnAiming;
                Aiming.canceled += instance.OnAiming;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
                Block.started += instance.OnBlock;
                Block.performed += instance.OnBlock;
                Block.canceled += instance.OnBlock;
                Pause.started += instance.OnPause;
                Pause.performed += instance.OnPause;
                Pause.canceled += instance.OnPause;
                MovementToggle.started += instance.OnMovementToggle;
                MovementToggle.performed += instance.OnMovementToggle;
                MovementToggle.canceled += instance.OnMovementToggle;
                WeaponsToggle.started += instance.OnWeaponsToggle;
                WeaponsToggle.performed += instance.OnWeaponsToggle;
                WeaponsToggle.canceled += instance.OnWeaponsToggle;
                End_PlayAgain.started += instance.OnEnd_PlayAgain;
                End_PlayAgain.performed += instance.OnEnd_PlayAgain;
                End_PlayAgain.canceled += instance.OnEnd_PlayAgain;
                End_Menu.started += instance.OnEnd_Menu;
                End_Menu.performed += instance.OnEnd_Menu;
                End_Menu.canceled += instance.OnEnd_Menu;
                End_Quit.started += instance.OnEnd_Quit;
                End_Quit.performed += instance.OnEnd_Quit;
                End_Quit.canceled += instance.OnEnd_Quit;
                KeyboardUp.started += instance.OnKeyboardUp;
                KeyboardUp.performed += instance.OnKeyboardUp;
                KeyboardUp.canceled += instance.OnKeyboardUp;
                KeyboardLeft.started += instance.OnKeyboardLeft;
                KeyboardLeft.performed += instance.OnKeyboardLeft;
                KeyboardLeft.canceled += instance.OnKeyboardLeft;
                KeyboardDown.started += instance.OnKeyboardDown;
                KeyboardDown.performed += instance.OnKeyboardDown;
                KeyboardDown.canceled += instance.OnKeyboardDown;
                KeyboardRight.started += instance.OnKeyboardRight;
                KeyboardRight.performed += instance.OnKeyboardRight;
                KeyboardRight.canceled += instance.OnKeyboardRight;
                OffensiveAbility1.started += instance.OnOffensiveAbility1;
                OffensiveAbility1.performed += instance.OnOffensiveAbility1;
                OffensiveAbility1.canceled += instance.OnOffensiveAbility1;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Play1;
    private readonly InputAction m_Menu_Play2;
    private readonly InputAction m_Menu_Play3;
    private readonly InputAction m_Menu_Controls;
    private readonly InputAction m_Menu_Quit;
    public struct MenuActions
    {
        private PlayerControls m_Wrapper;
        public MenuActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play1 => m_Wrapper.m_Menu_Play1;
        public InputAction @Play2 => m_Wrapper.m_Menu_Play2;
        public InputAction @Play3 => m_Wrapper.m_Menu_Play3;
        public InputAction @Controls => m_Wrapper.m_Menu_Controls;
        public InputAction @Quit => m_Wrapper.m_Menu_Quit;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                Play1.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay1;
                Play1.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay1;
                Play1.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay1;
                Play2.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay2;
                Play2.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay2;
                Play2.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay2;
                Play3.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay3;
                Play3.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay3;
                Play3.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay3;
                Controls.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnControls;
                Controls.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnControls;
                Controls.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnControls;
                Quit.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
                Quit.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
                Quit.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Play1.started += instance.OnPlay1;
                Play1.performed += instance.OnPlay1;
                Play1.canceled += instance.OnPlay1;
                Play2.started += instance.OnPlay2;
                Play2.performed += instance.OnPlay2;
                Play2.canceled += instance.OnPlay2;
                Play3.started += instance.OnPlay3;
                Play3.performed += instance.OnPlay3;
                Play3.canceled += instance.OnPlay3;
                Controls.started += instance.OnControls;
                Controls.performed += instance.OnControls;
                Controls.canceled += instance.OnControls;
                Quit.started += instance.OnQuit;
                Quit.performed += instance.OnQuit;
                Quit.canceled += instance.OnQuit;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IInGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAiming(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMovementToggle(InputAction.CallbackContext context);
        void OnWeaponsToggle(InputAction.CallbackContext context);
        void OnEnd_PlayAgain(InputAction.CallbackContext context);
        void OnEnd_Menu(InputAction.CallbackContext context);
        void OnEnd_Quit(InputAction.CallbackContext context);
        void OnKeyboardUp(InputAction.CallbackContext context);
        void OnKeyboardLeft(InputAction.CallbackContext context);
        void OnKeyboardDown(InputAction.CallbackContext context);
        void OnKeyboardRight(InputAction.CallbackContext context);
        void OnOffensiveAbility1(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnPlay1(InputAction.CallbackContext context);
        void OnPlay2(InputAction.CallbackContext context);
        void OnPlay3(InputAction.CallbackContext context);
        void OnControls(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
}
