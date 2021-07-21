using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header ("Rotation")]
        [SerializeField] private float rotationLerpSpeed = 1; 
        public float RotationLerpSpeed { get { return rotationLerpSpeed; } }


        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 _PositionOffset { get { return _positionOffset; } }

        [SerializeField] private float _positionLerp = 1;
        public float _PositionLerp { get { return _positionLerp; } }
    }

}
