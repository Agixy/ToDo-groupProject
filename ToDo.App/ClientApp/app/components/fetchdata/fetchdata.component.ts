import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public tasks: TaskDto[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Task').subscribe(
            result =>
            {
                this.tasks = result.json() as TaskDto[];
            },
            error => {
                console.error(error);
            });
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
