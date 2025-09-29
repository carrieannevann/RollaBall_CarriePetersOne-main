using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * speed);
    }

       void OnTriggerEnter(Collider other) 
   {
           if (other.gameObject.CompareTag("PickUp")) 
       {
       {
                  if (other.gameObject.CompareTag("PickUp")) 
       {
           other.gameObject.SetActive(false);
       }

       }
       }
   other.gameObject.SetActive(false);
   }
}
