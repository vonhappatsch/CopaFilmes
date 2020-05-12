import React from 'react';

import Button from './Button';
import SelectedMovies from './SelectedMovies';
import './styles.css';

export default function Info(props) {
  return (
    <section className={props.className}>
      <SelectedMovies {...props} />

      <Button type="submit" className="button"
        disabled={props.disabled}
        onClick={props.onClick}
      >
        Gerar Meu Campeonato
        </Button>
    </section>
  );
}