using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lessons
{
    [CreateAssetMenu(menuName = "Lesson/Lesson1/ControlSettingsRigidbody")]
    public class ControlRigidBodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;

        public Vector3 JumpForce { get { return _jumpForce; } }
    }

}

