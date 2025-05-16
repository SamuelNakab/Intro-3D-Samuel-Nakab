using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;

    void Start()
    {
        
    }
    public void ClonarCubos()
    {
        Instantiate(cuboPrefab);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
