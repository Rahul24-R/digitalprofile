import { Component, Input } from '@angular/core';
import { Comments } from '../CommentResponse';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-comments',
  templateUrl: './comments.component.html',
  styleUrls: ['./comments.component.css']
})
export class CommentsComponent {
  
    @Input() commentobj:any;
    isLiked: boolean = false;
    
    constructor(private http:HttpClient) {
    }
  
      ngOnInit(){
      console.log(this.commentobj.name)
    }
    like(){
        if(this.isLiked){
          this.commentobj.likenumber--;
          this.isLiked=false;
        }
        else{
          this.commentobj.likenumber++;
          this.isLiked=true;
        }

        this.http.put('https://localhost:5001/api/feedback/${this.commentobj.id}',this.commentobj.likenumber).subscribe({
          next:(data)=>{
            console.log("updatd like count successfullu",data);
          },
          error:()=>{
            console.log("Error updating the like count.")
          }
        })
    }
}
