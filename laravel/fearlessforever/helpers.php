<?php

if (! function_exists('myApiResponse')) {
	function myApiResponse( $data = [] , int $code = 200 , string $message = null , bool $is_success= true , array $extraData = []  )
  {
		$time = now();

    return response()->json([
      'version'=>'1.0',
      'datetime'=> $time?->toIso8601String(),
      'timestamp'=> $time?->timestamp,
      'status'=> $is_success ? 'success' : 'error',
      'code'=> $code ?? 200 ,
      'message'=> $message ?? 'OK',
      'data'=> $data ?? [] ,
      'errors'=> null ,
      ...$extraData ,
    ])->setStatusCode( $code );
	}
}