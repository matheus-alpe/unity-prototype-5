using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    private Rigidbody _rb;
    private readonly float _minSpeed = 12;
    private readonly float _maxSpeed = 16;
    private readonly float _maxTorque = 10;
    private readonly float _xRange = 4;
    private readonly float _ySpawnPosition = -6;
    private GameManager _gameManager;

    public int pointValue;
    public ParticleSystem explosionParticle;

    private void Start()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(RandomForce(), ForceMode.Impulse);
        _rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnPosition();
    }

    private void OnMouseDown()
    {
        if (!_gameManager.isGameActive) return;
        Destroy(gameObject);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        _gameManager.UpdateScore(pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            _gameManager.GameOver();
        }
    }


    private Vector3 RandomForce() => Vector3.up * Random.Range(_minSpeed, _maxSpeed);

    private float RandomTorque() => Random.Range(-_maxTorque, _maxTorque);

    private Vector3 RandomSpawnPosition() => new(Random.Range(-_xRange, _xRange), _ySpawnPosition);
}