using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 25;
    [SerializeField] private float boostSpeed = 50;
    [SerializeField] private float baseSpeed = 20;

    private Rigidbody2D _rigidBody;
    private SurfaceEffector2D _surfaceEffector2D;
    private GameState _gameState;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        _gameState = FindObjectOfType<GameState>();
    }

    private void Update()
    {
        if (!_gameState.IsPlayerAlive())
        {
            return;
        }
        
        RotatePlayer();
        Boost();
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidBody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidBody.AddTorque(-torqueAmount);
        }
    }

    private void Boost()
    {
        _surfaceEffector2D.speed = Input.GetKey(KeyCode.Space) ? boostSpeed : baseSpeed;
    }
}
