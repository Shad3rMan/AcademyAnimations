using System;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _text;
        private StringBuilder _stringBuilder;
        
        private void Start() {
            _stringBuilder = new StringBuilder();
        }
        
        private void Update() {
            _stringBuilder.Clear();
            var seconds = DateTime.Now.Second;
            var minutes = DateTime.Now.Minute;
            var hours = DateTime.Now.Hour;
            var timeString = _stringBuilder.Append(hours)
                .Append(":")
                .Append(minutes)
                .Append(":")
                .Append(seconds)
                .ToString();
            _text.text = timeString;
        }
    }
}