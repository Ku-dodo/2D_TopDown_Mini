using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    [SerializeField] private float speed;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    void Update()
    {

    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        _rigidbody.velocity = _movementDirection * speed;
    }
}
