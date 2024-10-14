using UnityEngine;

// A very simplistic car driving on the x-z plane.

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        anim.SetFloat("MovX", translation);
        anim.SetFloat("MovY", rotation);
    }
}