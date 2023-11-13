using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;


public class Run : MonoBehaviour
{
    public InputActionReference runReference = null;
    public DynamicMoveProvider dynamicMoveProvider;

    public float runningSpeedMultiplier = 2f;
    public float runningSpeedDebuff = 0.5f;

    private float originalSpeed; 

    private void Awake()
    {
        if (dynamicMoveProvider != null)
        {
            originalSpeed = dynamicMoveProvider.moveSpeed;
        }

        runReference.action.started += StartRun;
    }

    void Update()
    {
        
        
        Invoke(nameof(SpeedDebuff), 3.0f);
    }

    private void OnDestroy()
    {
        runReference.action.started -= StartRun;
    }

    private void StartRun(InputAction.CallbackContext context)
    {
        
        if (dynamicMoveProvider != null)
        {
            dynamicMoveProvider.moveSpeed *= dynamicMoveProvider.moveSpeed;
        }
    }
    private void SpeedDebuff()
    {
        Debug.Log("Velocidad actual: " + dynamicMoveProvider.moveSpeed);
        if(dynamicMoveProvider.moveSpeed>1 )
        {
            dynamicMoveProvider.moveSpeed *= -runningSpeedDebuff;
        }
    }
}
