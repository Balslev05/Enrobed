using System;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;

public class CharacterSystem : SerializedMonoBehaviour
{
    public Npc_Template characterPersonality;
    public DialogCreater[] dialogs;
    public int dialogProgress = 0;
    public bool closest;
    public GameObject TalkBox;

    public void Update()
    {
        if (closest)
        {TalkBox.SetActive(true);}
        else
        {TalkBox.SetActive(false);}
    }
}
