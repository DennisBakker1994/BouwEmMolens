using UnityEngine;

public class SnapManager : MonoBehaviour
{
    [Header("Variable")]
    public bool canSnap;
    public bool isSnapped;
    Vector3 originalPosition;
    public GameObject snappingPoint;
    public Transform partToSnap;
    public GameObject previousSnapManager;
    public Rigidbody rb;

    public WindmillInformation.Part otherPart;

    private void Start()
    {
        originalPosition = gameObject.GetComponentInParent<Transform>().transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Windmill")
        {
            otherPart = other.gameObject.GetComponentInParent<WindmillInformation>().part;
            partToSnap = other.gameObject.transform;
            partToSnap.GetComponentInChildren<SnapManager>().previousSnapManager = this.gameObject;
        }
    }

    public void SetPreviousSnapManager()
    {
        if (previousSnapManager != null && isSnapped == false)
        {
            previousSnapManager.GetComponent<SnapManager>().CheckIfCanSnap();
        }
        else if (previousSnapManager != null && isSnapped == true)
        {
            UnsnapPart();
        }
    }

    public void NullPreviousSnapManager()
    {
        if (previousSnapManager != null && isSnapped == true)
        {
            previousSnapManager.GetComponent<SnapManager>().UnsnapPart();
        }
    }

    public void CheckIfCanSnap()
    {

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.BOTTOM && otherPart == WindmillInformation.Part.TOP)
        {
            canSnap = true;
            
            if (partToSnap.GetComponentInChildren<SnapManager>().isSnapped == false)
            {
                AllowSnapPart();
            }
        }

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.TOP && otherPart == WindmillInformation.Part.WINDMILLBLADES)
        {
            canSnap = true;
            
            if (partToSnap.GetComponentInChildren<SnapManager>().isSnapped == false)
            {
                AllowSnapPart();
            }

        }
    }

    public void CheckifSnapped()
    {
        
    }

    public void AllowSnapPart()
    {
        if (canSnap == true)
        {
            partToSnap.transform.position = snappingPoint.transform.position;
            partToSnap.GetComponent<Rigidbody>().isKinematic = true;

            partToSnap.transform.SetParent(this.transform);            

            snappingPoint.GetComponent<SphereCollider>().enabled = false;

            if (partToSnap.GetComponent<WindmillInformation>().part != WindmillInformation.Part.WINDMILLBLADES)
            {
                partToSnap.GetComponentInChildren<SnapManager>().snappingPoint.GetComponent<SphereCollider>().enabled = true;
            }

            partToSnap.GetComponentInChildren<SnapManager>().isSnapped = true;
        }
    }

    public void UnsnapPart()
    {
        if (isSnapped == true)
        {
            previousSnapManager.GetComponent<SnapManager>().partToSnap = null;
            previousSnapManager.GetComponentInChildren<SnapManager>().snappingPoint.GetComponent<SphereCollider>().enabled = true;
            previousSnapManager = null;
            canSnap = false;

            if (canSnap == false)
            {
                rb.isKinematic = false;

                rb.transform.SetParent(null);

            }

            isSnapped = false;

        }
    }
}
