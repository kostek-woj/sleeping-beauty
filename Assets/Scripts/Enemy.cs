using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _lookRadius = 10f;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _moveSpeed = .5f;
    [SerializeField] private int _health = 10;

    // Start is called before the first frame update
    private void Start() {
        
    }

    // Update is called once per frame
    private void Update() {
        float step = _moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, step);
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _lookRadius);
    }

    public void Hurt(int damage) {
        print("Ouch! -" + damage);
        _health -= damage;
        if (_health <= 0) {
            Die();
        }
    }

    private void Die() {
        Destroy(gameObject);
        EnemySpawner.enemiesAmount--;
    }
}
