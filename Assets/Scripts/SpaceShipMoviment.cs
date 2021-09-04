using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoviment : MonoBehaviour
{
    [SerializeField] GameObject ship;
    [SerializeField] Rigidbody currentRigidbody;
    [SerializeField] Vector3 desiredVelocity;
    [SerializeField] Vector3 currentVelocity;
    public Vector3 velocity => currentVelocity;
    Vector3 desiredDirection;

    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float fuel;
    [SerializeField] float fuelConsumption;
    float maxFuel;

    [SerializeField] float gizmosSize;
    [SerializeField] float planePosForMouse;

    [SerializeField] float angularSpeed;

    Quaternion initialRotation;
    Vector3 initialPosition;

    private void Start()
    {
        maxFuel = fuel;
        StageManager.stageManager.PlayerWon += Stop;
        initialRotation = transform.rotation;
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (!StageManager.stageManager.stageIsActiveAndPlayable) return;

        HandleMoviment();
    }

    public void Stop()
    {
        currentRigidbody.useGravity = false;
        currentRigidbody.velocity = Vector3.up;
        fuel = 0f;
    }

    public void HandleMoviment()
    {
        if (Input.GetMouseButton(0))
        {
            if (!HasFuel()) return;

            Accelerate();
        }
    }

    public void Accelerate()
    {
        Vector3 currentDirection = GetDirection();

        desiredVelocity = currentDirection * speed * Time.deltaTime;
        desiredVelocity.x = 0;
        currentVelocity = Vector3.ClampMagnitude(desiredVelocity, maxSpeed);
        fuel -= fuelConsumption * Time.deltaTime;

        if (currentRigidbody.velocity.magnitude + currentVelocity.magnitude > maxSpeed) return;

        currentRigidbody.AddForce(currentVelocity, ForceMode.VelocityChange);
        currentRigidbody.AddRelativeTorque(Vector3.Dot(transform.forward, desiredVelocity) * angularSpeed, 0, 0);

    }

   Vector3 GetDirection()
   {
        Vector3 mouse = Input.mousePosition;
        mouse.z = planePosForMouse;

        Vector3 inputPos = Camera.main.ScreenToWorldPoint(mouse);
        desiredDirection = transform.position - inputPos;
        desiredDirection.x = 0;
        return desiredDirection.normalized + transform.up;
   }

    public bool HasFuel()
    {
        return fuel > 0;
    }

    public void ResetFuel()
    {
        fuel = maxFuel;
    }

    public void AddFuel(float newFuel)
    {
        Debug.Log(newFuel + " Fuel added. Max is: " + maxFuel);
        fuel = Mathf.Clamp(newFuel, 0, maxFuel);
    }

    public bool IsFallingWithoutControl()
    {
        return !HasFuel() && currentRigidbody.velocity.magnitude < 0;
    }

    private void OnDrawGizmos()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = planePosForMouse;

        Vector3 inputPos = Camera.main.ScreenToWorldPoint(mouse);

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(inputPos, 1f);

        if((transform.position + desiredVelocity).normalized * gizmosSize != Vector3.zero)
        Gizmos.DrawRay(transform.position, desiredVelocity * gizmosSize);
    }

    public void ResetSpaceShip()
    {
        currentRigidbody.isKinematic = true;
        currentRigidbody.velocity = Vector3.zero;
        transform.rotation = initialRotation;
        transform.position = initialPosition;
        ResetFuel();
        currentRigidbody.isKinematic = false;
    }

    public void ImproveSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void ImproveMaxSpeed(float newMaxSpeed)
    {
        maxSpeed = newMaxSpeed;
    }

    public void ImproveMaxFuel(float newMaxFuel)
    {
        maxFuel = newMaxFuel;
    }

    public void ResetVelocity()
    {
        currentVelocity = Vector3.zero;
        desiredVelocity = Vector3.zero;
        currentRigidbody.velocity = Vector3.zero;
        
    }

    public float GetSpeed()
    {
        return speed;
    }

    public float GetMaxFuel()
    {
        return maxFuel;
    }
}
