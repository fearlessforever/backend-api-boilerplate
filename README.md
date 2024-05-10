
# Backend API Boilerplate
  - Framework Laravel ( php )
  - Framework NestJS ( typescript )
  - Framework Dotnet ( C# )

> [!CAUTION]
> Main purpose of this repo is for self reminder and learn the similarity of their design pattern between these framework

# REQUIREMENT
  - Laravel
    - php ^8.1
    - composer

  - Dotnet
    - .NET 7 SDK

  - NestJS
    - node v18
    - npm

# How to Use

  ## Install
  > [!IMPORTANT]
  > Install Depedencies , you can install one of them only if you dont want to run the others
    - ./run laravel install
    - ./run dotnet install
    - ./run nestjs install

  > [!NOTE]
  > For laravel make sure you select frankenphp when installing laravel octane

  ## Run App
    - Laravel
      - ./run laravel serve:dev
      - App run in -> localhost:8001

    - Dotnet
      - ./run dotnet serve:dev
      - App run in -> localhost:8002

    - Nestjs
      - ./run netsjs serve:dev
      - App run in -> localhost:8003


# Doc
  - [Framework Routing](docs/ROUTES.md)
  - Middleware
  - Handle Error
  - DB connections & Migrations