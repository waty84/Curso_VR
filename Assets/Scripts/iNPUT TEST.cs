using UnityEngine;
using UnityEngine.InputSystem;

public class iNPUTTEST : MonoBehaviour
{
    public InputActionProperty TestValorAccion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float valorAccion = TestValorAccion.action.ReadValue<object>
            Debug.Log("valor =" + valorAccion);

        bool valorboton = TestValorboton.action.IsPressed();
        Debug.Log("Valor =" + valorboton);
    }
}
