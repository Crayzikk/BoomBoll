using UnityEngine;

public class Explosive : MonoBehaviour
{
    [SerializeField] private float explosionForce;
    [SerializeField] private float explosionRadius;
    [SerializeField] private float upwardsModifier;

    private Rigidbody rigidbodyExplosive;

    void Start()
    {
        rigidbodyExplosive = GetComponent<Rigidbody>();
    }

    void Boom()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier, ForceMode.Impulse);
            }
        }

        Destroy(gameObject);
    }
}
