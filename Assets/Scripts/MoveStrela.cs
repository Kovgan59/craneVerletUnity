using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStrela : MonoBehaviour
{
    [SerializeField] private float max_pos;
    [SerializeField] private float min_pos;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.localPosition);
        if ((Input.GetKey(KeyCode.S)) && (transform.localPosition.x >= min_pos))
        {
            // Debug.Log('S');
            transform.localPosition += new Vector3(-0.005f, 0, 0);
        }
        if ((Input.GetKey(KeyCode.W))&& (transform.localPosition.x <= max_pos))
        {
            transform.localPosition += new Vector3(0.005f, 0, 0);
            // Debug.Log('W');
        }
    }
}
