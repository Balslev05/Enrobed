using UnityEngine;
using Cinemachine;
using Unity.Mathematics;
using Sirenix.OdinInspector;

public class PlayerMovement : SerializedMonoBehaviour
{
   [TabGroup("Stats")]
   [Range(1,15)]
   [SerializeField] int walkspeed;

 
    [ShowInInspector]
    [TabGroup("PrivateVaribals")]
    Rigidbody2D _body;
 
    [ShowInInspector]
    [TabGroup("PrivateVaribals")]
    float _horizontal;
 
    [ShowInInspector]
    [TabGroup("PrivateVaribals")]
    float _vertical;
 
    void Start ()
    {
       _body = GetComponent<Rigidbody2D>();
    }
    
    void Update ()
    {
       _horizontal = Input.GetAxisRaw("Horizontal");
       _vertical = Input.GetAxisRaw("Vertical");
    }
    
    private void FixedUpdate()
    {  
       _body.velocity = new Vector2(_horizontal * walkspeed, _vertical * walkspeed);
    }
 
}
