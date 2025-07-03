using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private Transform cameraTransform;
    private Transform gameObjectTransform;
    private Vector3 gObjVector;
    private void Awake() 
    {
        cameraTransform = this.GetComponent<Transform>();
        gameObjectTransform = obj.GetComponent<Transform>();
    }

    private void FixedUpdate() 
    {
        gObjVector = new Vector3(gameObjectTransform.position.x, gameObjectTransform.position.y, cameraTransform.position.z);
        cameraTransform.position = gObjVector;
    }

}
