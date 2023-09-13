using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/PlayerData", order = 2,fileName ="New Player Data" )]
public class PlayerData : ScriptableObject
{
   [SerializeField] private float defaultHealth = 100;
   [HideInInspector] public GameObject myObject;
   public float health;
   public Vector3 currentPosition;
   
   public void ResetData()     // A function to reset player data.
   {
      health = defaultHealth;
      currentPosition = Vector3.zero;
   }
   
}
