using UnityEditor;
using UnityEngine;

namespace Umbrella.Utility
{
    [CustomEditor(typeof(CameraSizeAdjuster), true)]
    public class CameraSizeAdjusterEditor : Editor
    {
        private SerializedProperty _aspectRatio;
        private SerializedProperty _baseCameraSize;
        private SerializedProperty _baseCameraFOV;
        private SerializedProperty _showBaseAspectArea;
        private SerializedProperty _baseAspectAreaColor;

        private Camera _camera;

        private void OnEnable()
        {
            _aspectRatio = serializedObject.FindProperty("_baseAspectRatio");
            _baseCameraSize = serializedObject.FindProperty("_baseCameraSize");
            _baseCameraFOV = serializedObject.FindProperty("_baseCameraFOV");
            _showBaseAspectArea = serializedObject.FindProperty("_showBaseAspectArea");
            _baseAspectAreaColor = serializedObject.FindProperty("_baseAspectAreaColor");

            var adjuster = target as CameraSizeAdjuster;
            _camera = adjuster.GetComponent<Camera>();
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_aspectRatio);

            if (_camera.orthographic)
            {
                EditorGUILayout.PropertyField(_baseCameraSize);
            }
            else
            {
                EditorGUILayout.PropertyField(_baseCameraFOV);
            }

            EditorGUILayout.PropertyField(_showBaseAspectArea);
            if (_showBaseAspectArea.boolValue)
            {
                EditorGUILayout.PropertyField(_baseAspectAreaColor);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
