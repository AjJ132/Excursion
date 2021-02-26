using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicTerrainLoad : MonoBehaviour
{

    public GameObject Chunk;
    private string tag;
    MeshRenderer rend;

    void Start()
    {

        tag = Chunk.tag;
        Chunk.SetActive(true);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Terrain")
        {
            Chunk.SetActive(true);
        }
        else
          {
            Chunk.SetActive(false);
        }

    }

}
