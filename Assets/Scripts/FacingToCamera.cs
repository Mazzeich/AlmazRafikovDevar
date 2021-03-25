using UnityEngine;

public class FacingToCamera : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5.0f;

    private Quaternion _lookRotation;
    private Vector3    _direction;

    void Update()
    {
        _direction         = target.position - transform.position;
        _lookRotation      = Quaternion.LookRotation(_direction.normalized);
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * rotationSpeed);
    }
}
