using System;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField]
    public PickableType PickableType;
    public Action<Pickable> OnPicked;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TWinggg" + PickableType);
            OnPicked(this);
            Destroy(gameObject);
        }
        
    }

        

}
