using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaScript : MonoBehaviour
{
    
    public int pontuacao;
    public Text pontuacaoTexto;

    [ContextMenu("Aumenta a Pontuação")]
    public void aumentaPontuacao(int ponto){
        pontuacao = pontuacao + ponto;
        pontuacaoTexto.text = pontuacao.ToString();
    }

}
