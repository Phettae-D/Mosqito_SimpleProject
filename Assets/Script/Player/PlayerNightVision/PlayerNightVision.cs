using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNightVision : MonoBehaviour
{
        private InputActionMap actionMap;
        private InputAction nightVision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nightVision = actionMap.AddAction("Attack", InputActionType.Button, "<XRController>/PrimaryAcion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
