using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    [Header("Wieken")]
    public GameObject pWM1;
    public GameObject pWM2;
    public GameObject pWM3;
    public GameObject pWM4;
    public GameObject pWM5;
    public GameObject pWM6;

    [Header("Top")]
    public GameObject pTM1;
    public GameObject pTM2;
    public GameObject pTM3;
    public GameObject pTM4;
    public GameObject pTM5;
    public GameObject pTM6;

    [Header("Bottem")]
    public GameObject pBM1;
    public GameObject pBM2;
    public GameObject pBM3;
    public GameObject pBM4;
    public GameObject pBM5;
    public GameObject pBM6;

    [Header("Spawnpoint")]
    public Transform spawnpoint;

    public void BuildWM1()
    {
        Instantiate(pWM1, spawnpoint);
    }

    public void BuildWM2() 
    {
        Instantiate(pWM2, spawnpoint);
    }

    public void BuildWM3() 
    {
        Instantiate(pWM3, spawnpoint);
    }

    public void BuildWM4() 
    {
        Instantiate(pWM4, spawnpoint);
    }

    public void BuildWM5() 
    {
        Instantiate(pWM5, spawnpoint);
    }

    public void BuildWM6() 
    {
        Instantiate(pWM6, spawnpoint);
    }

    public void BuildTM1()
    {
        Instantiate(pWM1, spawnpoint);
    }

    public void BuildTM2()
    {
        Instantiate(pTM2, spawnpoint);
    }

    public void BuildTM3()
    {
        Instantiate(pTM3, spawnpoint);
    }

    public void BuildTM4()
    {
        Instantiate(pTM4, spawnpoint);
    }

    public void BuildTM5()
    {
        Instantiate(pTM5, spawnpoint);
    }

    public void BuildTM6()
    {
        Instantiate(pTM6, spawnpoint);
    }

    public void BuildBM1()
    {
        Instantiate(pBM1, spawnpoint);
    }   

    public void BuildBM2()
    {
        Instantiate(pBM2, spawnpoint);
    }

    public void BuildBM3()
    {
        Instantiate(pBM3, spawnpoint);
    }

    public void BuildBM4()
    {
        Instantiate(pBM4, spawnpoint);
    }

    public void BuildBM5()
    {
        Instantiate(pBM5, spawnpoint);
    }

    public void BuildBM6()
    {
        Instantiate(pBM6, spawnpoint);
    }
}
