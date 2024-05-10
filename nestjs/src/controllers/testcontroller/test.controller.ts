import { myApiResponse } from '@Fearless/utils/helpers';
import { Controller, Get, Req } from '@nestjs/common';
import { Request } from 'express';

@Controller('api/test')
export class TestController {

  @Get()
  index( @Req() req: Request ){

    const data = {
      user_ip_address: `${ req.ip }`,
      current_url: `${req.protocol}://${req.get('Host')}${req.originalUrl}`,
    }
    return myApiResponse({ data , code:200 })
  }
}
