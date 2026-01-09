using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEditor.Progress;

public class TermalManager : MonoBehaviour
{
    public List<GameObject> termalobj;
    public GameObject cam;
    public int TermalLayer;
    public float DetectDis;
    private void OnEnable()
    {
        GameObject[] go = FindObjectsOfType<GameObject>();
        foreach (var item in go)
        {
            if (item.layer == TermalLayer)
            {
                termalobj.Add(item);
            }
        }
    }
    private void Update()
    {
        for (int i = 0; i < termalobj.Count; i++)
        {
            float dis = Vector3.Distance(cam.transform.position, termalobj[i].transform.position);
            if (dis < DetectDis)
            {
                termalobj[i].SetActive(true);
            }
            else
            {
                termalobj[i].SetActive(false);
            }
        }
    }
}
