using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaScript : MonoBehaviour
{
    
    public int pontuacao;
    public Text pontuacaoTexto;
    public GameObject telaDeGameOver;
    public AudioSource somPonto;

    public void iniciarGame(){
        SceneManager.LoadScene("SampleScene");
    }

    [ContextMenu("Aumenta a Pontuação")]
    public void aumentaPontuacao(int ponto){
        pontuacao = pontuacao + ponto;
        pontuacaoTexto.text = pontuacao.ToString();
        somPonto.Play();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        telaDeGameOver.SetActive(true);
    }

}
