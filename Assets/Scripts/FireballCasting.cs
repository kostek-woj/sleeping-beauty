using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCasting : MonoBehaviour
{
    [SerializeField] private GameObject _spell;
    [SerializeField] private float _speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(_spell, transform.position, Quaternion.identity);
        }
    }
}
