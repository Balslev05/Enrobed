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
    public GameObject TalkBox;
    public GameObject player;

    public void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) <= 2)
        {
            TalkBox.SetActive(true);
        }
        else
        {TalkBox.SetActive(false);}
    }
}
