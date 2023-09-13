using UnityEngine;

public class PlayerHealthBar: MonoBehaviour
{
        public float displayValue;
        public PlayerData playerData;
        
        private void UpdateHealthBar()
        {
                displayValue = playerData.health;
        }
}