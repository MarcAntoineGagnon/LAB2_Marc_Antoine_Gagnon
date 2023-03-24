using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listPiege = new List<GameObject>();
    [SerializeField] private Light _lumiere;
    private bool _actif = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_actif)
        {
            foreach (var obj in _listPiege)
            {
                obj.SetActive(false);
            }

            _lumiere.color = Color.green;
            transform.Rotate(90f, 0f, 0f);
            _actif = true;
        }

    }
}
