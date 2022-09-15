using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter1 : MonoBehaviour
{
    public GameObject tpPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter(Collider other)
   // {
        //thePlayer.transform.position = teleportTarget.transform.position;
    //}

    void OnTriggerEnter(Collider Col) {
        if (Col.gameObject.tag == "Player")
            Col.gameObject.transform.position = tpPoint.transform.position;
        Col.transform.position = new Vector3 (18f,1f,30f);
    }
}
