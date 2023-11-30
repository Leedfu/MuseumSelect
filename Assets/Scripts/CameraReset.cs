using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Start()
    {
        // Store the original position and rotation of the camera
        originalPosition = Camera.main.transform.position;
        originalRotation = Camera.main.transform.rotation;
    }

    public void ResetCameraPosition()
    {
        // Move the camera back to the original position and rotation
        Camera.main.transform.position = originalPosition;
        Camera.main.transform.rotation = originalRotation;
    }
}