using UnityEngine;

namespace Models.Shapes
{
    [CreateAssetMenu(fileName = "New Circle", menuName = "Shapes/Circle")]
    public class Circle : Shape
    {
        public override int CountSides()
        {
            return 0;
        }
        public override void Draw()
        {
            Debug.Log($"Drawing a {shapeColor} circle named {shapeName}");
        } 
    }
}