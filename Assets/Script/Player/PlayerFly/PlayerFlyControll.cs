using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class PlayerFlyControll : MonoBehaviour
{
    private InputAction buttonXAction;
    private InputAction buttonYAction;
    private InputActionMap actionMap;

    void Start()
    {
        // Create input actions for XR buttons
        actionMap = new InputActionMap("XR");
        buttonXAction = actionMap.AddAction("ButtonX", InputActionType.Button, "<XRController>/primaryButton");
        buttonYAction = actionMap.AddAction("ButtonY", InputActionType.Button, "<XRController>/secondaryButton");
        
        actionMap.Enable();
    }

    void Update()
    {
        // Check if X button is pressed
        if (buttonXAction.IsPressed())
        {
            FlyDown();
        }

        // Check if Y button is pressed
        if (buttonYAction.IsPressed())
        {
            FlyUp();
        }
    }

    public void FlyUp()
    {
        transform.position += Vector3.up * Time.deltaTime * 5f;
    }

    public void FlyDown()
    {
        transform.position += Vector3.down * Time.deltaTime * 5f;
    }

    void OnDestroy()
    {
        actionMap?.Dispose();
    }
}
