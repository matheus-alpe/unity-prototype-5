using UnityEngine;

namespace Models.Shapes
{
    [CreateAssetMenu(fileName = "New Triangle", menuName = "Shapes/Triangle")] 
    public class Triangle : Shape
    {
        public override int CountSides()
        {
            return 3;
        }
        public override void Draw()
        {
            Debug.Log($"Drawing a {shapeColor} triangle named {shapeName}");
        } 
    }
}