using UnityEditor;
using UnityEngine;

namespace SK_EditorTools
{
    [CustomEditor(typeof(RenameChildren))]
    public class RenameChildrenEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("Rename Children");

            DrawDefaultInspector();

            GUILayout.Space(5);

            RenameChildren script = (RenameChildren)target;
            if (GUILayout.Button("Rename Children",GUILayout.Height(50)))
            {
                script.Rename();
            }

        }
    }
}