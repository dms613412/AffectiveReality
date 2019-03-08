using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float moveRot = 0.5f;
    private Transform tr = null;
    private Transform tr_c = null;


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
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Capsule2")
        {
            tr_c = collision.gameObject.GetComponent<Transform>();

            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            float rot = Input.GetAxis("Mouse X");

            Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * h;
            tr_c.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
            tr_c.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);
        }

    }

}
