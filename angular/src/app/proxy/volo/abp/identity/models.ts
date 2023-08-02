import type { ExtensibleEntityDto, ExtensibleFullAuditedEntityDto, ExtensibleObject, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import type { Entity } from '../domain/entities/models';
import type { CreationAuditedEntity, FullAuditedAggregateRoot } from '../domain/entities/auditing/models';

export interface GetIdentityUsersInput extends PagedAndSortedResultRequestDto {
  filter?: string;
}

export interface IdentityClaim extends Entity<string> {
  tenantId?: string;
  claimType?: string;
  claimValue?: string;
}

export interface IdentityRoleDto extends ExtensibleEntityDto<string> {
  name?: string;
  isDefault: boolean;
  isStatic: boolean;
  isPublic: boolean;
  concurrencyStamp?: string;
}

export interface IdentityUser extends FullAuditedAggregateRoot<string> {
  tenantId?: string;
  userName?: string;
  normalizedUserName?: string;
  name?: string;
  surname?: string;
  email?: string;
  normalizedEmail?: string;
  emailConfirmed: boolean;
  passwordHash?: string;
  securityStamp?: string;
  isExternal: boolean;
  phoneNumber?: string;
  phoneNumberConfirmed: boolean;
  isActive: boolean;
  twoFactorEnabled: boolean;
  lockoutEnd?: string;
  lockoutEnabled: boolean;
  accessFailedCount: number;
  shouldChangePasswordOnNextLogin: boolean;
  entityVersion: number;
  lastPasswordChangeTime?: string;
  roles: IdentityUserRole[];
  claims: IdentityUserClaim[];
  logins: IdentityUserLogin[];
  tokens: IdentityUserToken[];
  organizationUnits: IdentityUserOrganizationUnit[];
}

export interface IdentityUserClaim extends IdentityClaim {
  userId?: string;
}

export interface IdentityUserCreateDto extends IdentityUserCreateOrUpdateDtoBase {
  password: string;
}

export interface IdentityUserCreateOrUpdateDtoBase extends ExtensibleObject {
  userName: string;
  name?: string;
  surname?: string;
  email: string;
  phoneNumber?: string;
  isActive: boolean;
  lockoutEnabled: boolean;
  roleNames: string[];
}

export interface IdentityUserDto extends ExtensibleFullAuditedEntityDto<string> {
  tenantId?: string;
  userName?: string;
  name?: string;
  surname?: string;
  email?: string;
  emailConfirmed: boolean;
  phoneNumber?: string;
  phoneNumberConfirmed: boolean;
  isActive: boolean;
  lockoutEnabled: boolean;
  lockoutEnd?: string;
  concurrencyStamp?: string;
  entityVersion: number;
}

export interface IdentityUserLogin extends Entity {
  tenantId?: string;
  userId?: string;
  loginProvider?: string;
  providerKey?: string;
  providerDisplayName?: string;
}

export interface IdentityUserOrganizationUnit extends CreationAuditedEntity {
  tenantId?: string;
  userId?: string;
  organizationUnitId?: string;
}

export interface IdentityUserRole extends Entity {
  tenantId?: string;
  userId?: string;
  roleId?: string;
}

export interface IdentityUserToken extends Entity {
  tenantId?: string;
  userId?: string;
  loginProvider?: string;
  name?: string;
  value?: string;
}

export interface IdentityUserUpdateDto extends IdentityUserCreateOrUpdateDtoBase {
  password?: string;
  concurrencyStamp?: string;
}

export interface IdentityUserUpdateRolesDto {
  roleNames: string[];
}
