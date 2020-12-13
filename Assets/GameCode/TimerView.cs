using System;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private Text text;

        private StringBuilder _stringBuilder;

        private void Start()
        {
            _stringBuilder = new StringBuilder();
        }

        private void Update()
        {
            _stringBuilder.Clear();
            var timeNow = DateTime.Now;
            var seconds = timeNow.Second;
            var minutes = timeNow.Minute;
            var hours = timeNow.Hour;
            var timeString = _stringBuilder.Append(hours).Append(":")
                .Append(minutes).Append(":")
                .Append(seconds).ToString();
            text.text = timeString;
        }
    }
}