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
        if (previousSnapManager != null)
        {
            previousSnapManager.GetComponent<SnapManager>().CheckIfCanSnap();
        }
    }

    public void NullPreviousSnapManager()
    {
        if (previousSnapManager != null)
        {
            previousSnapManager.GetComponent<SnapManager>().UnsnapPart();
        }
    }

    public void CheckIfCanSnap()
    {

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.BOTTOM && otherPart == WindmillInformation.Part.TOP)
        {
            canSnap = true;
            
            AllowSnapPart();
        }

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.TOP && otherPart == WindmillInformation.Part.WINDMILLBLADES)
        {
            canSnap = true;
            
            AllowSnapPart();

        }
    }

    public void AllowSnapPart()
    {
        Debug.Log("Function Call" + this.GetComponentInParent<Transform>().gameObject.name);
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

            isSnapped = true;
        }
    }

    public void UnsnapPart()
    {
        if (canSnap == true && isSnapped == true)
        {
            partToSnap.transform.position = originalPosition;

            partToSnap.GetComponent<Rigidbody>().isKinematic = false;

            partToSnap.transform.SetParent(null);

            snappingPoint.GetComponent<SphereCollider>().enabled = true;

            if (partToSnap.GetComponentInChildren<WindmillInformation>().part != WindmillInformation.Part.WINDMILLBLADES)
            {
                partToSnap.GetComponentInChildren<SnapManager>().snappingPoint.GetComponent<SphereCollider>().enabled = false;
            }
        }
    }
}
