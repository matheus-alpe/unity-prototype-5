using Models;
using Models.Shapes;
using UnityEngine;

public class Player : Human
{
    [SerializeField] private Shape[] shapes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var shape in shapes)
            {
                Debug.Log($"Shape has: {shape.CountSides()} sides.");
                shape.Draw();
            }
        }
    }
}