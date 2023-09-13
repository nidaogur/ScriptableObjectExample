using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
{
        public GameEvent onGameWon;
        public GameEvent onGameLost;
        
        public void EndGame(bool gameWon)
        { 
                if (gameWon) 
                {
                        onGameWon.TriggerEvent();
                }
                else
                {
                        onGameLost.TriggerEvent();
                }
        }
        
}