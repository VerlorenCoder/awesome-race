using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour {
    private CarController car;
    Mesh deformingMesh;
    Vector3[] originalVertices;
    float strength = 0.01f;
    private GameObject smoke, smoke2, smoke3;
    private int crashes = 0;
    private bool isOnFire = false;
    public float deformationSpeed = 25.0f;

    public void Crash() {
        float speed = (int)Mathf.Floor(car.CurrentSpeed * 1.3f);
        if (speed >= deformationSpeed)
        {
            AddDeformingForce();
        }
    }

    void Start() {
        car = GameObject.Find("Car").GetComponent<CarController>();
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
        smoke = GameObject.Find("WhiteSmoke");
        smoke.GetComponent<ParticleSystem>().enableEmission = false;
        smoke2 = GameObject.Find("WhiteSmoke2");
        smoke2.GetComponent<ParticleSystem>().enableEmission = false;
        smoke3 = GameObject.Find("WhiteSmoke3");
        smoke3.GetComponent<ParticleSystem>().enableEmission = false;
    }

    public void AddDeformingForce() {
        for (int i = 0; i < originalVertices.Length; i++) {
            AddForceToVertex(i);
        }

        crashes++;

        if(!isOnFire && crashes > 8) {
            smoke.GetComponent<ParticleSystem>().enableEmission = true;
            isOnFire = true;
        }

        if (isOnFire && crashes > 12)
        {
            smoke2.GetComponent<ParticleSystem>().enableEmission = true;
        }

        if (isOnFire && crashes > 16)
        {
            smoke3.GetComponent<ParticleSystem>().enableEmission = true;
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