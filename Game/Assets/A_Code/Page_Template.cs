using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "Page", menuName = "Page/Character", order = 1)]
public class Page_Template : SerializedScriptableObject
{
    [EnumToggleButtons]
    public page pageType;
   public enum page
    {
        Character,
        Powers,
    }
   
    [ShowIf("pageType",page.Character)]
    [PreviewField(40)]
    public Sprite Character_Pfp;
    
    [ShowIf("pageType", page.Character)]
    [PreviewField(40)]
    public Sprite Character_FromWere;
    
    [ShowIf("pageType", page.Character)]
    [TextArea(20,10)]
    public string Character_descreption;
    
    
    
    [ShowIf("pageType", page.Powers)]
    [PreviewField(40)]
    public Sprite Powers_Pfp;
    
    [ShowIf("pageType", page.Powers)]
    [PreviewField(40)]
    public Sprite Powers_FromWere;
    
    [ShowIf("pageType", page.Powers)]
    [TextArea(20,10)]
    public string Powers_descreption;
    
}
