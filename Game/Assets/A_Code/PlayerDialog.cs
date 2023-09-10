using System;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using TMPro;
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
    
    private float _talkDistance = 2; //den skal værer inde for denne range for at kunne snakke med npc
    
     void Start()
    {
        npcs = GameObject.FindGameObjectsWithTag("Npc");
    }

    void Update()
    {
        FindClosestNpc();
        
        if (Vector2.Distance(transform.position, _closestNpc.transform.position) <= _talkDistance && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(("Hej mit navn er ") + _closestNpc.GetComponent<CharacterSystem>().characterPersonality.name);
        }
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
}
