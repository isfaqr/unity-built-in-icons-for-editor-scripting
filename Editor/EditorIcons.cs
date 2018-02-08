﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorIcons : EditorWindow {

    public int selGridInt = 0;
    public string[] iconNames = new string[] {
        "ScriptableObject Icon",
        "_Help",
        "_Popup",
        "Clipboard",
        "SocialNetworks.UDNOpen",
        "SocialNetworks.Tweet",
        "SocialNetworks.FacebookShare",
        "SocialNetworks.LinkedInShare",
        "SocialNetworks.UDNLogo",
        "animationvisibilitytoggleoff",
        "animationvisibilitytoggleon",
        "tree_icon",
        "tree_icon_leaf",
        "tree_icon_frond",
        "tree_icon_branch",
        "tree_icon_branch_frond",
        "editicon.sml",
        "TreeEditor.Refresh",
        "TreeEditor.Duplicate",
        "TreeEditor.Trash",
        "TreeEditor.AddBranches",
        "TreeEditor.AddLeaves",
        "TreeEditor.Trash",
        "preAudioPlayOn",
        "preAudioPlayOff",
        "AvatarInspector/RightFingersIk",
        "AvatarInspector/LeftFingersIk",
        "AvatarInspector/RightFeetIk",
        "AvatarInspector/LeftFeetIk",
        "AvatarInspector/RightFingers",
        "AvatarInspector/LeftFingers",
        "AvatarInspector/RightArm",
        "AvatarInspector/LeftArm",
        "AvatarInspector/RightLeg",
        "AvatarInspector/LeftLeg",
        "AvatarInspector/Head",
        "AvatarInspector/Torso",
        "AvatarInspector/MaskEditor_Root",
        "AvatarInspector/BodyPartPicker",
        "AvatarInspector/BodySIlhouette",
        "Mirror",
        "SpeedScale",
        "Toolbar Minus",
        "Toolbar Plus More",
        "Toolbar Plus",
        "AnimatorController Icon",
        "TextAsset Icon",
        "Shader Icon",
        "boo Script Icon",
        "cs Script Icon",
        "js Script Icon",
        "Prefab Icon",
        "Profiler.NextFrame",
        "Profiler.PrevFrame",
        "sv_icon_none",
        "ColorPicker.CycleSlider",
        "ColorPicker.CycleColor",
        "EyeDropper.Large",
        "ClothInspector.PaintValue",
        "ClothInspector.ViewValue",
        "ClothInspector.SettingsTool",
        "ClothInspector.PaintTool",
        "ClothInspector.SelectTool",
        "WelcomeScreen.AssetStoreLogo",
        "WelcomeScreen.AssetStoreLogo",
        "AboutWindow.MainHeader",
        "UnityLogo",
        "AgeiaLogo",
        "MonoLogo",
        "Toolbar Minus",
        "PlayButtonProfile Anim",
        "StepButton Anim",
        "PauseButton Anim",
        "PlayButton Anim",
        "PlayButtonProfile On",
        "StepButton On",
        "PauseButton On",
        "PlayButton On",
        "PlayButtonProfile",
        "StepButton",
        "PauseButton",
        "PlayButton",
        "ViewToolOrbit On",
        "ViewToolZoom On",
        "ViewToolMove On",
        "ViewToolOrbit On",
        "ViewToolOrbit",
        "ViewToolZoom",
        "ViewToolMove",
        "ViewToolOrbit",
        "ScaleTool On",
        "RotateTool On",
        "MoveTool On",
        "ScaleTool",
        "RotateTool",
        "MoveTool",
        "PauseButton",
        "PlayButton",
        "Toolbar Minus",
        "Toolbar Plus",
        "UnityLogo",
        "_Help",
        "_Popup",
        "Icon Dropdown",
        "Avatar Icon",
        "AvatarPivot",
        "SpeedScale",
        "AvatarInspector/DotSelection",
        "AvatarInspector/DotFrameDotted",
        "AvatarInspector/DotFrame",
        "AvatarInspector/DotFill",
        "AvatarInspector/RightHandZoom",
        "AvatarInspector/LeftHandZoom",
        "AvatarInspector/HeadZoom",
        "AvatarInspector/RightLeg",
        "AvatarInspector/LeftLeg",
        "AvatarInspector/RightFingers",
        "AvatarInspector/RightArm",
        "AvatarInspector/LeftFingers",
        "AvatarInspector/LeftArm",
        "AvatarInspector/Head",
        "AvatarInspector/Torso",
        "AvatarInspector/RightHandZoomSilhouette",
        "AvatarInspector/LeftHandZoomSilhouette",
        "AvatarInspector/HeadZoomSilhouette",
        "AvatarInspector/BodySilhouette",
        "Animation.AddKeyframe",
        "Animation.NextKey",
        "Animation.PrevKey",
        "lightMeter/redLight",
        "lightMeter/orangeLight",
        "lightMeter/lightRim",
        "lightMeter/greenLight",
        "Animation.AddEvent",
        "SceneviewAudio",
        "SceneviewLighting",
        "MeshRenderer Icon",
        "Terrain Icon",
        "sv_icon_none",
        "BuildSettings.SelectedIcon",
        "Animation.AddEvent",
        "Animation.AddKeyframe",
        "Animation.NextKey",
        "Animation.PrevKey",
        "Animation.Record",
        "Animation.Play",
        "PreTextureRGB",
        "PreTextureAlpha",
        "PreTextureMipMapHigh",
        "PreTextureMipMapLow",
        "TerrainInspector.TerrainToolSettings",
        "TerrainInspector.TerrainToolPlants",
        "TerrainInspector.TerrainToolTrees",
        "TerrainInspector.TerrainToolSplat",
        "TerrainInspector.TerrainToolSmoothHeight",
        "TerrainInspector.TerrainToolSetHeight",
        "TerrainInspector.TerrainToolRaise",
        "SettingsIcon",
        "PauseButton",
        "PlayButton",
        "PreMatLight1",
        "PreMatLight0",
        "PreMatTorus",
        "PreMatCylinder",
        "PreMatCube",
        "PreMatSphere",
        "PreMatLight1",
        "PreMatLight0",
        "Camera Icon",
        "Toolbar Minus",
        "Toolbar Plus",
        "Animation.EventMarker",
        "AS Badge New",
        "AS Badge Move",
        "AS Badge Delete",
        "WaitSpin00",
        "WaitSpin01",
        "WaitSpin02",
        "WaitSpin03",
        "WaitSpin04",
        "WaitSpin05",
        "WaitSpin06",
        "WaitSpin07",
        "WaitSpin08",
        "WaitSpin09",
        "WaitSpin10",
        "WaitSpin11",
        "WelcomeScreen.AssetStoreLogo",
        "WelcomeScreen.UnityAnswersLogo",
        "WelcomeScreen.UnityForumLogo",
        "WelcomeScreen.UnityBasicsLogo",
        "WelcomeScreen.VideoTutLogo",
        "WelcomeScreen.MainHeader",
        "UnityLogo",
        "preAudioPlayOn",
        "preAudioPlayOff",
        "Animation.EventMarker",
        "PreMatLight1",
        "PreMatLight0",
        "PreMatTorus",
        "PreMatCylinder",
        "PreMatCube",
        "PreMatSphere",
        "TreeEditor.Duplicate",
        "Toolbar Minus",
        "Toolbar Plus",
        "PreTextureMipMapHigh",
        "PreTextureMipMapLow",
        "PreTextureRGB",
        "PreTextureAlpha",
        "VerticalSplit",
        "HorizontalSplit",
        "Icon Dropdown",
        "PrefabNormal Icon",
        "PrefabModel Icon",
        "PrefabNormal Icon",
        "Prefab Icon",
        "GameObject Icon",
        "preAudioLoopOn",
        "preAudioLoopOff",
        "preAudioPlayOn",
        "preAudioPlayOff",
        "preAudioAutoPlayOn",
        "preAudioAutoPlayOff",
        "BuildSettings.Web.Small",
        "BuildSettings.Standalone.Small",
        "BuildSettings.iPhone.Small",
        "BuildSettings.Android.Small",
        "BuildSettings.BlackBerry.Small",
        "BuildSettings.Tizen.Small",
        "BuildSettings.XBox360.Small",
        "BuildSettings.XboxOne.Small",
        "BuildSettings.PS3.Small",
        "BuildSettings.PSP2.Small",
        "BuildSettings.PS4.Small",
        "BuildSettings.PSM.Small",
        "BuildSettings.FlashPlayer.Small",
        "BuildSettings.Metro.Small",
        "BuildSettings.WP8.Small",
        "BuildSettings.SamsungTV.Small",
        "BuildSettings.Web",
        "BuildSettings.Standalone",
        "BuildSettings.iPhone",
        "BuildSettings.Android",
        "BuildSettings.BlackBerry",
        "BuildSettings.Tizen",
        "BuildSettings.XBox360",
        "BuildSettings.XboxOne",
        "BuildSettings.PS3",
        "BuildSettings.PSP2",
        "BuildSettings.PS4",
        "BuildSettings.PSM",
        "BuildSettings.FlashPlayer",
        "BuildSettings.Metro",
        "BuildSettings.WP8",
        "BuildSettings.SamsungTV",
        "TreeEditor.BranchTranslate",
        "TreeEditor.BranchRotate",
        "TreeEditor.BranchFreeHand",
        "TreeEditor.BranchTranslate On",
        "TreeEditor.BranchRotate On",
        "TreeEditor.BranchFreeHand On",
        "TreeEditor.LeafTranslate",
        "TreeEditor.LeafRotate",
        "TreeEditor.LeafTranslate On",
        "TreeEditor.LeafRotate On",
        "sv_icon_dot15_pix16_gizmo",
        "sv_icon_dot1_sml",
        "sv_icon_dot4_sml",
        "sv_icon_dot7_sml",
        "sv_icon_dot5_pix16_gizmo",
        "sv_icon_dot11_pix16_gizmo",
        "sv_icon_dot12_sml",
        "sv_icon_dot15_sml",
        "sv_icon_dot9_pix16_gizmo",
        "sv_icon_name6",
        "sv_icon_name3",
        "sv_icon_name4",
        "sv_icon_name0",
        "sv_icon_name1",
        "sv_icon_name2",
        "sv_icon_name5",
        "sv_icon_name7",
        "sv_icon_dot1_pix16_gizmo",
        "sv_icon_dot8_pix16_gizmo",
        "sv_icon_dot2_pix16_gizmo",
        "sv_icon_dot6_pix16_gizmo",
        "sv_icon_dot0_sml",
        "sv_icon_dot3_sml",
        "sv_icon_dot6_sml",
        "sv_icon_dot9_sml",
        "sv_icon_dot11_sml",
        "sv_icon_dot14_sml",
        "sv_label_0",
        "sv_label_1",
        "sv_label_2",
        "sv_label_3",
        "sv_label_5",
        "sv_label_6",
        "sv_label_7",
        "sv_icon_none",
        "sv_icon_dot14_pix16_gizmo",
        "sv_icon_dot7_pix16_gizmo",
        "sv_icon_dot3_pix16_gizmo",
        "sv_icon_dot0_pix16_gizmo",
        "sv_icon_dot2_sml",
        "sv_icon_dot5_sml",
        "sv_icon_dot8_sml",
        "sv_icon_dot10_pix16_gizmo",
        "sv_icon_dot12_pix16_gizmo",
        "sv_icon_dot10_sml",
        "sv_icon_dot13_sml",
        "sv_icon_dot4_pix16_gizmo",
        "sv_label_4",
        "sv_icon_dot13_pix16_gizmo"
};
    Vector2 scrollview;
    GUIContent iconContent;

    [MenuItem("Tools/Editor Icons")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        EditorIcons window = (EditorIcons)GetWindow(typeof(EditorIcons));
        window.Show();
        window.minSize = new Vector2(300, 300);
    }

    void OnGUI()
    {

        
        scrollview = EditorGUILayout.BeginScrollView(scrollview);
        EditorGUILayout.BeginVertical();
        EditorGUILayout.BeginHorizontal();
        for (int i = 1; i <= iconNames.Length; i++)
        {
            if (i % ((int)Screen.width/85) == 0)
            {
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
            }
            iconContent = EditorGUIUtility.IconContent(iconNames[i - 1]);
            if (iconContent.image == null)
            {
                iconContent.text = "Not\nAvailable";
            }
            EditorGUILayout.BeginVertical();
            GUILayout.Button(iconContent, GUILayout.Width(80), GUILayout.Height(80));
            EditorGUILayout.TextField(iconNames[i - 1], GUILayout.Width(80));
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndScrollView();
    }
}

