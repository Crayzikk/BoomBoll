using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Player states
    [SerializeField] private float speed;

    //Components
    private Rigidbody rigidbodyPlayer;

    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        Vector3 velocity = (transform.forward * inputVertical + transform.right * inputVertical).normalized * speed;
        velocity.y = rigidbodyPlayer.linearVelocity.y;
        
        rigidbodyPlayer.linearVelocity = velocity;
    }
}
