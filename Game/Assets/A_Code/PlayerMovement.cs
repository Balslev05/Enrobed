using UnityEngine;
using Cinemachine;
using Unity.Mathematics;

public class PlayerMovement : MonoBehaviour
{
    
 [SerializeField] float runSpeed = 20.0f;

 Rigidbody2D _body;
 float _horizontal;
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
    _body.velocity = new Vector2(_horizontal * runSpeed, _vertical * runSpeed);
 }
 
}
