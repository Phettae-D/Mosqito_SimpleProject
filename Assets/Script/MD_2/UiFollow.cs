using UnityEngine;

public class UiFollow : MonoBehaviour
{
    [Header("Follow Settings")]
    [SerializeField] private Transform targetPlayer;
    [SerializeField] private float distanceFromPlayer = 2f;
    [SerializeField] private Vector3 positionOffset = Vector3.zero;
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private bool useSmoothFollow = true;
    [SerializeField] private bool facePlayer = true;

    private Vector3 targetPosition;

    private void Start()
    {
        if (targetPlayer == null)
        {
            targetPlayer = Camera.main.transform;
        }
    }

    private void Update()
    {
        if (targetPlayer == null) return;

        targetPosition = targetPlayer.position + targetPlayer.forward * distanceFromPlayer + positionOffset;

        if (useSmoothFollow)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = targetPosition;
        }

        if (facePlayer)
        {
            transform.LookAt(targetPlayer);
            transform.Rotate(0, 0, 0);
        }
    }
}
