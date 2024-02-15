/*

# Övning 1

1. Metod, uri, version, headers, body
2. Metod, uri, version
3. Query parameter
4. Path variabel
5. (header) "Content-Type": "application/json"

# Övning 2

1. Status + meddelande, version, headers, body
2. Status + meddelande, version
3.
    200 Ok - Allt lyckades / gick bra med requesten
    404 Not Found - En resurs som inte finns hämtades
    500 Internal Server error - Något gick snett på servern (backend applikationen)
4. Headers, body
5. (header) "Content-Type": "application/json"
6. (header) "Content-Length"

# Övning 3

1. POST - För att POST används för att ladda upp ny information
2. GET - För att GET används för att hämta information
3. DELETE - För att DELETE används för att radera information

# Övning 4

1. Authorization
2. 403 Forbidden (men 401 Unauthorized skulle också fungera)

# Övning 5

JSON objekt med två egenskaper: name och age.

# Övning 6

[
    {
        "favoriteFood": "Tacos",
        "favoriteNumber": 8,
        "favotiteBoolean": true
    },
    {
        "favoriteFood": "Pannkakor",
        "favoriteNumber": 548,
        "favotiteBoolean": false
    },
    {
        "favoriteFood": "Godis",
        "favoriteNumber": 2,
        "favotiteBoolean": true
    }
]

# Övning 7

- POST /user/register (Registrera ny användare)
- POST /user/login (Logga in på användare)
- GET /user/search (Sök på - andra - användare)
- GET /user/{id} (Hämta information om en specifik användare, typ profilbild)
- POST /post/upload (Ladda upp/skapa ett inlägg)
- DELETE /post/{id} (Ta bort ett eget inlägg)

# Skip övning 8 och 9

*/
