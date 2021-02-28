
using UnityEngine;
using UnityEditor;


public class Window : EditorWindow
{


  [MenuItem("Window/SphereInfo")]
  public static void ShowWindow()
  {
    EditorWindow.GetWindow<Window>("Sphere Info");

  }

  void OnGUI()
  {
    Sphere sphere = Sphere.FindObjectOfType<Sphere>();

    GUILayout.Label("Static Values", EditorStyles.boldLabel);
    float strength = Sphere.strength;
    Sphere.strength = EditorGUILayout.FloatField("Strength", strength);
    float power = Sphere.power;
    Sphere.power = EditorGUILayout.FloatField("Power", power);
    float force = Sphere.force;
    Sphere.force = EditorGUILayout.FloatField("Force", force);
    
    GUILayout.Label("Calculated Values", EditorStyles.boldLabel);

    EditorGUILayout.LabelField("Health", sphere.health.ToString());
    EditorGUILayout.LabelField("Stamina", sphere.stamina.ToString());
    
    EditorGUILayout.LabelField("BrainPower", sphere.brainpower.ToString());
    EditorGUILayout.LabelField("Name", sphere.name);
    
  }
  




}
