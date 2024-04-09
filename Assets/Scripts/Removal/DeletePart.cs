using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePart : MonoBehaviour
{

    public void OnTriggerEnter(Collider info)
    {
        if(info.gameObject.CompareTag("DeletePossible"))
        {
            Debug.Log("TRIGGER ENTER");
            Destroy(info.gameObject);
        }
    }


    void Update()
    {
        
    }
}
