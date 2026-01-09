using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public float M_Blood;
    float Blood;
    public bool IsMated, IsFull, ReadyToLay, IsLanded, FoundBloodVessel;
    public Human target;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MaleMos")
        {
            ///Inpuscript
            {
                Mate();
            }
        }
        if (other.gameObject.GetComponent<Human>())
        {
            ///Inpuscript
            {
                Landing(other.gameObject.GetComponent<Human>().gameObject);
            }
        }
    }
    public void Mate()
    {
        IsMated = true;
    }
    public void Landing(GameObject tar)
    {
        gameObject.transform.parent = tar.gameObject.transform;
        IsLanded = true;
    }
    public void FindBlood()
    {

    } 
    public void Drink()
    {

    }
}
