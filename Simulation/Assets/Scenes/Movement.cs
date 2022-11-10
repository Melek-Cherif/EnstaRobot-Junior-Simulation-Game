using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = .1f ;
    // Update is called once per frame
    void Update()
    {
        float Xdirection = Input.GetAxis("Horizental");
        float Zdirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(Xdirection, 0.0f, Zdirection);

        transform.position += moveDirection * speed * Time.deltaTime ;
    }
}
