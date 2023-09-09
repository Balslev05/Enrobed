using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Npc", menuName = "Npc/Character", order = 1)]
public class Npc_Template : ScriptableObject
{
    public string name;
    
    [Header("Moods")]
    public Sprite happy;
    public Sprite sad;
    public Sprite angry;
    public Sprite normal;
}
