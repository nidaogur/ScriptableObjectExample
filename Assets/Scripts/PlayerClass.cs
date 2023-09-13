using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;


public enum ClassEnum
{
    Mage, 
    Samurai,
    Warrior,
}
public class PlayerClass : MonoBehaviour
{
    public ClassEnum myClass;
    public ClassAsset myClassAsset;
    // Enums are an excellent choice when you have a fixed list of options and need to distinguish between them easily.
    // On the other hand, scriptable objects offer greater flexibility, especially when you expect the list of options to change or expand over time.
    // One significant advantage of using scriptable objects over regular enums is the ability to associate additional data with each option.
    // For example, you can include statistics or other custom information related to the choices.
}
