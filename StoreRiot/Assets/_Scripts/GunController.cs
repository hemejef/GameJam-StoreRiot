using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    public bool isFiring = false;
    [SerializeField] float roundsPerMin, bulletSpeed;
    [SerializeField] MoveBullet bullet;
    [SerializeField] Transform barrelEnd;
    float timeBetweenShots;
    float shotCd;

	// Use this for initialization
	void Start () {
        timeBetweenShots = 60f / roundsPerMin;
    }
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            shotCd -= Time.deltaTime;
            if (shotCd <= 0)
            {
                MoveBullet newBullet = Instantiate(bullet, barrelEnd.position, barrelEnd.rotation) as MoveBullet;
                newBullet.speed = bulletSpeed;
                shotCd = timeBetweenShots;
            }
        }
	}
}
