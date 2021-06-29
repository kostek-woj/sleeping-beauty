using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject _spell;
    [SerializeField] private Transform _castPoint;

    private Vector3 _destination;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            //Instantiate(_spell, new Vector3(0f, 3f, 0f), Quaternion.identity);
            CastSpell();
        }
    }

    private void CastSpell() {
        RaycastHit hit;
        Ray ray = _cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit)) {
            _destination = hit.point;
        } else {
            _destination = ray.GetPoint(1000);
        }

        InstantiateSpell(_castPoint);
    }

    private void InstantiateSpell(Transform castPoint) {
        var spellObj = Instantiate(_spell, castPoint.position, Quaternion.identity) as GameObject;
    }
}
