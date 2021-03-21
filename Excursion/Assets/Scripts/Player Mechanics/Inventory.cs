using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public List<GameObject> inventory = new List<GameObject>();
    public float pickupDistance = 5f;
    private RaycastHit inSight;
    private GameObject tempPickup;
    public GameObject[] allItems;
    
    void Start()
    {
        
    }


    void Update()
    {
        
        // Creates raycast to pickup item.
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * pickupDistance, Color.red, 0.5f);
        // Detects raycast hit.
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out inSight, pickupDistance))
        {
            // Sees if raycast is hitting an item.
            if (inSight.transform.gameObject.layer == LayerMask.NameToLayer("Item"))
            {
                // If pressing the item pickup button, item gets picked up.
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    // Stores the item picked up in a temporary variable.
                    tempPickup = inSight.transform.gameObject;
                    // Adds the item picked up to the list.
                    if (tempPickup.tag == "Item")
                    {
                        Debug.Log("added");
                        inventory.Add(allItems[0]);
                        // Destroys the item in the environment.
                        Destroy(tempPickup);
                        //inventory.RemoveAt(inventory.Count - 1);
                    }
                    if (tempPickup.tag == "Item1")
                    {
                        Debug.Log("added");
                        inventory.Add(allItems[1]);
                        Destroy(tempPickup);
                        //inventory.RemoveAt(inventory.Count - 1);
                    }
                    //inventory.Add(tempPickup);
                    
                    
                }
            }
        }
        
    }
}
