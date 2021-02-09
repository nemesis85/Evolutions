using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    public int visibilityRange; //переменная дальность видимости по умолчанию
    Rigidbody2D rigidbody2d; //
    Vector2 lookDirection = new Vector2(0,-1);
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(pos.position, lookDirection, 5f, LayerMask.GetMask("food"));
        Debug.DrawRay(pos.position, lookDirection*5f, Color.green);
        if (hit.collider != null)
        {
                Debug.Log("12345");
        }
    }
}
