using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject

            bullet,
            flashMuzzle;
            // camera;

    // public float

    //         minX,
    //         maxX,
    //         minY,
    //         maxY;

    // Vector3 rot;

    public float nextFire = 0.0f;

    public float fireRate = 0.1f;

    public float reloadTime = 2f;

    public int currentAmmo = 300;

    // private Recoil Recoil_Script;
    // Start is called before the first frame update
    void Start()
    {
        flashMuzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            if (currentAmmo > 0)
            {
                nextFire = Time.time + fireRate;
                Fire();
                flashMuzzle.SetActive(true);
                StartCoroutine(HideMuzzle(0.12f));
                currentAmmo--;
            }
            // rot = camera.transform.localRotation.eulerAngles;
            // if (rot.x != 0 || rot.y != 0)
            // {
            //     camera.transform.localRotation =
            //         Quaternion
            //             .Slerp(camera.transform.localRotation,
            //             Quaternion.Euler(0, 0, 0),
            //             Time.deltaTime * 3);
            // }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Coroutine start;
            start = StartCoroutine(ReloadTime(reloadTime));
            if (Input.GetMouseButton(0)) StopCoroutine(start);
        }
    }

    public void Fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        // AddRecoil();
    }

    // private void AddRecoil()
    // {
    //     float recX = Random.Range(minX, maxX);
    //     float recY = Random.Range(minY, maxY);

    //     camera.transform.localRotation =
    //         Quaternion.Euler(rot.x - recY, rot.y + recX, rot.z);
    // }

    IEnumerator HideMuzzle(float secondUntilDestroy)
    {
        yield return new WaitForSeconds(secondUntilDestroy);
        flashMuzzle.SetActive(false);
    }

    IEnumerator ReloadTime(float reloadTime)
    {
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = 300;
    }
}
