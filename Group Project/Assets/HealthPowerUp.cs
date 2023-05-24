using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public float multiplier = 1.4f;
    public float duration = 4f;

    public GameObject pickupEffect;


    [SerializeField] private AudioSource healthSoundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           StartCoroutine( Pickup(other) );
            healthSoundEffect.Play();


        }

    }

    IEnumerator Pickup(Collider2D player)
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);


        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.health *= multiplier;

        yield return new WaitForSeconds(duration);

        stats.health /= multiplier;

        Destroy(gameObject);
    }
}
