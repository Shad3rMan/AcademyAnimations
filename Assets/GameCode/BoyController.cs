using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BoyController : MonoBehaviour
{
     private void Effect()
        {
            var spiteRender = GetComponent<SpriteRenderer>();
            var sequence = DOTween.Sequence();
            
            sequence.Append(spiteRender.DOColor(Color.green, 0.1f));
            sequence.Append(transform.DOScale(Vector3.one * 2, 0.3f));
            sequence.Append(transform.DOScale(Vector3.one, 0.3f));
            sequence.OnComplete(() => spiteRender.DOColor(Color.white, 0.1f));
        }
}
