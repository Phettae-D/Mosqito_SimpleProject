using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEditor.Progress;

public class TermalManager : MonoBehaviour
{
    public List<GameObject> termalobj;
    public int TermalLayer;
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

    }
}
