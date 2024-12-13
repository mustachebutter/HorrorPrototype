using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController CharacterController;
    [SerializeField]
    public float MovementSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
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

            Vector3 camRelativeMovement= camForward * playerVerticalInput + camRight * playerHorizontalInput;
            CharacterController.Move(camRelativeMovement * MovementSpeed * Time.deltaTime);            
        }
    }
}
