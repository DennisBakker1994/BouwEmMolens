using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindmillInformation : MonoBehaviour
{
    public enum Part
    {
        BOTTOM,
        TOP,
        WINDMILLBLADES
    }

    public Part part;

    public enum Era
    {
        TRADITIONAL,
        MODERN
    }

    public Era era;
}
