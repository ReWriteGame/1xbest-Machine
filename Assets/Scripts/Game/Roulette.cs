using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Roulette : MonoBehaviour
{
    [SerializeField] private Vector2 angleForce;
    [SerializeField] private Vector3 rangeAngleForceMin;
    [SerializeField] private Vector3 rangeAngleForceMax;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void RandomTwist()
    {
        Vector3 direction = new Vector3(
            Random.Range(rangeAngleForceMin.x, rangeAngleForceMax.x),
            Random.Range(rangeAngleForceMin.y, rangeAngleForceMax.y),
            Random.Range(rangeAngleForceMin.z, rangeAngleForceMax.z));
        Twist(direction);
    }

    public void Twist(Vector3 direction)
    {
        rb.AddTorque(direction.normalized * Random.Range(angleForce.x, angleForce.y), ForceMode.Impulse);
    }

    public void StopTorque()
    {
        rb.angularVelocity = Vector3.zero;
    }

    public void FixTorgue()
    {
        float currentPositionTorgue = rb.rotation.eulerAngles.y % 30;

        if (Mathf.Abs(currentPositionTorgue) < 15) transform.Rotate(0, -currentPositionTorgue, 0);
        else transform.Rotate(0, 30 - currentPositionTorgue, 0);
    }
}