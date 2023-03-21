using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege_declencheur_Fleche : MonoBehaviour
{
    private bool _isActive = false;
    [SerializeField] private List<GameObject> _listPiege = new List<GameObject>();
    [SerializeField] private float _vitesse = 1f;

    private void Update()
    {
        if(_isActive)
        {
            foreach (var obj in _listPiege)
            {
                obj.transform.Translate(Vector3.back * Time.deltaTime * _vitesse);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !_isActive)
        {
            _isActive = true;
        }
        
    }
}
