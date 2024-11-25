import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{
  path: '',
  redirectTo: 'grocery',
  pathMatch: 'full'
},
{
  path: 'grocery',
  loadChildren: () =>
    import('./grocery/grocery.module').then(m => m.GroceryModule)
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
