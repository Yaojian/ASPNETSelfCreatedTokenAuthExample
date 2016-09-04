This repository is forked from https://github.com/mrsheepuk/ASPNETSelfCreatedTokenAuthExample.

I updated the code to ASP.NET Core 1.0.

## Build and run the project

1. Clone the repository
2. Run `dotnet restore` from the command line under the root of the repository directory
3. Run `dotnet run` to run the application

## Test the application

Personally I recommand [Postman](https://www.getpostman.com) to test web apis.

### 1. Get the token

```
POST /api/token HTTP/1.1
Host: localhost:5000
Content-Type: application/json

{
    "username": "TEST",
    "password": "TEST"
}
```

### 2. Call an authorized api with the token retrieved above

```
GET /api/Values/1 HTTP/1.1
Host: localhost:5000
Content-Type: application/json
Authorization: Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IlRFU1QiLCJFbnRpdHlJRCI6MSwibmJmIjoxNDcyOTgxODYyLCJleHAiOjE0NzI5ODE5ODIsImlhdCI6MTQ3Mjk4MTg2MiwiaXNzIjoiRXhhbXBsZUlzc3VlciIsImF1ZCI6IkV4YW1wbGVBdWRpZW5jZSJ9.QGGEqfcLxjk-mHvVEHg91IKWY971W2id4LehRxrDssHsiOMW4wJxCTYRg1ec8IjifJWevJeznqLawZdpqKz0UjRQFJ11QXYRXGTzg4PmJKvTj9kyVDcsYvFNPmjLDbr0Wp8Wos3nTz81PTiod3R-32L2hjCOK1fPpQuKLwjhwBqjdwd6zoolvaMv7i8pRIRjWYqOLZcZ5zzmhVzXHgl1mYTaSqce3ecgZQfPxKV7HfJS_tXcrCfj06OYd1rwz6SOhN-sNbtr88_VS12qUQJu11OmeRLclJf4Y-AZtnRJqpCtIX1ard7p5KuJSQ1WGSAYuqM-BRBdvqHLga_EJmAWJQ
```

NOTE: You should change to token to the result in step 1.
