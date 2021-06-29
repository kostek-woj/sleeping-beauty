using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _maxEnemies = 5;

    public static int enemiesAmount = 0;
    private GameObject _newEnemy;
    private float _randXposition, _randZposition;
    private Vector3 _spawnPosition;


    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 5f);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void SpawnNewEnemy() {
        if (enemiesAmount < _maxEnemies) {
            _randXposition = Random.Range(-11f, 11f);
            _randZposition = Random.Range(-17f, 0f);

            _spawnPosition = new Vector3(_randXposition, 2f, _randZposition);
            _newEnemy = Instantiate(_enemy, _spawnPosition, Quaternion.identity);
            enemiesAmount++;
            Debug.Log("Spawned an enemy. Total enemies: " + enemiesAmount);
        }
    }
}
