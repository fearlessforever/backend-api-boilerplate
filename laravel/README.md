<p align="center"><a href="https://laravel.com" target="_blank"><img src="https://raw.githubusercontent.com/laravel/art/master/logo-lockup/5%20SVG/2%20CMYK/1%20Full%20Color/laravel-logolockup-cmyk-red.svg" width="400" alt="Laravel Logo"></a></p>

<p align="center">
<a href="https://github.com/laravel/framework/actions"><img src="https://github.com/laravel/framework/workflows/tests/badge.svg" alt="Build Status"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/dt/laravel/framework" alt="Total Downloads"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/v/laravel/framework" alt="Latest Stable Version"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/l/laravel/framework" alt="License"></a>
</p>


# Note
  - How to Run
    - DEV mode : ```php artisan serve --port 8001```
    - In browser : localhost:8001
  - php artisan route:list
  
# Library
  - laravel-route-attributes
    - composer require spatie/laravel-route-attributes
    - https://github.com/spatie/laravel-route-attributes

  - laravel octane
    - composer require laravel/octane
    - php artisan octane:install
    - selected php server FrankenPHP
      - RUN : ```php artisan octane:start --server=frankenphp --port=8001 --workers=16 --host=0.0.0.0```
    - Guide : https://laravel.com/docs/11.x/octane#introduction
    
# REQUIREMENT
  - php ^8.1
  - composer

## SETUP
  - After clone repository
  - cd laravel
  - ```composer run post-root-package-install```
  - ```composer run post-create-project-cmd```
  - ```composer install```
  - install octane : ```php artisan octane:install```
