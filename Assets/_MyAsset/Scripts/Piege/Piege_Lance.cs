using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege_Lance : MonoBehaviour
{
    GestionJeu _gestionJeu;
    Player _player;
    [SerializeField] private float _vitesse = 10f;
    [SerializeField] private float _temps = 0.5f;
    [SerializeField] private float _delais = 1f;
    private float _timer;
    private float _timerDelais;
    private bool _retour = false;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < _temps)
        {
            if(!_retour) 
            {
                transform.Translate(Vector3.up * Time.deltaTime * _vitesse);
            }
            else
            {
                transform.Translate(Vector3.down * Time.deltaTime * _vitesse);
            }  
        }
        else
        {
            _timerDelais += Time.deltaTime;
            if (_timerDelais >= _delais && _retour == false)
            {
                _timerDelais = 0f;
                _timer = 0f;
                _retour = true;
            }
            else if (_timerDelais >= _delais && _retour == true)
            {
                _timerDelais = 0f;
                _timer = 0f;
                _retour = false;
            }
        }

    }

    // Si le joueur touche au lance il se fait empaler (+1 pointage + immobile jusqu'a ce que les lances s'enleve)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gestionJeu.AugmenterPointage();
            _player.immobile();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _player.mobile();
    }
}
