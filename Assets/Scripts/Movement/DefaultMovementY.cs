
using UnityEngine;
using UnityEngine.InputSystem;

public class DefaultMovementY : MonoBehaviour
{
    private Movement controls;
    private UnityEngine.Vector3 move; 
    public CharacterController character;
    public float moveSpeed = 1f;



    public void Start()
    {
        controls = new Movement();
        
    }

    public void PlayerUpDown()
    {
        //move = controls.Player.YMovement.ReadValue<UnityEngine.Vector3>();
        UnityEngine.Vector3 movement = (move.y * transform.up);
        character.Move(movement * moveSpeed * Time.deltaTime);
    }

    public void Update()
    {
        
    }








}
//private Movement controls;
//private Vector2 move;
//public CharacterController character;
//public float moveSpeed = 1f;



//void Start()
//{
 //   controls = new Movement();
//}

//public void PlayerMovement()
//{
 //   move = controls.Player.ZXMovement.ReadValue<Vector2>();
 //   Vector3 movement = (move.y * transform.up) + (move.x * transform.right);
 //   character.Move(movement * moveSpeed * Time.deltaTime);

//}