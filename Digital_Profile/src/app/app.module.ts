import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { WorkExperienceComponent } from './work-experience/work-experience.component';
import { EducationComponent } from './education/education.component';
import { AchievementsComponent } from './achievements/achievements.component';
import { ReviewComponent } from './review/review.component';
import { GoogleMapsModule } from '@angular/google-maps';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import {MatCardModule} from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { CommentsComponent } from './review/comments/comments.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    WorkExperienceComponent,
    EducationComponent,
    AchievementsComponent,
    ReviewComponent,
    CommentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    GoogleMapsModule,
    HttpClientModule,
    ToastrModule.forRoot({
      positionClass:"toast-top-center",
      preventDuplicates:true,
      timeOut:2000
    }),
    FormsModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 
}
