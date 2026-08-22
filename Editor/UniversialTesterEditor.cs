using UnityEngine;
using UnityEditor;

namespace DirtyWorks.Tools
{

    [CustomEditor(typeof(UniversialTester))]
    public class UniversialTesterEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            UniversialTester tester = (UniversialTester)target;
            SerializedProperty list = serializedObject.FindProperty("ueventList");

            for (int i = 0; i < list.arraySize; i++)
            {
                SerializedProperty element = list.GetArrayElementAtIndex(i);

                EditorGUILayout.BeginVertical("box");

                // Header
                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.LabelField("Test: " + tester.ueventList[i].name, EditorStyles.boldLabel);

                if (GUILayout.Button("X", GUILayout.Width(25)))
                {
                    list.DeleteArrayElementAtIndex(i);
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.EndVertical();
                    break;
                }

                EditorGUILayout.EndHorizontal();

                EditorGUILayout.PropertyField(
                    element,
                    new GUIContent("Details"),
                    true
                );

                if (GUILayout.Button("Invoke"))
                {
                    tester.ueventList[i]?.InvokeEvents();
                }

                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.Space(5);

            if (GUILayout.Button("Add Event"))
            {
                list.arraySize++;
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
