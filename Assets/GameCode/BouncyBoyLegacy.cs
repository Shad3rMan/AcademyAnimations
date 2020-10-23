using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class BouncyBoyLegacy : MonoBehaviour
{
  [SerializeField] private Animation boyAnimation;
  [SerializeField] private LayerMask colorMask;

  public void ChangeColorAround()
  {
     var objects = Physics2D.OverlapCircleAll(transform.position, 2f, colorMask);
     foreach (var obj in objects)
     {
        List<Color> colors = new List<Color>() {Color.black,Color.gray,Color.yellow};
        var colorIndex = Random.Range(0, colors.Count);
        obj.GetComponent<SpriteRenderer>().color = colors[colorIndex];
     }
  }
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         boyAnimation.Play();
      }
   }
   
}
