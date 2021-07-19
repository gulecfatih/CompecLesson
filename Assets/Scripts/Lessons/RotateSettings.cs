using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lesson/Lesson1/RotateSettings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 10; // value de�eri yaz�l�yor
        public float Speed { get { return _speed; } }
    }

}
