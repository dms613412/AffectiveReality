using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    public float moveSpeed = 0.00002f;
    public float moveRot = 0.5f;
    private Transform tr = null;
    private Transform tr_c = null;

    public float pushPower = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        float rot = Input.GetAxis("Mouse X");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * h;

        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "can")
        {
           Rigidbody body = hit.collider.attachedRigidbody;

            if (body == null || body.isKinematic)
                return;

            if (hit.moveDirection.y < -0.3f)
                return;

            //pushDir = Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

            Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            //(Vector3.forward * hit.moveDirection.x) + (Vector3.right) * hit.moveDirection.z;
            
            body.velocity = pushDir * pushPower;
        }

    }
}
