import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataResponse } from './WorkExerience';
import { ToastrService } from 'ngx-toastr';
import { ElementRef, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-work-experience',
  templateUrl: './work-experience.component.html',
  styleUrls: ['./work-experience.component.css']
})
export class WorkExperienceComponent  {
  myData: DataResponse | undefined; 
  WorkExperienceResponse:DataResponse[] | undefined;
  ResponseLength:number=0;
  constructor(private http: HttpClient,private toastr: ToastrService) {
    this.WorkExperienceResponse=[];
  }
  
  ngOnInit(){
    
    this.http.get<DataResponse[]>('https://localhost:5001/api/WorkExperience').subscribe({
      next:(data)=>{
        console.log(data.length);
        this.ResponseLength=data.length;
        data.forEach(element => {
          this.WorkExperienceResponse?.push(element)
          console.log(element)
        });
        console.log(this.WorkExperienceResponse)
      },
      error:(err)=>{
        console.log(err);
        this.toastr.error("Data fetch from server failed.")
      }
    });
  }
  
}
