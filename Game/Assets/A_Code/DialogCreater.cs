using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Dialog", menuName = "Npc/Dialog", order = 1)]
public class DialogCreater : SerializedScriptableObject
{
   [TextArea(4, 10)]
   public string[] stringText;
   
   public Image[] mood;

}
