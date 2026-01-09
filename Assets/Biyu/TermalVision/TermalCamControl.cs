using UnityEngine;

public class TermalCamControl : MonoBehaviour
{
    public GameObject termalobj;
    public bool termalmode;
    public GameObject target;
    private void Update()
    {
        transform.LookAt(target.transform);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (!termalmode)
        //    {
        //        termalmode = true;
        //    }
        //    else
        //    {
        //        termalmode = false;
        //    }
        //    termalobj.SetActive(termalmode);
        //}
    }
}
