using System;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public ItemInstance itemInstance;
    public Item item;

    /*
    public Item CollectItem()
    {
        // returns the item type and destroys the game object
        Destroy(gameObject);
        return item;
    }
   */
    public ItemInstance CollectItem()
    {
        Destroy(gameObject);
        return itemInstance;
    }
}
[System.Serializable]
public struct ItemInstance
{
    public int condition;
    public Item itemType;
    ItemInstance(int itemCondition, Item itemAssetType)
    {
        condition = itemCondition;
        itemType = itemAssetType;
    }
}