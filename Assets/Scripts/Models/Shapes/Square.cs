using UnityEngine;

namespace Models.Shapes
{
    [CreateAssetMenu(fileName = "New Square", menuName = "Shapes/Square")]
    public class Square : Shape
    {
        public override int CountSides()
        {
            return 4;
        }

        public override void Draw()
        {
            Debug.Log($"Drawing a {shapeColor} square named {shapeName}");
        }
    }
}