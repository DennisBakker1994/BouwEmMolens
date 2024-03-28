using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject[] builds;

    public int buildingStyle;

    public void ChangeIntPlus()
    {

        if (buildingStyle == builds.Length -1)
        {
            buildingStyle = 0;

            SetAllToFalse();
            builds[buildingStyle].SetActive(true);
            Debug.Log(buildingStyle);

        }
        else
        {
            buildingStyle ++;

            SetAllToFalse();
            builds[buildingStyle].SetActive(true);
            Debug.Log(buildingStyle);
        }
    }

    public void ChangeIntMinus()
    {

        if (buildingStyle == 0)
        {
            buildingStyle = builds.Length -1;

            SetAllToFalse();
            builds[buildingStyle].SetActive(true);

        }
        else
        {
            buildingStyle --;

            SetAllToFalse();
            builds[buildingStyle].SetActive(true);
        }
    }

    void SetAllToFalse()
    {
        foreach (GameObject go in builds)
        {
            go.SetActive(false);
        }
    }
}
