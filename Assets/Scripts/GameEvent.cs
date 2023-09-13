using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="ScriptableObjects/GameEvent", order = 2,fileName ="New GameEvent")]
public class GameEvent:ScriptableObject
{
       private List<GameEventListener> _listeners = new List<GameEventListener>();

       public void TriggerEvent()
       {
              for (int i = _listeners.Count-1; i >=0; i--)
              {
                     _listeners[i].OnEventTriggered();
              }
       }

       public void AddListener(GameEventListener listener)
       {
              _listeners.Add(listener);
       }

       public void RemoveListener(GameEventListener listener)
       {
              _listeners.Remove(listener);
       }
       // Using scriptable objects as game events allows you to create multiple instances of an event asset type.
       // And because it's an asset, multiple scripts can reference the same event instance,
       // either to trigger it or to subscribe a function to it, without needing direct references to each other.
}