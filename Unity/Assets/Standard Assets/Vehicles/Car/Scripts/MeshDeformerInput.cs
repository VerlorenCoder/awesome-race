using UnityEngine;

public class MeshDeformerInput : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButton(0)) {
            HandleInput();
        }
    }

    void HandleInput() {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(inputRay, out hit)) {
            MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();

            if (deformer) {
                deformer.AddDeformingForce();
            }
        }
    }
}