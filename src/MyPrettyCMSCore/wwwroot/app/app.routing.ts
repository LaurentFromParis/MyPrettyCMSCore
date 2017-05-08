
import { Routes, RouterModule } from '@angular/router';

//import data from './scriptsg/commonData.js';
import { IndexComponent } from './index.component';
import { AboutComponent } from './about.component';
import { ContactComponent } from './contact.component';

const appRoutes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: IndexComponent, data: { title: 'Home' } },
    { path: 'about', component: AboutComponent, data: { title: 'About' } },
    { path: 'contact', component: ContactComponent, data: { title: 'Contact' } }
];

export const routing = RouterModule.forRoot(appRoutes);

export const routedComponents = [IndexComponent, AboutComponent, ContactComponent];
