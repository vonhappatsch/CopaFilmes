import React from 'react';

import './styles.css';

export default function Header({ title, description }) {
  return (
    <header className="header">
      <p className="moviecup">Campeonato de Filmes</p>
      <h1 className="title">{title}</h1>
      <hr className="decoration" />
      <p className="description">{description}</p>
    </header>
  );
}