using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
   private Vector3 _spawnPosition;

   public Vector3 GetSpawnPosition()
   {
       return transform.GetChild(0).position;//_spawnPosition;
   }
}
