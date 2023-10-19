using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "Npc", menuName = "Npc/Character", order = 1)]
public class Npc_Template : SerializedScriptableObject
{
    [TabGroup("PersonTraits")]
    [InfoBox("Navnet er barer deres navn")]
    public  string name;
    
    [TabGroup("PersonTraits")]
    [InfoBox("Den er ligegyldig for spillet lige pt men det er deres personlighed")]
    [TextArea(5, 10)]
    [SerializeField] public string person_Descrebtion;

    [PreviewField]
    [InfoBox("Her er alle deres personligheder som fx. Glad, det er billerne i deres dialog UI der ændre sig")]
    [TabGroup("Moods")] 
    [GUIColor("#f8d664")] // color Yellow 
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
