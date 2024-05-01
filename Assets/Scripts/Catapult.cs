using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Catapult : MonoBehaviour
{
    [SerializeField] private float _forceSpeed;
    [SerializeField] private Transform _gunTransform;

    [SerializeField] private Transform _projectilePosition;
    [SerializeField] private Projectile _projectile;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rigidbody.AddForceAtPosition(Vector3.up * _forceSpeed, _gunTransform.position, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(_projectile, _projectilePosition.position, Quaternion.identity);
        }
    }
}