using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField]
    public Camera cameraToSet;
    private Camera previousCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("Triggered");
            previousCamera = Camera.main;

            previousCamera.gameObject.SetActive(false);
            cameraToSet.gameObject.SetActive(true);

            previousCamera.tag = "Untagged";
            cameraToSet.tag = "MainCamera";

            cameraToSet = previousCamera;
        }
    }
}
