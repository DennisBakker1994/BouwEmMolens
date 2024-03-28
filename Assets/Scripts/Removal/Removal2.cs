using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.OpenXR.Input;

public class Removal2 : MonoBehaviour
{
  [SerializeField] public GameObject part;

    void Start()
    {
        
    }
    [SerializeField] public void DestroyPart()
    {
        Destroy(part);
    }

    void Update()
    {
        
    }
}

