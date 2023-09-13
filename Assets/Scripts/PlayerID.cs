using UnityEngine;
/// <summary>
/// This approach provides more flexibility when using the Singleton design pattern in Unity.
/// It allows accessing all the data and subsystems of a player through a single access point (PlayerID).
/// Defining and managing unique data and systems for each player is straightforward.
/// This method is particularly useful when creating dynamic data structures for different player profiles or characters in the game.
/// </summary>
[CreateAssetMenu(menuName ="ScriptableObjects/PlayerID", order = 2,fileName ="New PlayerID")]
public class PlayerID : ScriptableObject
{
    public PlayerStats stats;
    public PlayerInventory inventory;
    public PlayerLiveData data;
}