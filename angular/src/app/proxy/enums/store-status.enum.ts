import { mapEnumToOptions } from '@abp/ng.core';

export enum StoreStatus {
  Opening = 0,
  Closed = 1,
}

export const storeStatusOptions = mapEnumToOptions(StoreStatus);
