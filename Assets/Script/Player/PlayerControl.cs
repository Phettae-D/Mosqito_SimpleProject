using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private InputAction moveAction;
    private InputAction sprintAction;

    private InputActionMap actionMap;
    private Camera mainCamera;
    private Rigidbody rb;

    [SerializeField] private float currentSpeed;
    public float startSpeed;
    public float sprintSpeed;
    
    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>();
        
        // Configure Rigidbody for continuous collision detection
        // rb.isKinematic = true;
        // rb.useGravity = false;
        
        actionMap = new InputActionMap("XR");
        moveAction = actionMap.AddAction("Move", InputActionType.Value, "<XRController>/thumbstick");
        sprintAction = actionMap.AddAction("Sprint", InputActionType.Button, "<XRController>/trigger");
        
        
        actionMap.Enable();
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        if (input != Vector2.zero)
        {
            Move(input);
        }
        if (sprintAction.IsPressed())
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = startSpeed;
            rb.linearVelocity = Vector3.zero;
        }
    }

    public void Move(Vector2 direction)
    {
        Vector3 forward = mainCamera.transform.forward;
        Vector3 right = mainCamera.transform.right;
        
        forward.y = 0;
        forward.Normalize();
        
        Vector3 moveDirection = (forward * direction.y + right * direction.x).normalized;
        rb.linearVelocity = moveDirection * currentSpeed;
    }
}
