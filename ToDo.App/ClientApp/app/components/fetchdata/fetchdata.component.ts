import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
//import {TaskDto } from './TaskDto';


@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public tasks: TaskDto[];
    title: string = "";
    deadline: Date = (null) as any;
    description: string = "";

      constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        this.refresh();
    }

    private refresh() {
        this.http.get(this.baseUrl + 'api/Task').subscribe(
            result => {
                this.tasks = result.json() as TaskDto[];
            },
            error => {
                console.error(error);
            });
    }

    public chooseStatus(id: number, status: string) {
        const patchBody = {
            newStatus: status
        };

        this.http.patch(this.baseUrl + 'api/task/' + id, patchBody).subscribe(
            result => {
                this.refresh();
            },
            error => {
                console.error(error);
            });
    }

onSubmit(): void {
        //create task from submit
        this.newTask.title = this.title;
        this.newTask.deadline = this.deadline;
        this.newTask.description = this.description;

        //post task to server
        this.http.post(this.baseUrl + 'api/Task', this.newTask).subscribe(result => {
            this.title = "";
            this.deadline = new Date();
            this.description = "";
            console.log("Task has been added");
        });
 }

}


}

interface TaskDto {
    status: Status;
    deadline: Date;
    title: string;
    description: string;
    priority: PriorityState;
}

enum PriorityState {
    Low=0,
    Normal=1,
    High=2
}

enum Status {
    ToDo = "ToDo",
    InProgress = "InProgress",
    Done = "Done"
}
