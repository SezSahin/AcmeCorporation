import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TicketComponent } from './ticket/ticket.component';
import { AuthGuard } from './auth.guard';
import { ProductComponent } from './product/product.component';

const appRoutes: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full'},
    { path: 'home', component: HomeComponent },
    { path: 'receipt', component: TicketComponent },
    { path: 'product', component: ProductComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule],
    providers: []
})

export class AppRoutingModule{

}