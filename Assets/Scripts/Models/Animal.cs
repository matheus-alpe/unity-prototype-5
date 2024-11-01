using System;
using UnityEngine;

namespace Models
{
    public class Animal : MonoBehaviour
    {
        public float hp;
    }

    public class Human : Animal
    {
        private void Awake()
        {
            Debug.Log("Player is Awake");
        }

        private void Start()
        {
            Debug.Log(gameObject.name + " has started with: " + hp);
        }

        protected void DoTaxes()
        {
            Debug.Log(gameObject.name + " is doing tax");
        }
    }

    public class Cat : Animal
    {
        void Pounce()
        {
            Debug.Log(gameObject.name + " is pouncing");
        }
    }
}