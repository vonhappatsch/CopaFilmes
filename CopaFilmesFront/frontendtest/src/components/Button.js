import React from 'react';

export default function Button(props) {
  return (
    <button type="submit" className={props.className}
      onClick={props.onClick}
      disabled={props.disabled}
    >
      {props.children}
    </button>
  );
}