using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frameAtual = frameAtual + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"));
        {

        }
          transform.Translate(0.05f, 0, 0);


       if (Input.GetKey("a")) {
            this.transform.Translate(-0.05, 0, 0);

            if (Input.GetKey("space") && pulando == false && Physics.CheckSphere(transform.position, 2f))
                pulando = true;
            inicioPulo = frameAtual;

            if (pulando && frameAtual - inicioPulo > 100)
                pulando = false;
}
        if (pulando)
        {
            this.transform.Translate(0, 0.05, 0);

        }