using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletionCheck : MonoBehaviour
{

    public void CheckForCompletion()
    {
        if (GetComponentInChildren<SnapManager>().windmillCompleted == true)
        {
            Debug.Log("1");
        }
    }
}
