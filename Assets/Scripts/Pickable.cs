using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField]
    public PickableType PickableType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TWinggg" + PickableType);
            Destroy(gameObject);
        }
        
    }

        

}
