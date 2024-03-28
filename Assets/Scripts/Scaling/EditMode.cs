using UnityEngine;

public class EditMode : MonoBehaviour
{
    public GameObject[] windmillsToManipulate;

    private void Start()
    {
        windmillsToManipulate = GameObject.FindGameObjectsWithTag("Windmill");
    }

    public void CheckIfBuildMode()
    {
        bool canBuildMode = GetComponentInChildren<SnapManager>().canBuildMode;

        if (canBuildMode == true)
        {
            ActivateBuildMode();
        }
    }

    public void ActivateBuildMode()
    {
        TurnColliderOn();

        if (GetComponent<BoxCollider>().enabled == true)
        {

        }
    }

    public void WindmillScaling()
    {

    }

    void TurnColliderOn()
    {
        for (int i = 0; windmillsToManipulate.Length > i; i++)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
