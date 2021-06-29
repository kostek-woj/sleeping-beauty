using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private AudioSource _explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        _explosionSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Enemy")) {
            var enemy = other.GetComponent<Enemy>();
            enemy.Hurt(_damage);
            _explosionSound.Play();
            Destroy(gameObject, _explosionSound.clip.length);
            Debug.Log("Mine Triggered");
        }
    }
}
