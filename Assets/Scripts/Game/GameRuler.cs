using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Arrow arrow2;
    [SerializeField] private Arrow arrow3;
    [SerializeField] private ScoreCounter scoreCounter;




    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;


    public void GetResults()
    {
        if(arrow1.collidedObject.GetComponent<Cell>().ID == arrow2.collidedObject.GetComponent<Cell>().ID && 
           arrow2.collidedObject.GetComponent<Cell>().ID == arrow3.collidedObject.GetComponent<Cell>().ID)
            arrowCoincidedEvent?.Invoke();
        else arrowNotCoincidedEvent?.Invoke();
        
    }

}
