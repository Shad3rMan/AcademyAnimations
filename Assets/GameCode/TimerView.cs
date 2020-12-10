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
            var seconds = DateTime.Now.Second;
            var minutes = DateTime.Now.Minute;
            var hours = DateTime.Now.Hour;
            var timeString = hours + ":" + minutes + ":" + seconds;
            _text.text = timeString;
        }
    }
}