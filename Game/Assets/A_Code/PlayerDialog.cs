using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using TMPro;
public class PlayerDialog : SerializedMonoBehaviour
{
    private Npc_Template _talkingTo;

    public Transform closesttNpc;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        closesttNpc = GameObject.FindGameObjectWithTag("Npc").transform;

        if (Vector2.Distance(transform.position, closesttNpc.transform.position) < 1)
        {
            Debug.Log("CloseTo a talking npc");
        }
    }
}
