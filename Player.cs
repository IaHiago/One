using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Velmovimento = 20.0f;
    public float rr;
    private Vector3 pos;
    private bool nochão;
    public Rigidbody Player1;
    public Animator anima;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");

        pos = transform.position; // Recebendo os trés eixos
        pos.x += Velmovimento * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += Velmovimento * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;

        if(xAxis != 0 || zAxis != 0)
        {
            anima.SetBool("Running", true);
        }
        else
        {
            anima.SetBool("Running", false);
        }

        if (xAxis == 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * 5);
        }

        if (xAxis == -1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * 5);
        }

        if (zAxis == 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 5);
        }

        if (zAxis == -1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -180, 0), Time.deltaTime * 5);
        }
    }
}