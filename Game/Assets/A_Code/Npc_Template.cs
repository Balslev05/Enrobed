using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "Npc", menuName = "Npc/Character", order = 1)]
public class Npc_Template : SerializedScriptableObject
{
    [TabGroup("PersonTraits")]
    [SerializeField] string name;
    
    [TabGroup("PersonTraits")]
    [TextArea(5, 10)]
    [SerializeField] string person_Descrebtion;

    [PreviewField]
    [TabGroup("Moods")]
    [GUIColor("#f8d664")]
    public Sprite happy;
    
    [PreviewField]
    [TabGroup("Moods")]
    [GUIColor("#0071b6")]
    public Sprite sad;
    
    
    [PreviewField]
    [TabGroup("Moods")]
    [GUIColor("#D70040")]
    public Sprite angry;
    
    
    [PreviewField]
    [TabGroup("Moods")]
    [GUIColor("#997950")]
    public Sprite normal;
    
}
