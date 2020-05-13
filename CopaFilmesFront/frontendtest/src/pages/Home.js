import React from 'react';

import Header from '../components/Header';
import Movies from '../components/Movies';
import './styles.css';

export default class Home extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      movies: []
    }
  }

  componentDidMount() {
    fetch('http://localhost:5000/api/allmovies')
      .then(response => response.json())
      .then(data => {
        this.setState({ movies: data });
      })
      .catch(err => {
        console.log(`Infelizmente não deu para chamar a API, pois: ${err}`);
      });
  }

  render() {
    return (
      <main className="wrapper">
        <Header title="Fase de Seleção"
          description="Selecione 8 filmes que você deseja que entrem na competição e 
        depois pressione o botão Gerar Meu Campeonato para prosseguir."
        />

        <Movies
          movies={this.state.movies}
        />
      </main>
    );
  }
}
