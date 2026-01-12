using UnityEngine;

public class Mosquito : MonoBehaviour
{
    public float flySpeed = 5f;
    public float randomChangeInterval = 2f;
    public float maxHeight = 10f;
    public float minHeight = 0f;
    private Vector3 randomDirection;
    private float directionChangeTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateRandomDirection();
    }

    // Update is called once per frame
    void Update()
    {
        FlyRandomly();
    }

    public void FlyRandomly()
    {
        directionChangeTimer -= Time.deltaTime;

        if (directionChangeTimer <= 0f)
        {
            GenerateRandomDirection();
            directionChangeTimer = randomChangeInterval;
        }

        transform.position += randomDirection * flySpeed * Time.deltaTime;

        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minHeight, maxHeight);
        transform.position = clampedPosition;
    }

    private void GenerateRandomDirection()
    {
        randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }
}
