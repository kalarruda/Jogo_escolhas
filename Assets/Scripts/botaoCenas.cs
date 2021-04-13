using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botaoCenas : MonoBehaviour
{
    private bool comida;
    private bool dinheiro;
    private bool agua;
    private bool informacao;

    public int escolhas = 0;// dinheiro =1 , agua =2 ,informacao= 3, comida = 4.


    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CenaEntrada1()
    {
        SceneManager.LoadScene("CenaEntrada1");        
    }

    public void CenaEntrada2()
    {
        SceneManager.LoadScene("CenaEntrada2");
    }

    public void CenaEntrada3()
    {
        SceneManager.LoadScene("CenaEntrada3");
    }

    public void MudarCena1()
    {
        SceneManager.LoadScene("Cena1");
    }

    public void MudarCena2()
    {
        SceneManager.LoadScene("Cena2");
    }

    public void MudarCena3()
    {
        SceneManager.LoadScene("Cena3");
    }

    public void MudarCena4()
    {
        SceneManager.LoadScene("Cena4");
    }

    public void MudarCena5()//informacao
    {
        SceneManager.LoadScene("Cena5");
        escolhas = 3;
        PrimeiraCondicao();
    }

    public void MudarCena6()//dinheiro
    {
        SceneManager.LoadScene("Cena6");
        escolhas = 1;
        PrimeiraCondicao();
    }

    public void MudarCena7()//agua
    {
        SceneManager.LoadScene("Cena7");
        escolhas = 2;
        PrimeiraCondicao();

    }

    public void MudarCena8()
    {
        SceneManager.LoadScene("Cena8");
    }

    public void MudarCena9()//agua
    {
        SceneManager.LoadScene("Cena9");
    }

    public void MudarCena10()
    {
        SceneManager.LoadScene("Cena10");
    }

    public void MudarCena11agua()//agua
    {
        SceneManager.LoadScene("Cena11agua");
    }

    public void MudarCena12agua()//agua
    {
        SceneManager.LoadScene("Cena12agua");
    }

    public void MudarCena11dinheiro()//dinheiro
    {
        SceneManager.LoadScene("Cena11dinheiro");
    }

    public void MudarCena12dinheiro()//dinheiro
    {
        SceneManager.LoadScene("Cena12dinheiro");
    }

    public void MudarCena11informacao()//informacao
    {
        SceneManager.LoadScene("Cena11informacao");
    }

    public void MudarCena12informacao()//informacao
    {
        SceneManager.LoadScene("Cena12informacao");
    }

    public void MudarCena13()//agua
    {
        SceneManager.LoadScene("Cena13");
    }

    public void MudarCena14()//informacao
    {
        SceneManager.LoadScene("Cena14");
    }

    public void MudarCena15()//dinheiro
    {
        SceneManager.LoadScene("Cena15");
    }

    public void MudarCena16agua()//agua
    {
        SceneManager.LoadScene("Cena16agua");
    }

    public void MudarCena16informacao()//informacao
    {
        SceneManager.LoadScene("Cena16informacao");
    }

    public void MudarCena16dinheiro()//dinheiro
    {
        SceneManager.LoadScene("Cena16dinheiro");
    }

    public void MudarCena17()//água
    {
        SceneManager.LoadScene("Cena17");
    }

    public void MudarCena18()//água
    {
        SceneManager.LoadScene("Cena18");
    }

    public void MudarCena19()//informacao
    {
        SceneManager.LoadScene("Cena19");
    }

    public void MudarCena20()//informacao
    {
        SceneManager.LoadScene("Cena20");
    }

    public void MudarCena21()//dinheiro
    {
        SceneManager.LoadScene("Cena21");
    }

    public void MudarCena22()//dinheiro
    {
        SceneManager.LoadScene("Cena22");
    }

    public void MudarCena23()
    {
        SceneManager.LoadScene("Cena23");
    }

    public void MudarCena24()
    {
        SceneManager.LoadScene("Cena24");
    }

    public void MudarCena25()
    {
        SceneManager.LoadScene("Cena25");
    }

    public void MudarCena26()
    {
        SceneManager.LoadScene("Cena26");
    }

    public void MudarCena27()
    {
        SceneManager.LoadScene("Cena27");
    }

    public void MudarCena28()
    {
        SceneManager.LoadScene("Cena28");
    }

    public void MudarCena29agua()//água
    {
        SceneManager.LoadScene("Cena29agua");
    }

    public void MudarCena29informacao()//informacao
    {
        SceneManager.LoadScene("Cena29informacao");
    }

    public void MudarCena29dinheiro()//dinheiro
    {
        SceneManager.LoadScene("Cena29dinheiro");
    }

    public void MudarCena30agua()//água
    {
        SceneManager.LoadScene("Cena30agua");
    }

    public void MudarCena30informacao()//informacao
    {
        SceneManager.LoadScene("Cena30informacao");
    }

    public void MudarCena30dinheiro()//dinheiro
    {
        SceneManager.LoadScene("Cena30dinheiro");
    }

    public void MudarCena31()//água
    {
        SceneManager.LoadScene("Cena31");
    }

    public void MudarCena32()//agua
    {
        SceneManager.LoadScene("Cena32");
    }

    public void MudarCena33()//água
    {
        SceneManager.LoadScene("Cena33");
    }

    public void MudarCena34()//água
    {
        SceneManager.LoadScene("Cena34");
    }

    /*public void MudarCena35() // dinheiro
    {
        SceneManager.LoadScene("Cena35");
    }*/

    public void MudarCena36()//dinheiro
    {
        SceneManager.LoadScene("Cena36");
    }

    public void MudarCena37()//dinheiro
    {
        SceneManager.LoadScene("Cena37");
    }

    public void MudarCena38()//dinheiro
    {
        SceneManager.LoadScene("Cena38");
    }

    public void MudarCena39()//informacao
    {
        SceneManager.LoadScene("Cena39");
    }

    public void MudarCena40()//informacao
    {
        SceneManager.LoadScene("Cena40");
    }

    public void MudarCena41()//informacao com comida
    {
        SceneManager.LoadScene("Cena41");//informacao com comida hospital
    }

    public void MudarCena42()//informacao sem comida 
    {
        SceneManager.LoadScene("Cena42");
    }

    public void MudarCena43()//informacao com comida
    {
        SceneManager.LoadScene("Cena43");
    }

    public void MudarCena44()//informacao com comida 
    {
        SceneManager.LoadScene("Cena44");
    }

    public void MudarCena45informacaoComComida()//informacao com comida
    {
        SceneManager.LoadScene("Cena45informacaoComComida");
    }

    public void MudarCena45informacaoSemComida()//informacao sem comida
    {
        SceneManager.LoadScene("MudarCena45informacaoSemComida");
    }

    public void MudarCena47()//água
    {
        SceneManager.LoadScene("Cena47");
    }

    public void MudarCena48()//dinheiro
    {
        SceneManager.LoadScene("Cena48");
    }

    public void MudarCena49informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("MudarCena49informacaoComComida");
    }

    public void MudarCena49informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("MudarCena49informacaoSemComida");
    }

    public void MudarCena50informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena50informacaoSemComida");
    }

    public void MudarCena50informacaoComComida()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena50informacaoComComida");
    }

    public void MudarCena53()//água hospital
    {
        SceneManager.LoadScene("Cena53");
    }

    public void MudarCena54()//agua quartel
    {
        SceneManager.LoadScene("Cena54");
    }

    public void MudarCena55()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena55");
    }

    public void MudarCena56()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena56");
    }

    public void MudarCena57informacaoHospitalComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("MudarCena57informacaoHospitalComComida");
    }

    public void MudarCena57informacaoHospitalSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("MudarCena57informacaoHospitalSemComida");
    }

    public void MudarCena57informacaoQuartelComComida()//informacao com comida quartel
    {
        SceneManager.LoadScene("MudarCena57informacaoQuartelComComida");
    }

    public void MudarCena57informacaoQuartelSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("MudarCena57informacaoQuartelSemComida");
    }

    public void MudarCena58informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena58informacaoComComida");
    }

    public void MudarCena58informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena58informacaoSemComida");
    }

    public void MudarCena59informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena59informacaoComComida");
    }

    public void MudarCena59informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena59informacaoSemComida");
    }

    public void MudarCena60informacaoComComida()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena60informacaoComComida");
    }

    public void MudarCena60informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena60informacaoSemComida");
    }

    public void MudarCena62informacaoComComida()
    {
        SceneManager.LoadScene("Cena62informacaoComComida");
    }

    public void MudarCena62informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena62informacaoSemComida");
    }

    public void MudarCena63informacao()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena63informacao");
    }

    public void MudarCena64informacaoComComida()
    {
        SceneManager.LoadScene("Cena64informacaoComComida");
    }

    public void MudarCena64informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena64informacaoSemComida");
    }

    public void MudarCena65()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena65");
    }

    public void MudarCena66()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena66");
    }

    public void MudarCena66quartel()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena66quartel");
    }

    public void MudarCena67()//dinheiro
    {
        SceneManager.LoadScene("Cena67");
    }

    public void MudarCena67quartel()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena67quartel");
    }

    public void MudarCena68()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena68");
    }

    public void MudarCena69()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena69");
    }

    public void MudarCena70aguaHospital()//água hospital
    {
        SceneManager.LoadScene("Cena70aguaHospital");
    }

    public void MudarCena70aguaQuartel()//agua quartel
    {
        SceneManager.LoadScene("Cena70aguaQuartel");
    }

    public void MudarCena71agua()//água
    {
        SceneManager.LoadScene("Cena71agua");
    }

    public void MudarCena72()//água hospital
    {
        SceneManager.LoadScene("Cena72");
    }

    public void MudarCena73()//agua quartel
    {
        SceneManager.LoadScene("Cena73");
    }

    public void MudarCena74()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena74");
    }

    public void MudarCena75()
    {
        SceneManager.LoadScene("Cena75");
    }

    public void MudarCena76()//água hospital
    {
        SceneManager.LoadScene("Cena76");
    }

    public void MudarCena77()//agua quartel
    {
        SceneManager.LoadScene("Cena77");
    }

    public void MudarCena78()//água hospital
    {
        SceneManager.LoadScene("Cena78");
    }

    public void MudarCena79()//agua quartel
    {
        SceneManager.LoadScene("Cena79");
    }

    public void MudarCena80()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena80");
    }


    public void MudarCena81()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena81");
    }

    public void MudarCena82()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena82");
    }

    public void MudarCena83()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena83");
    }

    public void MudarCena84()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena84");
    }

    public void MudarCena85()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena85");
    }

    public void MudarCena86agua()
    {
        SceneManager.LoadScene("Cena86agua");//água hospital
    }

    public void MudarCena86dinheiro()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena86dinheiro");
    }

    public void MudarCena86informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena86informacaoComComida");
    }

    public void MudarCena86informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena86informacaoSemComida");
    }

    public void MudarCena87()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena87");
    }

    public void MudarCena88()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena88");
    }

    public void MudarCena89()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena89");
    }

    public void MudarCena90()//água hospital
    {
        SceneManager.LoadScene("Cena90");
    }

    public void MudarCena91agua()//agua quartel
    {
        SceneManager.LoadScene("Cena91agua");
    }

    public void MudarCena91dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena91dinheiro");
    }

    public void MudarCena91informacaoComComida()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena91informacaoComComida");
    }

    public void MudarCena91informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena91informacaoSemComida");
    }

    public void MudarCena92agua()//agua quartel
    {
        SceneManager.LoadScene("Cena92agua");
    }

    public void MudarCena92dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena92dinheiro");
    }

    public void MudarCena92informacaoComComida()
    {
        SceneManager.LoadScene("Cena92informacaoComComida");
    }

    public void MudarCena92informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena92informacaoSemComida");
    }

    public void MudarCena93agua()//agua quartel
    {
        SceneManager.LoadScene("Cena93agua");
    }

    public void MudarCena93dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena93dinheiro");
    }

    public void MudarCena93informacaoComComida()
    {
        SceneManager.LoadScene("Cena93informacaoComComida");
    }

    public void MudarCena93informacaoSemComida()
    {
        SceneManager.LoadScene("Cena93informacaoSemComida");
    }

    public void MudarCena94agua()//agua quartel
    {
        SceneManager.LoadScene("Cena94agua");
    }

    public void MudarCena94dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena94dinheiro");
    }

    public void MudarCena94informacaoComComida()
    {
        SceneManager.LoadScene("Cena94informacaoComComida");
    }

    public void MudarCena94informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena94informacaoSemComida");
    }

    public void MudarCena95dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena95dinheiro");
    }

    public void MudarCena95quartel()//água quartel
    {
        SceneManager.LoadScene("Cena95quartel");
    }

    public void MudarCena95informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena95informacaoSemComida");
    }

    public void MudarCena95informacaoComComida()//informacao com comida quartel
    {
        SceneManager.LoadScene("Cena95informacaoComComida");
    }

    public void MudarCena95()//água hospital
    {
        SceneManager.LoadScene("Cena95");
    }

    public void MudarCena96informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena96informacaoComComida");
    }

    public void MudarCena96informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena96informacaoSemComida");
    }

    public void MudarCena99()//agua quartel
    {
        SceneManager.LoadScene("Cena99");
    }

    public void MudarCena100informacaoComComida()
    {
        SceneManager.LoadScene("Cena100informacaoComComida");
    }

    public void MudarCena100informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena100informacaoSemComida");
    }

    public void MudarCena102()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena102");
    }

    public void MudarCena103agua()//água hospital
    {
        SceneManager.LoadScene("Cena103agua");
    }

    public void MudarCena103informacaoComComida()
    {
        SceneManager.LoadScene("Cena103informacaoComComida");
    }

    /*public void MudarCena103informacaoSemComida()
    {
        SceneManager.LoadScene("Cena103informacaoSemComida");
    }*/

    public void MudarCena104dinheiro()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena104dinheiro");
    }

    public void MudarCena104informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena104informacaoSemComida");
    }

    public void MudarCena105()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena105");
    }

    public void MudarCena106agua()
    {
        SceneManager.LoadScene("Cena106agua");
    }

    public void MudarCena106informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena106informacaoComComida");
    }

    public void MudarCena107agua()//água hospital
    {
        SceneManager.LoadScene("Cena107agua");
    }

    public void MudarCena107informacaoComComida()
    {
        SceneManager.LoadScene("Cena107informacaoComComida");
    }    

    public void MudarCena108agua()//água hospital
    {
        SceneManager.LoadScene("Cena108agua");
    }

    public void MudarCena109dinheiro()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena109dinheiro");
    }

    public void MudarCena109informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena109informacaoSemComida");
    }

    public void MudarCena111informacao()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena111informacao");
    }

    public void MudarCena112dinheiro()
    {
        SceneManager.LoadScene("Cena112dinheiro");
    }

    /*public void MudarCena112informacaoComComida()
    {
        SceneManager.LoadScene("Cena112informacaoComComida");
    }*/

    public void MudarCena112informacaoSemComida()//informacao sem comida hospital
    {
        SceneManager.LoadScene("Cena112informacaoSemComida");
    }

    public void MudarCena115informacaoComComida()//informacao com comida hospital
    {
        SceneManager.LoadScene("Cena115informacaoComComida");
    }

    public void MudarCena117()//agua quartel
    {
        SceneManager.LoadScene("Cena117");
    }

    public void MudarCena118agua()//agua quartel
    {
        SceneManager.LoadScene("Cena118agua");
    }

    public void MudarCena118dinheiro()
    {
        SceneManager.LoadScene("Cena118dinheiro");
    }

    public void MudarCena118informacaoComComida()
    {
        SceneManager.LoadScene("Cena118informacaoComComida");
    }

    public void MudarCena118informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena118informacaoSemComida");
    }

    public void MudarCena119()//agua quartel
    {
        SceneManager.LoadScene("Cena119");
    }

    public void MudarCena120()
    {
        SceneManager.LoadScene("Cena120");
    }

    public void MudarCena123dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena123dinheiro");
    }

    public void MudarCena124dinheiro()//dinheiro quartel
    {
        SceneManager.LoadScene("Cena124dinheiro");
    }

    /*public void MudarCena123informacaoComComida()
    {
        SceneManager.LoadScene("Cena123informacaoComComida");
    }*/

    public void MudarCena123informacaoSemComida()//informacao sem comida quartel
    {
        SceneManager.LoadScene("Cena123informacaoSemComida");
    }

    public void MudarCena125informacaoComComida()
    {
        SceneManager.LoadScene("Cena125informacaoComComida");
    }

    public void MudarCena126informacaoSemComida()
    {
        SceneManager.LoadScene("Cena126informacaoSemComida");
    }

    public void MudarCena127informacaoComComida()
    {
        SceneManager.LoadScene("Cena127informacaoComComida");
    }

    public void MudarCena128informacaoComComida()
    {
        SceneManager.LoadScene("Cena128informacaoComComida");
    }

    public void MudarCena129dinheiro()
    {
        SceneManager.LoadScene("Cena129dinheiro");
    }

    public void MudarCena136dinheiro()//dinheiro hospital
    {
        SceneManager.LoadScene("Cena136dinheiro");
    }

    public void MudarCena137informacaoSemComida()
    {
        SceneManager.LoadScene("Cena137informacaoSemComida");
    }



    public void PrimeiraCondicao()
    {
       /* if (escolhas == 2)
        {

            SceneManager.LoadScene("Cena13");

        }
        else if (escolhas == 3)
        {
            SceneManager.LoadScene("Cena14");

        }
        else
        {
            SceneManager.LoadScene("Cena15");

        }*/
    }
}

