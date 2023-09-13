using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData playerData;
    public PlayerID playerID;
    private void OnEnable()
    {
        playerData.myObject = gameObject;
    }

    private void Start()
    {
        Debug.Log("There are " + playerID.stats.health + " stats health");
    }

    private void Update()
    {
        playerData.currentPosition = transform.position;
    }

    /*
     private void NewScriptableObject()
     {
         PlayerData newPlayerData =  ScriptableObject.CreateInstance<PlayerData>();
         UnityEditor.AssetDatabase.CreateAsset(newPlayerData, "Assets/SO.asset");
         newPlayerData.health = 70;
    }
    */ 
    
    private void OnDisable()
    {
        playerData.ResetData();
    }
}