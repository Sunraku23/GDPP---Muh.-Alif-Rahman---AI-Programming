using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PickableManager : MonoBehaviour
{

    [SerializeField]
    private Player _player;

    private List<Pickable> _pickablelist = new  List<Pickable>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitPickableList();         
    }

    private void InitPickableList()
    {
        Pickable[] pickableObjects = GameObject.FindObjectsOfType<Pickable>();
        for(int i = 0; i < pickableObjects.Length; i++)
        {
            _pickablelist.Add(pickableObjects[i]);
            pickableObjects[i].OnPicked += OnPickablePicked; 
        }
        
    }

    private void OnPickablePicked(Pickable pickable)
    {
        _pickablelist.Remove(pickable);
        if(pickable.PickableType == PickableType.powerup)
        {
            _player.PickPowerUp();
        }
        if (_pickablelist.Count <= 0)
        {
            Debug.Log("Win");
        }
    }

}
