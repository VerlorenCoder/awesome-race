using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformerBack : MonoBehaviour {
    private CarController car;
    Mesh deformingMesh;
    Vector3[] originalVertices;
    float strength = 0.01f;
    public float deformationSpeed = 25.0f;

    public void Crash() {
        Debug.Log("2S");
        float speed = (int)Mathf.Floor(car.CurrentSpeed * 1.3f);
        if (speed >= deformationSpeed)
        {
            AddDeformingForce();
        }
        Debug.Log("2K");
    }

    void Start() {
        car = GameObject.Find("Car").GetComponent<CarController>();
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
    }

    public void AddDeformingForce() {
        for (int i = 0; i < originalVertices.Length; i++) {
            AddForceToVertex(i);
        }
    }

    void AddForceToVertex(int i) {
        if(Random.Range(0, 30) == 0) {
            Vector3 random = new Vector3(Random.Range(0, strength), -Random.Range(0, strength), -Random.Range(0, strength));
            originalVertices[i] = originalVertices[i] + random;
        }
    }

    void Update() {
        deformingMesh.vertices = originalVertices;
        deformingMesh.RecalculateNormals();
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Bum!");
    }
}