import React from 'react';
import { Link } from 'react-router-dom';

class FirstScene extends React.Component {
  render() {
    return(
      <div className="text-area">
        <p>Mais um dia no “excitante” no setor bancário. Você é caixa de banco a mais de 4 anos e sempre imagina que a monotonia do trabalho não compensa o ótimo salário que recebe apesar da função ser tão simples. Já são 5 da tarde e já passou da hora de ir embora, você pega sua mochila, se despede do pessoal que ainda ficou e parte em direção ao ponto de ônibus.</p>

        <p>No ponto de ônibus nada anormal, algumas pessoas com fone de ouvido outras simplesmente encarando o prédio do outro lado da rua enquanto aguardam a chegada do transporte. Você está checando o celular e se depara com uma notícia em destaque “assassinatos brutais”. Provavelmente mais uma notícia exagerada para chamar atenção. Ela funciona, você começa a ler a matéria que diz que na última semana houveram diversos homicídios de maneira inexplicável ocorrendo em diversas partes do mundo incluindo Europa, China, Estados Unidos, Brasil entre outros. Basicamente as vítimas eram mortas por pessoas que aparentavam um estado mental completamente bestial e não tinham controle sobre suas ações. Além dessa matéria havia também uma semana que uma nova gripe estava se propagando de forma assustadora e por conta disso foi instituído que o uso de máscaras era obrigatório afim de frear seu contágio porém além de você quase ninguém está cumprindo com a regra. Você interrompe sua leitura quando seu ônibus chega, e apesar da leitura pesada, a caminho de casa seu pensamento só é um: sua esposa Lúcia e seu filho Leonardo.</p>

        <p>- “Lecote”, Lúcia cheguei! 
        Seu ritual ao chegar em casa é sempre o mesmo: chamar o filho de 6 anos e beijar a esposa que geralmente está assistindo tv. Dessa vez ninguém respondeu. Andando até a sala de estar você se depara com Lúcia numa expressão de apreensão enquanto encara a tela do laptop enquanto seu filho assistindo desenho animado na tv.</p>
        <p>- Oi pessoal, que cara é essa Lúcia?</p>
        <p>Ela se vira como se tivesse acabado de perceber sua presença. 
        - Você não está sabendo?  A Europa fechou as fronteiras para qualquer um por causa do vírus. 
        - Do que você está falando, que história é essa?  
        - Meu deus Ricardo está na internet! Esse vírus está transformando as pessoas em zumbis e o Reino Unido de maneira esperta trancou as portas já que é uma ilha e não existe maneira de entrar que não seja por avião ou barco.</p>
        <p>- Zumbis?!! Você tem noção do que você tá falando? Não existe esse tipo de coisa, isso é ficção. Biologicamente falando nem tem como um corpo morto ter função motora, até porque depois de um tempo ele endurece com o Rigor Mortis! – “Os seriados do Discovery Channel estão finalmente tendo utilidade” pensou Ricardo.</p>
        <p>- É só ver as imagens do Whatsup Ricardo e me diga se não é o que parece!
        Você senta ao lado de dela e dá um beijo na cabeça de seu filho. Na televisão está anunciando que amanhã deverá ocorrer toque de recolher e diversos comércios não essenciais deverão estar fechados, somente postos de gasolina, supermercados e bancos estarão funcionando normalmente para evitar a propagação dessa nova gripe.</p>
        <p>Em diversas mensagens do celular de sua esposa a notícias é a mesma “novo vírus assola o mundo”. Após tentar acalmar Lúcia dizendo que tudo não passa de fake News, você jantam e vão dormir, dessa vez todos juntos na mesma cama pois Leonardo parece estar assustado com o que ouviu. 
        - Pai essa doença tá vindo pra cá? – fala ele baixinho já demonstrando sono.
        - Não se preocupe isso tudo vai passar, você vai ver. Eu garanto que nada vai acontecer com vocês. 
        Depois de mais de uma hora encarando o teto você adormece pensando que amanhã é só mais um dia de trabalho e todas aquelas notícias não significam nada.</p>
        <div className="button-section">
          <Link to="/second-scene">
            <button className="button">
              CONTINUE
            </button>
          </Link>
        </div>
      </div>
    )
  }
}

export default FirstScene;