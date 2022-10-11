using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;

    private Vector3 vector;

    public float runSpeed;
    private float applyRunSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            applyRunSpeed = runSpeed;
        }
        else {
            applyRunSpeed = speed;
        }

        if(Input.GetAxisRaw("Horizontal")!=0 || Input.GetAxisRaw("Vertical") !=0) {
            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if(vector.x  != 0) {
                transform.Translate(vector.x * applyRunSpeed, 0, 0);
            }
            else if(vector.y != 0) {
                transform.Translate(0, vector.y * applyRunSpeed, 0);
            }
        }
    }
}
