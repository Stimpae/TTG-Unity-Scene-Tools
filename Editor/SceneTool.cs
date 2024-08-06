using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace TTG {
    public class SceneTool : EditorWindow {
        private const string WINDOW_TITLE = "Scene Tool";
        private const string MENU_ITEM = "Tools/TTG/" + WINDOW_TITLE;
        
        [SerializeField] private VisualTreeAsset tabTreeAsset = default;
        [SerializeField] private VisualTreeAsset buildSettingsTreeAsset = default;
        [SerializeField] private VisualTreeAsset sceneGroupsTreeAsset = default;
        [SerializeField] private VisualTreeAsset sceneSelectionTreeAsset = default;
        
        
        [MenuItem(MENU_ITEM)]
        public static void Open() {
            var wnd = GetWindow<SceneTool>();
            wnd.titleContent = new GUIContent("Scene Tool");
        }

        public void CreateGUI() {
            var root = rootVisualElement;
            var tabMenu = tabTreeAsset.Instantiate();
            root.Add(tabMenu);
            
            var buildSettingsLabel = new Label("Build Settings");
            var sceneGroupsLabel = new Label("Scene Groups");
            var sceneSelectionLabel = new Label("Scene Selection");

            // add a label to the #tab-buttons visual element
            tabMenu.Q<VisualElement>("tab-buttons").Add(buildSettingsLabel);
            tabMenu.Q<VisualElement>("tab-buttons").Add(sceneGroupsLabel);
            tabMenu.Q<VisualElement>("tab-buttons").Add(sceneSelectionLabel);
            
        }
    }
}