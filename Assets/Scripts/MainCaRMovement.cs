using UnityEngine;

public class MainCaRMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;

    [SerializeField] private float _defaultSpeed;
    private float _dikeyHareket;
    private float _yatayHareket;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _dikeyHareket = Input.GetAxis("Vertical");
        _yatayHareket = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3(_yatayHareket * _horizontalSpeed * Time.deltaTime, _defaultSpeed + _dikeyHareket* 50 * _verticalSpeed * Time.deltaTime);

        if (transform.position.x > 1.85f)
{
    rb.position = new Vector2(1.85f, rb.position.y);
}
else if (transform.position.x < -1.8f)
{
    rb.position = new Vector2(-1.8f, rb.position.y);
}


    }
    
}
