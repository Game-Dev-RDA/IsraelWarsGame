using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour
{
    public float turretRotationSpeed = 150;

    public void Aim(Vector2 inputPointerPosition)
    {
        // Turrent Position towards mouse pointer 
        var TurretDirection = (Vector3)inputPointerPosition - transform.position;
        // Calculate the angle between turrent y axis direction to turrent x axis direction and convert it to degrees
        var desiredAngle = Mathf.Atan2(TurretDirection.y, TurretDirection.x) * Mathf.Rad2Deg;

        var rotationStep = turretRotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, desiredAngle), rotationStep);
    }
}
