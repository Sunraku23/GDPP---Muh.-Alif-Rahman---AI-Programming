using System.Collections;
using UnityEngine;
using System;

public class Player: MonoBehaviour
{
    public Action OnpowerUpStart;
    public Action OnpowerUpStop;

    [SerializeField]
    private float _speed;

    private Rigidbody rb;
        
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private float _powerupDuration;

    private Coroutine _powerUpCourotine;

    public void PickPowerUp()
    {
        if(_powerUpCourotine != null)
        {
            StopCoroutine(_powerUpCourotine);
        }

        _powerUpCourotine = StartCoroutine(StartPowerUp());
    }

    private IEnumerator StartPowerUp()
    {
        if (OnpowerUpStart != null)
        {
            OnpowerUpStart();
        }
        yield return new WaitForSeconds(_powerupDuration);
        Debug.Log("Weakk");
        if (OnpowerUpStop != null) 
        {
            OnpowerUpStop();
        }
    }

    //Method Awake ini akan jalan ketika game start   
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        HideandLockCursor();
    }


    private void HideandLockCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        // horizontal cam direction
        Vector3 hrDirection = horizontal * cam.transform.right;
        // Vertical cam direction
        Vector3 vrDirection = Vertical * cam.transform.forward;
        hrDirection.y = 0;
        vrDirection.y = 0;

        Vector3 movementDirection = hrDirection + vrDirection;

        rb.linearVelocity = movementDirection * _speed * Time.fixedDeltaTime; 


    }
}
