# Livraria API

Esta é uma API RESTful para gerenciar autores e livros/revistas, desenvolvida em C# com ASP.NET Core e Entity Framework Core.

## Funcionalidades

- CRUD (Create, Read, Update, Delete) para Autores
- CRUD (Create, Read, Update, Delete) para Livros

## Como Executar a API

1.  **Navegue até o diretório do projeto:**

    ```bash
    cd D:\TrabalhoC#\Livraria.Api
    ```

2.  **Inicie a API:**

    ```bash
    dotnet run
    ```

    A API será iniciada e estará escutando em uma ou mais URLs (ex: `http://localhost:5141` ou `https://localhost:7141`). Anote a URL base para usar nos testes.

## Como Testar a API com Postman

Certifique-se de que a API esteja em execução antes de iniciar os testes.

### 1. Autores

#### 1.1. Criar um Autor (POST)

-   **URL:** `http://localhost:5141/api/Autores` (ou a URL da sua API)
-   **Método:** `POST`
-   **Headers:**
    -   `Content-Type: application/json`
-   **Body (raw, JSON):**

    ```json
    {
        "nome": "Machado de Assis"
    }
    ```

-   **Resposta Esperada (Status: 201 Created):**

    ```json
    {
        "id": 1,
        "nome": "Machado de Assis"
    }
    ```

#### 1.2. Obter Todos os Autores (GET)

-   **URL:** `http://localhost:5141/api/Autores`
-   **Método:** `GET`
-   **Resposta Esperada (Status: 200 OK):**

    ```json
    [
        {
            "id": 1,
            "nome": "Machado de Assis"
        }
    ]
    ```

#### 1.3. Obter um Autor Específico (GET)

-   **URL:** `http://localhost:5141/api/Autores/{id_do_autor}` (ex: `http://localhost:5141/api/Autores/1`)
-   **Método:** `GET`
-   **Resposta Esperada (Status: 200 OK):**

    ```json
    {
        "id": 1,
        "nome": "Machado de Assis"
    }
    ```

#### 1.4. Atualizar um Autor (PUT)

-   **URL:** `http://localhost:5141/api/Autores/{id_do_autor}` (ex: `http://localhost:5141/api/Autores/1`)
-   **Método:** `PUT`
-   **Headers:**
    -   `Content-Type: application/json`
-   **Body (raw, JSON):**

    ```json
    {
        "id": 1,
        "nome": "Machado de Assis (Atualizado)"
    }
    ```

-   **Resposta Esperada (Status: 204 No Content)**

#### 1.5. Excluir um Autor (DELETE)

-   **URL:** `http://localhost:5141/api/Autores/{id_do_autor}` (ex: `http://localhost:5141/api/Autores/1`)
-   **Método:** `DELETE`
-   **Resposta Esperada (Status: 204 No Content)**

### 2. Livros

#### 2.1. Criar um Livro (POST)

-   **Pré-requisito:** Certifique-se de que existe um autor com o `AutorId` especificado.
-   **URL:** `http://localhost:5141/api/Livros`
-   **Método:** `POST`
-   **Headers:**
    -   `Content-Type: application/json`
-   **Body (raw, JSON):**

    ```json
    {
        "titulo": "Dom Casmurro",
        "autorId": 1
    }
    ```

-   **Resposta Esperada (Status: 201 Created):**

    ```json
    {
        "id": 1,
        "titulo": "Dom Casmurro",
        "autorId": 1,
        "autor": null
    }
    ```
    *(Note: `autor` pode ser `null` na resposta de criação, mas será populado em GETs posteriores.)*

#### 2.2. Obter Todos os Livros (GET)

-   **URL:** `http://localhost:5141/api/Livros`
-   **Método:** `GET`
-   **Resposta Esperada (Status: 200 OK):**

    ```json
    [
        {
            "id": 1,
            "titulo": "Dom Casmurro",
            "autorId": 1,
            "autor": {
                "id": 1,
                "nome": "Machado de Assis"
            }
        }
    ]
    ```

#### 2.3. Obter um Livro Específico (GET)

-   **URL:** `http://localhost:5141/api/Livros/{id_do_livro}` (ex: `http://localhost:5141/api/Livros/1`)
-   **Método:** `GET`
-   **Resposta Esperada (Status: 200 OK):**

    ```json
    {
        "id": 1,
        "titulo": "Dom Casmurro",
        "autorId": 1,
        "autor": {
            "id": 1,
            "nome": "Machado de Assis"
        }
    }
    ```

#### 2.4. Atualizar um Livro (PUT)

-   **URL:** `http://localhost:5141/api/Livros/{id_do_livro}` (ex: `http://localhost:5141/api/Livros/1`)
-   **Método:** `PUT`
-   **Headers:**
    -   `Content-Type: application/json`
-   **Body (raw, JSON):**

    ```json
    {
        "id": 1,
        "titulo": "Dom Casmurro (Edição de Luxo)",
        "autorId": 1
    }
    ```

-   **Resposta Esperada (Status: 204 No Content)**

#### 2.5. Excluir um Livro (DELETE)

-   **URL:** `http://localhost:5141/api/Livros/{id_do_livro}` (ex: `http://localhost:5141/api/Livros/1`)
-   **Método:** `DELETE`
-   **Resposta Esperada (Status: 204 No Content)**
