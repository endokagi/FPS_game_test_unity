using UnityEngine;

public class CameraRecoil : MonoBehaviour
{
    // Rotation
    private Vector3

            currentRotation,
            targetRocation;

    // Hipfire Recoil
    [SerializeField]
    private float

            recoilX,
            recoilY,
            recoilZ;

    // Settings
    [SerializeField]
    private float

            snappiness,
            returnSpeed;

    Transform Camera;
    void Start()
    {
    }

    void Update()
    {
        targetRocation = Vector3.Lerp(targetRocation, Vector3.zero, returnSpeed * Time.deltaTime);
        currentRotation = Vector3.Slerp(currentRotation, targetRocation, snappiness * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

public void RecoilFire(){
    targetRocation += new Vector3(recoilX, Random.Range(-recoilY,recoilY),Random.Range(-recoilZ,recoilZ));
}
}
