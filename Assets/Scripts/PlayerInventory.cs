using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="ScriptableObjects/PlayerInventory")]
public class PlayerInventory : ScriptableObject
{
    public List<Item> items = new List<Item>();
    public int coins = 0;
}
