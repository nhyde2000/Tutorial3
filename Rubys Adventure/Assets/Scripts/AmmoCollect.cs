using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCollect : MonoBehaviour
{
    public GameObject pickupParticlePrefab;
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.currentAmmo  > 0)
            {
                controller.ChangeAmmo(1);
                GameObject pickupParticleObject= Instantiate(pickupParticlePrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }
}