using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_MANAGER : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI txt_ResultadoSuma;
    public TextMeshProUGUI txt_ResultadoResta;
    public TextMeshProUGUI txt_ResultadoMultiplicacion;
    public TextMeshProUGUI txt_ResultadoDivision;
    
    // Start is called before the first frame update
    void Start()
    {
        txt_ResultadoSuma.gameObject.SetActive (false);
        txt_ResultadoResta.gameObject.SetActive (false);
        txt_ResultadoDivision.gameObject.SetActive (false);
        txt_ResultadoMultiplicacion.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowOperationResults (){
        txt_ResultadoSuma.gameObject.SetActive (true);
        txt_ResultadoResta.gameObject.SetActive (true);
        txt_ResultadoDivision.gameObject.SetActive (true);
        txt_ResultadoMultiplicacion.gameObject.SetActive (true);
    }
}
