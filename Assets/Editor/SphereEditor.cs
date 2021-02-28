
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CC))]
public class SphereEditor : Editor
{
  public override void OnInspectorGUI()
  {
    base.OnInspectorGUI();
    serializedObject.ApplyModifiedProperties();
    
  }

}


