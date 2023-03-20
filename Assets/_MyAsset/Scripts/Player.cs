using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attribut
    [SerializeField] private float _speed = 500f;
    [SerializeField] private float _rotationSpeed = 500f;
    private Rigidbody _rb;
    GestionJeu _gestionJeu;

    void Start()
    {
        transform.position = new Vector3(-45f, 21.7f, -45f);
        _rb = GetComponent<Rigidbody>();
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    void FixedUpdate()
    {
        MouvementsPlayer();
    }

    private void MouvementsPlayer()
    {
        // attribut Déplacement normal
        float sprint = _speed * 1.5f;
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new(positionX, 0f, positionZ);

        // Sprint Lorsque le joueur appui sur shift
        if (Input.GetKey(KeyCode.LeftShift))
            _rb.velocity = direction.normalized * Time.fixedDeltaTime * sprint; // Mouvement sprint
        else
            _rb.velocity = direction.normalized * Time.fixedDeltaTime * _speed; // Mouvement normale

        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse); // Mouvement (glisse)

        // Rotation Joueur
        if(direction.magnitude >= 0.1f) // Si le joueur est en mouvement uniquement (garde son angle lorsque immobile)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, _rotationSpeed * Time.deltaTime);
        }
    }
    // Fin de la partie et arret du joueur
    public void FinPartie()
    {
        _gestionJeu.EndGame();
        gameObject.SetActive(false);
    }
}


