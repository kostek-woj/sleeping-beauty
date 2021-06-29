using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator _door = null;
    [SerializeField] private AudioSource _doorOpenSound;
    //[SerializeField] private AudioClip _doorCloseClip;

    private void Start() {
        _doorOpenSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(OpenDoor());
        }
    }

    IEnumerator OpenDoor() {
        _door.Play("DoorOpen", 0, 0f);
        _doorOpenSound.Play();

        yield return new WaitForSeconds(3);
        
        _door.Play("DoorClose", 0, 0f);
        //_doorCloseSound.Play();
        _doorOpenSound.Play();
    }
}
