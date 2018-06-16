import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
//import {TaskDto } from './TaskDto';


@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public tasks: TaskDto[];

    public newTask: { status: string;deadline: string;description: string;priority: PriorityState;title: string } = {
        status: "",
        deadline: "1979-12-31",
        description: "",
        priority: PriorityState.High,
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
         

        //post task to server
        this.http.post(this.baseUrl + 'api/Task', this.newTask);
 

        //this.http.get('http://localhost:64951/api/user').subscribe(data => {
        //    console.log(data);
        //});
    }
}

interface TaskDto {
    status: string;
    deadline: Date;
    title: string;
    description: string;
    priority: number;
}

enum PriorityState {
    Low=0,
    Normal=1,
    High=2
}
