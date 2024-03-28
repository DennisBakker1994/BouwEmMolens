using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCompatibility : MonoBehaviour
{
    MeshRenderer render;
    Color colorSnap;

    public bool snapable;
    public bool snapping;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        changeColor();
    }

    public void changeColor()
    {
        if (!snapable)
        {
            render.material.color = Color.red;
        }
        else
        {
            render.material.color = Color.green;
        }
    }

    public void changeOpacity()
    {
        if (snapping)
        {
            colorSnap.a = 0.5f;
            render.material.color = colorSnap;
        }
        else
        {
            colorSnap.a = 1f;
            render.material.color = colorSnap;
        }

    }
}
