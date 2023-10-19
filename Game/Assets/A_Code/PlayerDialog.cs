using System;
using System.Collections;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
public class PlayerDialog : SerializedMonoBehaviour
{
    [TabGroup("Npcs")]
    public GameObject[] npcs; // her finder vi alle npcerne
    
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private GameObject _closestNpc;
    
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private float _distance;
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private float _talkDistance = 2; //den skal værer inde for denne range for at kunne snakke med npc
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private float startTextSpeed; 
    
    [TabGroup("DialogStats")]
    [InfoBox("hvor hurtig texten burde komme frem burde værer 0.0 et eller andet FX 0.08")]
    [SerializeField] private float playTextSpeed;
    
    [TabGroup("DialogStats")]
    [SerializeField] private int dialogCount = 0;
    
    [TabGroup("DialogStats")]
    [SerializeField] private bool textApperd = true;
    
    [TabGroup("DialogStats")]
    [SerializeField] private bool dialogOngoing;
    
    [TabGroup("DialogStats")]
    [SerializeField]private TMP_Text dialog_Name;
    
    [TabGroup("DialogStats")]
    [SerializeField] private TMP_Text dialog_Text;

    [TabGroup("DialogStats")]
    [SerializeField]private GameObject dialogBagrund;
    
    [TabGroup("DialogStats")]
    [InfoBox("DialogBoxPopUp denne her slider er hvor hurtig den burde gører det")]
    [Range(0.05f,2)]
    [SerializeField]private float BagroundPopUp;

    
     void Start()
     {
         startTextSpeed = playTextSpeed;
         textApperd = true;
         npcs = GameObject.FindGameObjectsWithTag("Npc");
         CloseDialog();
    }

    void Update()
    {
        FindClosestNpc();
        
        if (Vector2.Distance(transform.position, _closestNpc.transform.position) <= _talkDistance &&
            Input.GetKeyDown(KeyCode.E) && dialogOngoing == false)
        {
            DisplayDialog(_closestNpc.GetComponent<CharacterSystem>());}
        
        if (Vector2.Distance(transform.position, _closestNpc.transform.position) >= _talkDistance)
        {
           CloseDialog();}

        if (dialogOngoing == true && Input.GetKeyDown(KeyCode.E) && textApperd == true)
        {
            NextDialog(_closestNpc.GetComponent<CharacterSystem>());}
        
        if (dialogOngoing == true && Input.GetKeyDown(KeyCode.LeftShift) && textApperd == false)
        {
            playTextSpeed = 0;}
        
    }

    void FindClosestNpc()
    {
        for (int i = 0; i < npcs.Length; i++)
        {
            _distance = Vector2.Distance(this.transform.position, npcs[i].transform.position);
            
            if (_distance < _talkDistance)
            {
                _closestNpc = npcs[i];
            }
        }
    }
    void DisplayDialog(CharacterSystem characterKnowledge)
    {
        dialogOngoing = true;
        dialogBagrund.transform.DOScale( new Vector3(1, 1, 1),0.5f);
    }

    void NextDialog(CharacterSystem characterKnowledge)
    {
        DialogCreater charaterDialog = characterKnowledge.dialogs[characterKnowledge.DialogProgress];
        dialog_Name.text = characterKnowledge.characterPersonality.name;
        if (dialogCount >= charaterDialog.stringText.Length )
        {
            CloseDialog();
            return;
        }else
        {
            dialog_Text.text = " ";
            StartCoroutine(PlayText(charaterDialog));}
        
        DisplayDialog(characterKnowledge);
        dialogCount++;
    }
    
    void CloseDialog()
    {
        dialogBagrund.transform.DOScale( new Vector3(0, 0, 0),0.5f);
        dialogCount = 0;
        dialogOngoing = false;
    }


    private IEnumerator PlayText(DialogCreater dialog)
    {
        playTextSpeed = startTextSpeed;
        foreach (char c in dialog.stringText[dialogCount])
        {
            textApperd = false;
            dialog_Text.text += c;
            yield return new WaitForSeconds(playTextSpeed);
        }
        textApperd = true;
    }
}
