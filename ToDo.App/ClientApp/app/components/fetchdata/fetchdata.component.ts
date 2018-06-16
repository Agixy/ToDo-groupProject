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

    public newTask: { status: string;deadline: Date;description: string;priority: PriorityState;title: string } = {
        status: Status.ToDo,
        deadline: new Date(),
        description: "",
        priority: PriorityState.Low,
        title: "",
    };

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        http.get(baseUrl + 'api/Task').subscribe(
            result =>
            {
                this.tasks = result.json() as TaskDto[];
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
