using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePart : MonoBehaviour
{
    //OnCollisionEnter
    public void OnCollisionEnter(Collision other)
    {
        //If the tag on the gameobject is windmill
        if (other.gameObject.tag == "Windmill")
        {
            //Destroy the part
            Destroy(other.gameObject);
        }


    }
    


    // if(other.gameobject.tag == "part" || other.gameobject.tag == "part2")

}


