import React from 'react';
import { withRouter } from 'react-router-dom';

import Info from './Info';

class Movies extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      count: [],
      disabled: true,
      options: []
    }
  }

  render() {
    const { count, disabled, options } = this.state;

    const handleCount = (checked) => {
      if (checked) {
        this.setState({ count: count.concat(checked) });
      } else {
        this.setState({ count: count.slice(0, -1) });
      }
    };

    const handleButton = () => {
      if (count.length === 7) {
        this.setState({ disabled: false })
      } else {
        this.setState({ disabled: true })
      }
    }

    const handleMovieList = (checked, e, movie) => {
      let titulo = movie.titulo;
      let nota = e.target.value;
      if (checked) {
        options.push({ "titulo": movie.titulo, "nota": e.target.value });
      } else {
        removeMovie(titulo, nota);
      }
    };

    const removeMovie = (titulo, nota) => {
      this.setState({ options: options.filter(item => item.titulo !== titulo && item.nota !== nota)})
    }

    const sendToFinal = () => {
      fetch('http://localhost:5000/api/championship', {
        method: 'POST',
        cache: 'no-cache',
        headers: {
          "Content-Type": "application/json;charset=utf-8"
        },
        body: JSON.stringify(options),
      })
        .then((response) => {
          return response.json();
        })
        .then((data) => {
          sessionStorage.setItem('championshipResult', JSON.stringify(data));
        })
        .catch(err => {
          console.log(err);
        });

      this.props.history.push('/final');
      window.location.reload();
    };

    return (
      <>
        <Info className="info"
          counterClassName="selected"
          count={count.length} disabled={disabled}
          onClick={() => sendToFinal()}
        />

        <section className="movies">
          <form className="movies__form">
            {
              this.props.movies.map(movie =>
                <label className="movie" key={movie.id}>
                  <input type="checkbox"
                    className="movie__choice"
                    checked={movie.checked}
                    value={movie.nota}
                    onChange={(e) => {
                      let checked = e.target.checked;
                      handleCount(checked, count);
                      handleButton(count);
                      handleMovieList(checked, e, movie);
                    }
                  }
                  />
                  <div className="movie__info">
                    <p className="movie__title">{movie.titulo}</p>
                    <p className="movie__year">{movie.ano}</p>
                  </div>
                </label>
              )
            }
          </form>
        </section>
      </>
    );
  }
}

export default withRouter(Movies);