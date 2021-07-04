using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    [SerializeField] GameObject door = null;
    
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            if(door.activeInHierarchy)
            door.SetActive(false);
        }
    }
}
