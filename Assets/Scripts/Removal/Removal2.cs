using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.OpenXR.Input;

public class Removal2 : MonoBehaviour
{
    private XRIDefaultInputActions inputActions;
    private InputAction button;
    public GameObject part;
    public AudioClip deleteclip;
    public AudioSource source;

    private void Awake()
    {
        inputActions = new XRIDefaultInputActions();
        button = inputActions.Test.Newaction;
    }

    private void OnEnable()
    {
        button.Enable();
    }

    private void Update()
    {

        if (button.IsPressed())
        {
            DestroyPart();
        };
    }

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
        if (other.gameObject == part)
        {
            part = null;
        }
    }



    public void DestroyPart()
    {
       //  source.clip = deleteclip;
       // source.Play();
        Debug.Log("Destroy");
        Destroy(part);

    }
}

   

