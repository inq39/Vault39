using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _fireRate;
    private float _fireRateTimer;
    private GameObject _bulletSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        _bulletSpawnPosition = GameObject.FindWithTag("Bullets");

        if(_bulletSpawnPosition == null)
        {
            Debug.LogError("_bulletSpawnPosition is null.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        _fireRateTimer += Time.deltaTime;
        ShootWeapon();
    }

    private void ShootWeapon()
    {
        if (Input.GetMouseButtonDown(0) && _fireRateTimer >= _fireRate)
        {
            Instantiate(_bulletPrefab, _bulletSpawnPosition.transform.position, transform.rotation);
            _fireRateTimer = 0;

        }
    }
}
