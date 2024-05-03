using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField] private float _forceSpeed;

    private Rigidbody _rigidbody;
    private KeyCode _keyCodeA = KeyCode.A;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyCodeA))
        {
            _rigidbody.AddForce(Vector3.back * _forceSpeed);
        }
    }
}