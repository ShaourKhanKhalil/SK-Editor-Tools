using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace SK_EditorTools
{
    public class RenameChildren : MonoBehaviour
    {
        public string Name_prefix;
        public string Name_postfix;
        [Space]
        public Transform Parent;

        [ContextMenu("Rename Children")]
        public void Rename()
        {
            if (!Parent)
            {
                Debug.LogError("Parent is null");
                return;
            }

            if (Name_prefix == "")
            {
                Debug.LogError("Name_Prefix is must field");
                return;
            }


            for (int i = 0; i < Parent.childCount; i++)
            {
                Parent.GetChild(i).name = Name_prefix + i + Name_postfix;
            }
            Debug.Log("All Children are Renamed successfully");

        }


    }

}