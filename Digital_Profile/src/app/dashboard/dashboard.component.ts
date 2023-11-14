import { Component } from '@angular/core';
import { DatePipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  Joiningdate: Date = new Date('2021-11-03');
  CurrentDate:Date = new Date();
  Experiance: any;
  Companies: Array<string>=[];
  Response:any;
  DataFailed:string="Data Fecth Failed."
  TempVar:string="";
  Para1: any="Fetching data..";
  Para0: any="Fetching data..";
  Para2: any="Fetching data..";
  Para3: any="Fetching data..";
  Para4: any="Fetching data..";
  Para5: any="Fetching data..";
  skillSet:Array<string>=[]
  skillcount:number=0;

  constructor(private http: HttpClient,private toaster:ToastrService) {
  
  }

  ngOnInit() {
    // Calculate the number of years of experience
    const currentDate = new Date();
    this.Experiance = currentDate.getFullYear() - this.Joiningdate.getFullYear();
    this.Companies=[...["GE HealthCare"]];
    this.skillSet=[...[".Net Framework",".Net Core","Angular","Entity Framework","WPF","WinForms","ASP.NET","MS SQL Server","C#","AWS","PowerShell scripting"]]
    this.skillcount=this.skillSet.length;
    this.Readtextfile();
    //this.AssignContent();
  }


  Readtextfile(){
    this.http.get('https://localhost:5001/api/DashBoard').subscribe({
     next:(x)=>{
      console.log(x);
      this.Response=x;
      this.TempVar=this.Response[2];
      this.TempVar=this.TempVar?.replace("[X]",this.Experiance).replace("[Y]",this.Companies.toString());
      this.Response[2]=this.TempVar;
      this.AssignContent();
    },
     error:(x)=>{
      this.Para1=this.DataFailed;
      this.Para0=this.DataFailed;
      this.Para2=this.DataFailed;
      this.Para3=this.DataFailed;
      this.Para4=this.DataFailed;
      this.Para5=this.DataFailed;
      this.toaster.error("Data fetch from server failed.");
      
     },
     complete:()=>{ console.log("Complete.")}
  });
  }

  AssignContent(){
    this.Para0=this.Response[0];
    this.Para1=this.Response[1];
    this.Para2=this.Response[2];
    this.Para3=this.Response[3];
    this.Para4=this.Response[4];
    this.Para5=this.Response[5];
  }
}
