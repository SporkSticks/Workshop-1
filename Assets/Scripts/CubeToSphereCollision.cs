// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class CubeToSphereCollision : MonoBehaviour
{
    private BoxCollider b_collider;
    private SphereCollider s_collider;
    private MeshFilter curr_mesh;

    [SerializeField] private Mesh sphereModel;

	private void Start()
	{
        b_collider = GetComponent<BoxCollider>();
        s_collider = GetComponent<SphereCollider>();
        curr_mesh = GetComponent<MeshFilter>();
    }


	private void OnCollisionEnter()
    {
        b_collider.enabled = !b_collider.enabled;
        curr_mesh.mesh = sphereModel;
        s_collider.enabled = !s_collider.enabled;
    }
}
