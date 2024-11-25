import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { GroceriesComponent } from './groceries/groceries.component';
import { ReactiveFormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import { CustomerDetailsComponent } from '../customer-details/customer-details.component';
import { DialogModule } from 'primeng/dialog';

const routes: Routes = [{
  path: '',
  component: GroceriesComponent
},
{
  path: 'customer-rewards',
  component: CustomerDetailsComponent
}];

@NgModule({
  declarations: [GroceriesComponent, CustomerDetailsComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    TableModule,
    DialogModule,
    RouterModule.forChild(routes)
  ]
})
export class GroceryModule { }
