using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    //Method Awake ini akan jalan ketika game start   
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontal, 0, Vertical);

        rb.linearVelocity = movementDirection * speed * Time.fixedDeltaTime; 
        Debug.Log("Horizontal" + horizontal);
        Debug.Log("Vertical" +  Vertical);
    }
}
