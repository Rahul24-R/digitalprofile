import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { WorkExperienceComponent } from './work-experience/work-experience.component';
import { EducationComponent } from './education/education.component';
import { AchievementsComponent } from './achievements/achievements.component';
import { ReviewComponent } from './review/review.component';

const routes: Routes = [
  { path: 'dashboard', component: DashboardComponent },
  { path:'WorkExperiance',component:WorkExperienceComponent},
  { path:'Education',component:EducationComponent},
  { path:'Achievements',component:AchievementsComponent},
  { path:'Reviews',component:ReviewComponent},
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
