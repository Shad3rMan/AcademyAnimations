using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        private string _timeString;

        private void Update()
        {
            _text.text = DateTime.Now.ToLongTimeString();
        }
    }
}