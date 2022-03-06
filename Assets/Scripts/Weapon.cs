using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float range = 100f;
    public int totalBullets = 30;
    public int bulletsLeft;

    public float fireRate = 0.1f;
    private float fireTime;

    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            //Metodo de tiro
            Fire();
        }

        if(fireTime < fireRate)
        {
            fireTime += Time.deltaTime;
        }
    }

    private void Fire()
    {
        if(fireTime < fireRate)
        {
            return;
        }
        RaycastHit hit;

        if (Physics.Raycast(shootPoint.position, shootPoint.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }

        //Debug.Log("Fire");
        fireTime = 0f;
    }
}
