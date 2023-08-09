import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AccessManagment',
    logoUrl: '',
  },
  oAuthConfig: {    
    issuer: 'backend',
    redirectUri: baseUrl,
    clientId: 'AccessManagment_App',
    responseType: 'code',
    scope: 'offline_access AccessManagment',
    requireHttps: true,
  },
  apis: {
    default: {     
      url: 'backend',
      rootNamespace: 'AbpSampleApp.AccessManagment',
    },
  },
} as Environment;
