using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    [SerializeField] GameObject winMessage;
    
    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if(!winMessage.activeInHierarchy)
                winMessage.SetActive(true);
        }
    }
}
