using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.OpenXR.Input;

public class Removal2 : MonoBehaviour
{
  [SerializeField] public GameObject part;
   


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Windmill")
        {
            Debug.Log("Part");
            part = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == part)
        {
            part = null; 
        }
    }



    public void DestroyPart(InputAction.CallbackContext context)
    {
        Destroy(part);

        Debug.Log("Destroy");
    }

    void Update()
    {
        
    }
}

