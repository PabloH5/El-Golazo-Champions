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
    public float runningSpeedDebuff = 0.1f;
    public float cooldownDebuff = 0.0f;
    private float originalSpeed;

    private void Awake()
    {
        if (dynamicMoveProvider != null)
        {
            originalSpeed = dynamicMoveProvider.moveSpeed;
        }
        runReference.action.started += StartRun;
    }
    void Start()
    {
        InvokeRepeating(nameof(SpeedDebuff), cooldownDebuff, cooldownDebuff);
    }
    void Update()
    {
        Debug.Log("Velocidad actual: " + dynamicMoveProvider.moveSpeed);
    }

    private void StartRun(InputAction.CallbackContext context)
    {
        if (dynamicMoveProvider != null)
        {
            if (dynamicMoveProvider.moveSpeed <= 10)
            {
                dynamicMoveProvider.moveSpeed += (dynamicMoveProvider.moveSpeed * runningSpeedMultiplier);
                Debug.Log("Velocidad actual SUAMADA : " + dynamicMoveProvider.moveSpeed);
            }
            else { Debug.Log("Mas rapido quel rasho mi papacho"); }


        }
    }
    private void SpeedDebuff()
    {
        if (dynamicMoveProvider.moveSpeed > originalSpeed)
        {
            if (dynamicMoveProvider.moveSpeed - runningSpeedDebuff < originalSpeed)
            {
                dynamicMoveProvider.moveSpeed = originalSpeed;
                Debug.Log("Velocidad original: " + dynamicMoveProvider.moveSpeed);
            }
            else
            {
                dynamicMoveProvider.moveSpeed -= (dynamicMoveProvider.moveSpeed * runningSpeedDebuff);
                Debug.Log("Velocidad actual reducida: " + dynamicMoveProvider.moveSpeed);
            }
        }
    }
}
