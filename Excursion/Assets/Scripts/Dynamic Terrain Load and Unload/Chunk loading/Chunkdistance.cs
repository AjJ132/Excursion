using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunkdistance : MonoBehaviour
{
    public float playerDistance;
    public Transform player;
    public GameObject ground;
    public int chunksApart = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        if(playerDistance > chunksApart * 175)
        {
            ground.SetActive(false);
        }
        if(playerDistance <= chunksApart * 175)
        {
            ground.SetActive(true);
        }
    }
}
