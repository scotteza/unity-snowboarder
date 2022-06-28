using UnityEngine;

// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _torqueAmount = 3f;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidBody.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidBody.AddTorque(-_torqueAmount);
        }
    }
}
