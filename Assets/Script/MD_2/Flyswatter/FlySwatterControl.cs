using UnityEngine;

public class FlySwatterControl : MonoBehaviour
{
    public GameObject rightHand;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fly"))
        {
            Destroy(other.gameObject);
        }
    }

    public void ChangeHand()
    {
        rightHand.SetActive(true);
        gameObject.SetActive(false);
    }
}
