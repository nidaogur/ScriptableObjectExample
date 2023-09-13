using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/PlayerLiveData")]
public class PlayerLiveData : ScriptableObject
{
    public int currentLevel = 1;
    public bool isAlive = true;
    public int score = 0;   
}