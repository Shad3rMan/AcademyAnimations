using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace GameCode
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;

        WaitForSeconds _waitOneSecond = new WaitForSeconds(1f);
        private IEnumerator Start()
        {
            while (true)
            {
                _text.text = DateTime.Now.ToString("h:mm:ss tt");;
                yield return _waitOneSecond;
            }
           
        }
    }
}