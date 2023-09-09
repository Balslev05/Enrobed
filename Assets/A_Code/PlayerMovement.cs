using UnityEngine;
using Cinemachine;
using Unity.Mathematics;

public class PlayerMovement : MonoBehaviour
{
    
 public GameObject dustPartical;
 public GameObject pingvinSteppies;
    
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
     
   
    //! Re work this so only when moves and only when powerup, and works in a seperated function 
    GameObject instatietetdust;
   instatietetdust = Instantiate(dustPartical, pingvinSteppies.transform.position, quaternion.identity);
   
   Destroy(instatietetdust,0.3f);
 }
 
}
