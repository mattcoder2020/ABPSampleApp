import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { StoreRoutingModule } from './store-routing.module';
import { StoreComponent } from './store.component';


@NgModule({
  declarations: [
    StoreComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    StoreRoutingModule
  ]
})
export class StoreModule { }
