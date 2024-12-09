using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float MovementSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main)
        {
            Vector3 camForward = Camera.main.transform.forward;
            Vector3 camRight = Camera.main.transform.right;
            Debug.Log(Camera.main.name);
        

            float playerHorizontalInput = Input.GetAxisRaw("Horizontal");
            float playerVerticalInput = Input.GetAxisRaw("Vertical");

            camForward.y = 0.0f;
            camRight.y = 0.0f;
            camForward = camForward.normalized;
            camRight = camRight.normalized;

            // if (Input.GetAxisRaw("Horizontal") > 0)
            // {
            //     direction += Vector3.right;    
            // }
            // if (Input.GetAxisRaw("Horizontal") < 0)
            // {
            //     direction += Vector3.left;
            // }
            // if (Input.GetAxisRaw("Vertical") > 0)
            // {
            //     direction += Vector3.up;
            // }
            // if (Input.GetAxisRaw("Vertical") < 0)
            // {
            //     direction += Vector3.down;
            // }

            Vector3 camRelativeMovement= camForward * playerVerticalInput + camRight * playerHorizontalInput;

            transform.Translate(camRelativeMovement * MovementSpeed * Time.deltaTime, Space.World);
        }
    }
}
