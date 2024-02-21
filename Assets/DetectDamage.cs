using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDamage : MonoBehaviour
{

    public bool beInFire;
    public bool stopDealDamage;
    FPSController fPSController;

    void Start()
    {
        fPSController = GetComponent<FPSController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(beInFire)
        {
            StartCoroutine(DamageFromFire());
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "fire")
        {
            InvokeRepeating("DamageFromFire2", 0, 1);
//            beInFire = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "fire")
        {
            CancelInvoke("DamageFromFire2");
            beInFire = false;
            StopCoroutine(DamageFromFire());
        }
    }
    IEnumerator DamageFromFire()
    {
        yield return new WaitForSeconds(1);
        fPSController.TakeDamage(20);
    }
    void DamageFromFire2()
    {
        fPSController.TakeDamage(20);
    }
}
