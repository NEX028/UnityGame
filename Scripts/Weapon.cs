using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shooter;
    private Transform firePoint;
    // Start is called before the first frame update

    void Awake()
    {
        firePoint = transform.Find("FirePoint");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        if(bulletPrefab != null && firePoint != null && shooter != null){
            GameObject myBullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity) as GameObject;
            
            Bullet bulletComponent = myBullet.GetComponent<Bullet>();

            if(shooter.transform.localScale.x < 0f){

            }else{

            }
        }
    }
}