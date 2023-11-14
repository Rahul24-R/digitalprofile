import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { MatCard } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { Comments } from './CommentResponse';
import { window } from 'rxjs';


@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent {

 commentData:Comments[];
 constructor(private http:HttpClient,private toaster:ToastrService) {
  this.commentData=[]
  
 }
 ngOnInit(){
    this.http.get<Comments[]>('https://localhost:5001/api/FeedBack').subscribe({
          next:(data)=>{
            console.log(data);
            data.forEach(element => {
              console.log(element)
               this.commentData.push(element)
            });
            console.log(this.commentData)
          }
        });
      
  }
  submit(Userfeedback: any){
    console.log("Review form submitted.",Userfeedback)
    console.log(Userfeedback.value)
    Userfeedback.likenumber=1;
    this.http.post("https://localhost:5001/api/feedback",Userfeedback.value).subscribe({
      next:()=>{
        console.log("post successful");
        this.toaster.success("Thanks for Feedback");
      },
      error:()=>{
        console.log("post operation failed");
        this.toaster.error("Error posting Feedback");
      }
    });

  }
}
