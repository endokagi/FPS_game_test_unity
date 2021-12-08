using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRecoil : MonoBehaviour
{
    public Transform Camera;

    public float

            minX,
            maxX,
            minY,
            maxY;

    Vector3 rot;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            AddRecoil();
        }
        rot = Camera.transform.localRotation.eulerAngles;
        // if (rot.x != 0 || rot.y != 0)
        // {
        //     Camera.transform.localRotation =
        //         Quaternion
        //             .Slerp(Camera.transform.localRotation,
        //             Quaternion.Euler(0, 0, 0),
        //             Time.deltaTime * 3);
        // }
    }

    private void AddRecoil()
    {
        float recX = Random.Range(minX, maxX);
        float recY = Random.Range(minY, maxY);

        Camera.transform.localRotation =
            Quaternion.Euler(rot.x, rot.y + recX, rot.z);
    }
}
