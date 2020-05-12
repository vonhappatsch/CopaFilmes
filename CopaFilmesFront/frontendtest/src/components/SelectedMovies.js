import React from 'react';

export default function(props) {
  return (
    <div className={props.counterClassName}>
      <p>Selecionados</p>
      <p>{props.count} de 8 filmes</p>
    </div>
  );
}