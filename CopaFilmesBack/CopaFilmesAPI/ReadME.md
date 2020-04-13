Este é o back end da copa dos filmes

No diretório correto da aplicação, rode:

### `dotnet run`

E então a url base da api estará disponível no seguinte endereço:
[http://localhost:5000](http://localhost:5000)

Caso deseje testar no postman, por exemplo, os endpoints são: 

### `/api/allmovies` {get}

### `/api/championship` {post}

O post aceita um json com 8 competidores (o título e a nota do filme).
Ex:

````yaml
  [
      {
          "titulo": "Os Incríveis 2",
          "nota": "8.5"
      },
      {
          "titulo": "Vingadores: Guerra Infinita",
          "nota": "8.8"
      },
      {
          "titulo": "Jurassic World: Reino Ameaçado",
          "nota": "6.7"
      },
      {
          "titulo": "Deadpool 2",
          "nota": "8.1"
      },
      {
          "titulo": "Oito Mulheres e um Segredo",
          "nota": "6.3"
      },
      {
          "titulo": "Han Solo: Uma História Star Wars",
          "nota": "7.2"
      },
      {
          "titulo": "Hereditário",
          "nota": "7.8"
      },
      {
          "titulo": "Thor: Ragnarok",
          "nota": "7.9"
      }
  ]
