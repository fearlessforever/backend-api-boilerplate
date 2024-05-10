<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Spatie\RouteAttributes\Attributes\Get;
use Spatie\RouteAttributes\Attributes\Prefix;


#[Prefix('test')]
class TestController extends Controller
{
    #[Get('')]
    public function index( Request $request )
    {
        $data = [
            'user_ip_address' => $request->ip() ,
            'current_url' => $request->url() ,
        ];

        return myApiResponse( data: $data );
    }
}
