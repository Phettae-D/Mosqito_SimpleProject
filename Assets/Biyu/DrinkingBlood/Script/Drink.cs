using UnityEngine;

public class Drink : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.GetComponent<Human>())
        {
            print("AAAAAA");
            if (PlayerMain.instance.R_primaryValue && PlayerMain.instance.Current_Blood < PlayerMain.instance.Max_Blood)
            {
                PlayerMain.instance.Drink();
                PlayerMain.instance.canmove = false;
                PlayerMain.instance.gameObject.transform.parent = collision.gameObject.transform;
            }
            else if (!PlayerMain.instance.R_primaryValue)
            {
                PlayerMain.instance.canmove = true;
                PlayerMain.instance.transform.parent = null;
            }
        }
    }
}
