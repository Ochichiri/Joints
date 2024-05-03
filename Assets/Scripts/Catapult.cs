using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Catapult : MonoBehaviour
{
    [SerializeField] private float _forceSpeed;
    [SerializeField] private Transform _gunTransform;

    [SerializeField] private Transform _projectilePosition;
    [SerializeField] private Projectile _projectile;

    private Rigidbody _rigidbody;

    private KeyCode _keyCodeD = KeyCode.D;
    private KeyCode _keyCodeS = KeyCode.S;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyCodeD)
        {
            _rigidbody.AddForceAtPosition(Vector3.up * _forceSpeed, _gunTransform.position, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(_keyCodeS))
        {
            Instantiate(_projectile, _projectilePosition.position, Quaternion.identity);
        }
    }
}