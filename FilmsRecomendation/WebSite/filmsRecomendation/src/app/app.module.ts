import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/shared/nav/nav.component';
import { FilmCardComponent } from './components/film-card/film-card.component';
import { GraphsComponent } from './pages/graphs/graphs.component';
import { FramePageComponent } from './pages/master/frame-page/frame-page.component';
import { HighchartsChartModule } from 'highcharts-angular';
import { GenrePageComponent } from './pages/genre-page/genre-page.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    FilmCardComponent,    
    GraphsComponent,//GraphsPage

    FramePageComponent,
    GenrePageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HighchartsChartModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
