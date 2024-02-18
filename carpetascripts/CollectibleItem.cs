using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public int healthrestoration = 1;
    public GameObject lightingParticles;
    public GameObject burstingParticles;

    private SpriteRenderer _renderer;
    private Collider2D _collider;


    // Start is called before the first frame update
    void Start()
    {
        _renderer =GetComponent<SpriteRenderer>();
        _collider =GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            collision.SendMessageUpwards("AddHealth", healthrestoration);
            _collider.enabled = false;

            _renderer.enabled = false;
            lightingParticles.SetActive(false);
            burstingParticles.SetActive(true);

            Destroy(gameObject, 2f);

        }
    }
}
