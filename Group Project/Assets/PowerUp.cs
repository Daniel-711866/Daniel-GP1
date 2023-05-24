using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float multiplier = 1.4f;
    public float duration = 4f;
    public GameObject pickupEffect;

    [SerializeField] private AudioSource powerSoundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
            powerSoundEffect.Play();

        }

    }

    IEnumerator Pickup(Collider2D player)
    {

        // Spawm a cool effect

        Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply effect to the player

        //example such as increasing size of the player code
        player.transform.localScale *= multiplier;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);


        player.transform.localScale /= multiplier;

        Destroy(gameObject);
    }


}
