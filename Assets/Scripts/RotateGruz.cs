using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class RotateGruz : MonoBehaviour
 {
 
     // Update is called once per frame
     void Update()
     {
         if (Input.GetKey(KeyCode.Q))
         {
             transform.localRotation = Quaternion.Euler(0, -0.05f, 0) * transform.localRotation;
             // Debug.Log('Q');
         }
         if (Input.GetKey(KeyCode.E))
         {
             transform.localRotation = Quaternion.Euler(0, 0.05f, 0) * transform.localRotation;
             // Debug.Log('E');
         }
     }
 }