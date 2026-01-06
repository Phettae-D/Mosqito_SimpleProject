using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
         if (Input.GetKey(KeyCode.Space))
        {
            moveSpeed = 25f;
        }
        else
        {
            moveSpeed = 5f;
        }
    }

    private void Movement()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

       
    }
}
