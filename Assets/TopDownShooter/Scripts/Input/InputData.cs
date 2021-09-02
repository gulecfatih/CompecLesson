 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;

        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;


        [Header("Key Base Control")]


       

        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;
        [SerializeField] private float increaseAmount = 0.015f;



        public void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(AxisNameHorizontal);
                Vertical = Input.GetAxis(AxisNameVertical);

            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseHorizontal(ref Horizontal, PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseHorizontal(ref Vertical, PositiveVerticalKeyCode, NegativeVerticalKeyCode);
                }
            }
        }

        private void KeyBaseHorizontal(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positeveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);

            if (positeveActive )
            {
                value += increaseAmount;
            }
            else if (negativeActive)
            {
                value -= increaseAmount;
            }
            else
            {
                value = 0;
            }
            value = Mathf.Clamp(value, -1, 1);
        }

    }



}
