import React from 'react';

import Button from './Button';

export default function Info(props) {
  return (
    <section className={props.className}>
      <div>
        <p className="selected-movies">Selecionados</p>
        <p className="selected-movies">{props.count} de 8 filmes</p>
      </div>
      <Button type="submit" className="button"
        disabled={props.disabled}
        onClick={props.onClick}
      >
        Gerar Meu Campeonato
        </Button>
    </section>
  );
}