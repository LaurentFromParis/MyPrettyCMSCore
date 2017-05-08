"use strict";
var router_1 = require("@angular/router");
//import data from './scriptsg/commonData.js';
var index_component_1 = require("./index.component");
var about_component_1 = require("./about.component");
var contact_component_1 = require("./contact.component");
var appRoutes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: index_component_1.IndexComponent, data: { title: 'Home' } },
    { path: 'about', component: about_component_1.AboutComponent, data: { title: 'About' } },
    { path: 'contact', component: contact_component_1.ContactComponent, data: { title: 'Contact' } }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
exports.routedComponents = [index_component_1.IndexComponent, about_component_1.AboutComponent, contact_component_1.ContactComponent];
//# sourceMappingURL=app.routing.js.map