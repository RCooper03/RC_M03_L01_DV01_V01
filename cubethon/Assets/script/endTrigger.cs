using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.completeLevel();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
