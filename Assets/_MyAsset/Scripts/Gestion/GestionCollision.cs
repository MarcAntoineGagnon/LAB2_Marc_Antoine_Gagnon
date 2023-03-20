using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private bool _touche = false;
    private GestionJeu _gestionJeu;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _touche = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && _touche == false)
        {
            _touche = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            _gestionJeu.AugmenterPointage();
        }
    }
}
