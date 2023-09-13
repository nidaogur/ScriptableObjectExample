using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public float health = 100f;
    public float attackPower = 10f;
    public float armor = 5f;
    public float speed = 5f;
}
