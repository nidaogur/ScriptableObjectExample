using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
   public List<ItemInstance> items = new List<ItemInstance>();
   //public Item[] items;
   public int maxSlots = 10;

   private void Start()
   {
      //items = new Item[maxSlots];
   }

   public void AddItem(CollectableItem collectable)
   {
      /*
      for (int i = 0; i < items.Length; i++)
      {
         if (items[i] == null)
         {
            // There is space for the item, collect it & destroy the original
            items[i] = collectable.CollectItem();
            return;
         }
      }
      // There is no space, don't collect the item
      */

      if (items.Count<maxSlots)
      {
         items.Add(collectable.CollectItem());
         return;
      }
   }
}
