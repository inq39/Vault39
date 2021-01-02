using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private AudioSource _shootSound;
    private Rigidbody _bulletRb;
    private Transform _bullets;
    // Start is called before the first frame update
    void Start()
    {
        _bullets = GameObject.FindGameObjectWithTag("Bullets").GetComponent<Transform>();
        if (_bullets == null)
        {
            Debug.LogError("BulletContainer is null.");
        }

        this.transform.parent = _bullets;

        _bulletRb = GetComponent<Rigidbody>();
        if (_bulletRb == null)
        {
            Debug.LogError("BulletRb is null");
        }

        //_shootSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        _bulletRb.AddForce(Vector3.forward * _bulletSpeed);
    }
}
