using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WalkingEnemy : MonoBehaviour
{
   public float speed;
   private float waitTime;
   public float startWaitTime;
   public Transform[] moveSpots;
   private int randomSpot;


   private void Start()
   {
      waitTime = startWaitTime;
      randomSpot = Random.Range(0, moveSpots.Length);
   }

   private void Update()
   {
      transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
      if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
      {
         if (waitTime <= 0)
         {
            randomSpot = Random.Range(0, moveSpots.Length);
            waitTime = startWaitTime;
         }
         else
         {
            waitTime -= Time.deltaTime;
         }
      }
   }
}
