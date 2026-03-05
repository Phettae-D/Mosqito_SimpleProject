using UnityEngine;

public class Budget : MonoBehaviour
{
    public GameObject budgetObject;
    public GameObject water;

    public float raycastDistance = 1f;
    public LayerMask groundLayer;

    private bool isHit = false;

    [SerializeField] private float angle = 15f;

    public void Start()
    {
        water.SetActive(true);
    }
    void Update()
    {
        CheckedGround();
    }

    private void CheckedGround()
    {
        Vector3 initialDirection = transform.forward;
        Quaternion rotation = Quaternion.AngleAxis(angle, transform.right);
        Vector3 rotatedDirection = rotation * initialDirection;

        Ray ray = new Ray(transform.position, rotatedDirection);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, groundLayer))
        {
            water.SetActive(false);
            
            if (!isHit)
            {
                GameManager.instance.score++;
                isHit = true;
            }
            
            Debug.DrawLine(transform.position, hit.point, Color.green);
        }
    }
}
