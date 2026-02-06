using UnityEngine;
using ZTH.Unity.Tool;

public class Test : MonoBehaviour
{
    private void Start()
    {
        cameraFollower = transform.FindNode("CameraFollower");
    }

    private void Update()
    {
        Camera.main.transform.position = cameraFollower.position;
    }

    private Transform cameraFollower;
}
