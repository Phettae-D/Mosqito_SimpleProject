using UnityEngine;

public class Jar : MonoBehaviour
{
    public GameObject hintPos;
    public GameObject jarHat;
    public GameObject jarHatS;
    public bool isRage;

    void Start()
    {
        hintPos.SetActive(false);
        jarHatS.SetActive(false);
        isRage = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jar_Hat"))
        {
            hintPos.SetActive(true);
            isRage = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jar_Hat"))
        {
            hintPos.SetActive(false);
            isRage = false;
        }
    }

    public void onHowerExit()
    {
        if (isRage)
        {
            jarHatS.SetActive(true);
            jarHat.SetActive(false);
            hintPos.SetActive(false);
            GameManager.instance.GetScore(1);
        }
    }
}
