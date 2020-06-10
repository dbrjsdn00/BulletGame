using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("앞으로");
            transform.position = new vector3(
                Transform.Position.x,
                Transform.Position.y,
                Transform.Position.z + 3f * Time.DeltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("뒤로");
            transform.position = new vector3(
                Transform.Position.x,
                Transform.Position.y,
                Transform.Position.z - 3f * Time.DeltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로");
            transform.position = new vector3(
                Transform.Position.x - 3f * Time.DeltaTime,
                Transform.Position.y,
                Transform.Position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로");
            transform.position = new vector3(
                Transform.Position.x + 3f * Time.DeltaTime,
                Transform.Position.y,
                Transform.Position.z);
        }
    }
}