import React from 'react';

import Header from '../components/Header';
import './styles.css';

export default function Final() {
  let result = JSON.parse(sessionStorage.championshipResult) || [];

  return (
    <div className="wrapper">
      <Header title="Resultado Final" 
        description="Veja o resultado final do 
        Campeonato de filmes de forma simples e rápida" 
      />

    
      <div className="wrapper-result">
        <div className="result">
          <p className="result__position">1º</p>
          <p className="result__title">{result[0].titulo}</p>
        </div>
      </div>

      <div className="wrapper-result">
        <div className="result">
          <p className="result__position">2º</p>
          <p className="result__title">{result[1].titulo}</p>
        </div>
      </div>
    </div>  
  );
}
