using UnityEngine;

public class DestroyOutOfBoundaries : MonoBehaviour
{
    private readonly float _yBoundary = -10f;
    private void FixedUpdate()
    {
        DestroyOffScreen();
    }

    private void DestroyOffScreen()
    {
        if (transform.position.y < _yBoundary) Destroy(gameObject);
    }
}