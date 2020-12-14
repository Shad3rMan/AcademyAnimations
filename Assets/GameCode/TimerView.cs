using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private Text text = default;

        private IEnumerator Start()
        {
            text.text = DateTime.Now.ToString("h:mm:ss");;
            yield return new WaitForSeconds(1f);
            StartCoroutine(Start());
        }
    }
}