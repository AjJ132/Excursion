using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject terrain;
    private string tag;
    MeshRenderer rend;



    void Start()
    {
        tag = terrain.tag;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            terrain.SetActive(false);
        }
    }
}
