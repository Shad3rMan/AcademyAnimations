using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        [SerializeField]
        private string _delimeter;
        [SerializeField]
        private float _timerUpdateInterval;

        private StringBuilder _stringBuilder = new StringBuilder();
        private YieldInstruction _waitForSeconds = null;

        private void Awake()
        {
            _waitForSeconds = new WaitForSeconds(_timerUpdateInterval);    
        }
        
        private void Update()
        {
            StartCoroutine(UpdateTimeCoroutine());
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

        private IEnumerator UpdateTimeCoroutine()
        {
            while (true)
            {
                UpdateTimeText();
                yield return _waitForSeconds;
            }
        }
    }
}