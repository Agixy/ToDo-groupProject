import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public tasks: TaskDto[];
    public status = Status;

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

    public deleteTask(id: number) {
        this.http.delete(this.baseUrl + 'api/task/' + id).subscribe(
            result => {
                this.refresh();
            },
            error => {
                console.error(error);
            }
        );
    }

}

interface TaskDto {
    id: number;
    status: string;
    deadline: Date;
    title: string;
    description: string;
    priority: number;
}


enum PriorityState {
    Low="Low",
    Normal="Normal",
    High="High"
}

enum Status {
    ToDo = "ToDo",
    InProgress = "InProgress",
    Done = "Done"
}
