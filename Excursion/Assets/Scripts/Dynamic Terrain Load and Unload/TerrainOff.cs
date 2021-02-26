using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainOff : MonoBehaviour
{
    public GameObject terrain;
    private string tag;
    MeshRenderer rend;



    // Start is called before the first frame update
    void Start()
    {
        tag = terrain.tag;
        terrain.SetActive(false);
    }

}
