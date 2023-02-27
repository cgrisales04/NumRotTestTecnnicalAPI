
# NumRotTestTecnnicalAPI - Backend

APIRestFull creada en .NET v6.0 varios de sus Endpoints son:

- [GET] - Obtener usuarios
```
curl --location 'http://localhost:5000/api/infousers'
```
- [GET] - Obtener usuario en especifico
```
curl --location 'http://localhost:5000/api/infousers/10'
```

- [POST] - Crear usuario
```
curl --location 'http://localhost:5000/api/infousers' \
--header 'Content-Type: application/json' \
--data-raw '{
    "identification": "2748238",
    "password": "Louis123.*+",
    "name": "Luis",
    "second_name": "",
    "last_name": "Venitez",
    "second_last_name": "Moreno",
    "phone": "484920323",
    "email": "dgomez@gmail.com",
    "address": "Cra 7 Calle 55",
    "age": "21",
    "TypeUserId": "1",
    "GenderId": "1"
}'
```

- [PUT] - Editar usuario
```
curl --location --request PUT 'http://localhost:5000/api/infousers/2' \
--header 'Content-Type: application/json' \
--data-raw '{
    "identification": "99988839",
    "password": "C123123",
    "name": "Luis",
    "second_name": "Norberto",
    "last_name": "Loreto",
    "second_last_name": "Minslgo",
    "phone": "8893748293",
    "email": "lnorberto@gmail.com",
    "address": "Cra 7 Calle 55",
    "age": "24",
    "TypeUserId": 1,
    "GenderId": 1
}'
```

- [DELETE] - Eliminar usuario
```
curl --location --request DELETE 'http://localhost:5000/api/infousers/13'
```
👶🏽 Dev. Cristian Grisales - 🎓 Engineer in process
