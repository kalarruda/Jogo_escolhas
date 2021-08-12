import React from 'react';

class SecondScene extends React.Component {
  render() {
    return(
      <div className="text-area">
        <p>Na manhã seguinte é anunciado pelo governo as regras para lidar com o novo vírus que já está se mostrando presente agora no Brasil:  uso de máscara é obrigatório quando fora de casa, só sair se for de extrema necessidade, se sentirem alguns dos sintomas como febre, dor no corpo e cansaço devem permanecer em casa e evitar contato com outras pessoas, pessoas mais idosas devem tentar permanecer em casa pois são as mais suscetíveis ao vírus. Nada de mortos vivos - pensou você - Lúcia precisa parar de ver esses seriados de zumbis.</p>
        <p>A ida ao banco agora é caótica. No centro da cidade do Rio de Janeiro o número de carros parece ter triplicado e o trânsito não anda. Ao redor você presencia uma aglomeração de diversas pessoas tentando desesperadamente entrar em um supermercado e algumas saindo com carrinhos lotados de compras, dentre essas pessoas poucas delas usavam máscaras. Uma briga se inicia na porta do mercado e policiais começam a interferir junto com seguranças. Logo o que era um tumulto se torna uma pancadaria e algumas pessoas tentando fugir da situação tentam desesperadamente entrar no ônibus, dentre elas uma mulher com uma criança de colo.</p>
        <div className="button-section">
          <button className="button">
            VOCÊ AJUDA A ABRIR A PORTA DO ÔNIBUS
          </button>
          <button className="button">
            VOCÊ SE AFASTA DA PORTA
          </button>
        </div>  
      </div>
    )
  }
}

export default SecondScene;