
export const myApiResponse = <T=any>( response: ApiResponseParams<T>  ) => Object.assign({
  version:'1.0',
  datetime: (new Date).toISOString(),
  timestamp: (new Date).getTime(),
  status:'success',
  code: 200 ,
  message: 'OK',
  data: [] ,
  errors:null,
} , response || {} ) as unknown as ApiResponseParams<T>

type ApiResponseParams<T> = My.ResponseApi<T> & My.Object