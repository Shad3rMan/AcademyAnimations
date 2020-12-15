using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        private StringBuilder _stringBuilder = new StringBuilder();

        private void Update()
        {
            UpdateTimeText();
        }

        private void UpdateTimeText()
        {
            _stringBuilder.Clear();
            _stringBuilder.Append(DateTime.Now.Hour);
            _stringBuilder.Append(":");
            _stringBuilder.Append(DateTime.Now.Minute);
            _stringBuilder.Append(":");
            _stringBuilder.Append(DateTime.Now.Second);

            _text.text = _stringBuilder.ToString();
        }
    }
}