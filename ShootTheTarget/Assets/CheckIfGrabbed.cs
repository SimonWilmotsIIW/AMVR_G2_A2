using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrabbed : MonoBehaviour
{
    private OVRGrabbable grabbable;
    public GameObject bulletPrefab;
    public float bulletSpeed=10;
    public GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        grabbable = transform.GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbable.isGrabbed)
        {
            Collider gunCollider = transform.GetComponentInChildren<Collider>();
            gunCollider.isTrigger = false;

            OVRGrabber grabber = grabbable.grabbedBy;
            GameObject controller = grabber.gameObject;

            Debug.Log(controller);

            if (controller.name.Contains("Right")){
                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                {
                    ShootGun();
                }
            }

            if (controller.name.Contains("Left"))
            {
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    ShootGun();
                }
            }
            
        } else
        {
            Collider gunCollider = transform.GetComponentInChildren<Collider>();
            gunCollider.isTrigger = true;
        }
    }

    void ShootGun()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

        Rigidbody rbBullet = bullet.GetComponent<Rigidbody>();

        rbBullet.velocity = bulletSpawnPoint.transform.forward * bulletSpeed;

        rbBullet.useGravity = false; // Disable gravity initially

        // Start a coroutine to enable gravity after a delay
        StartCoroutine(EnableGravityAfterDelay(rbBullet, 4));

        Destroy(bullet, 10f);
    }

    private IEnumerator EnableGravityAfterDelay(Rigidbody rbBullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        rbBullet.useGravity = true; // Enable gravity after the delay
    }
}