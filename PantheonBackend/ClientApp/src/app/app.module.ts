import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeroComponent } from './hero/hero.component';
import { HeroDetailComponent } from './hero-detail/hero-detail.component';
import { GodComponent } from './god/god.component';
import { GodDetailComponent } from './god-detail/god-detail.component';
import { CountryComponent } from './country/country.component';
import { CountryDetailComponent } from './country-detail/country-detail.component';

import { AuthService } from './auth.service';
import { CountryService } from './country.service';
import { GodService } from './god.service';
import { HeroService } from './hero.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeroComponent,
    HeroDetailComponent,
    GodComponent,
    GodDetailComponent,
    CountryComponent,
    CountryDetailComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'home', component: HomeComponent },
      { path: 'hero', component: HeroComponent },
      { path: 'hero/detail/:id', component: HeroDetailComponent },
      { path: 'country', component: CountryComponent },
      { path: 'country/detail/:id', component: CountryDetailComponent },
      { path: 'god', component: GodComponent },
      { path: 'god/detail/:id', component: GodDetailComponent }
    ])
  ],
  providers: [AuthService, HeroService, GodService, CountryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
