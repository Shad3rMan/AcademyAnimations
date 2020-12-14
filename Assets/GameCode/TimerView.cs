using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        private void Update()
        {
            var dateTime = DateTime.Now;
            var seconds = dateTime.Second;
            var minutes = dateTime.Minute;
            var hours = dateTime.Hour;
            var timeString = $"{hours}:{minutes}:{seconds}";
            _text.text = timeString;
        }
    }
}