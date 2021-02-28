using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
  
  [Header("Static Values")]
  
  public static float strength;
  public static float power;
  public static float force;

  [Header("Calculated Values")]
  public int health = 0;
  public int stamina = 0;
  public int brainpower = 0;
  [Header("Name")]
  public new string name = "Enter Name Here";
  
}

