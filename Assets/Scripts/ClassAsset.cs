using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/ClassAsset", order = 2,fileName ="New Player Class")]
public class ClassAsset:ScriptableObject
{
   public int strength;
   public int magic;
   public int dexterity;
}