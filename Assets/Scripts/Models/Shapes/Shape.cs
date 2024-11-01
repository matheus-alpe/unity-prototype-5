using UnityEngine;

namespace Models.Shapes
{
    public abstract class Shape : ScriptableObject
    {
        [SerializeField] protected string shapeName;
        [SerializeField] protected Color shapeColor = Color.white;

        public abstract int CountSides();
        public abstract void Draw();

        public string Name => shapeName;
        public Color Color => shapeColor;
    }
}