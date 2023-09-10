using System;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using TMPro;
public class PlayerDialog : SerializedMonoBehaviour
{
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private Npc_Template _talkingTo;

    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    public GameObject[] npcs;

    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private float _distance;
    
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private float _nearestdistance;
    
    [ShowInInspector] 
    [TabGroup("PrivateVariable")]
    private GameObject _closestNpc;
    
    // Update is called once per frame
     void Start()
    {
        npcs = GameObject.FindGameObjectsWithTag("Npc");
    }

    void Update()
    {
        for (int i = 0; i < npcs.Length; i++)
        {
            _distance = Vector2.Distance(this.transform.position, npcs[i].transform.position);
            
            if (_distance < _nearestdistance)
            {
                _closestNpc = npcs[i];
                _nearestdistance = _distance;
            }
        }
        
        if (Vector2.Distance(transform.position, _closestNpc.transform.position) <= 2 && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(_closestNpc.GetComponent<CharacterSystem>().characterPersonality.name);
        }
    }
}
