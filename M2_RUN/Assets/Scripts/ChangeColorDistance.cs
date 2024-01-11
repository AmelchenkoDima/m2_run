using UnityEngine;

public class ChangeColorByDistance : MonoBehaviour
{
    public float maxDistance = 50f; // ������������ ����������, �� ������� �������� ����� �������
    public Material startMaterial; // ��������� ��������
    public Material endMaterial; // �������� ��������

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = startMaterial; // ��������� ���������� ���������
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, new Vector3(0, 0, -10)); // ���������� ����� �������� � �����

        // ���������� ��������� ��������� � ����������� �� ����������� ����������
        float t = Mathf.Clamp01(distance / maxDistance); // ������������ ���������� �� 0 �� 1
        Material currentMaterial = t < 1f ? startMaterial : endMaterial; // ����� �������� ��������� � ����������� �� ����������
        rend.material = currentMaterial; // ��������� �������� ��������� �������
    }
}

